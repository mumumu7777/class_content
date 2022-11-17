using ISpan.Estore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Estore
{
	public partial class ProductsForm : Form
	{
		private ProductIndexView[] products = null;
		public ProductsForm()
		{
			InitializeComponent();
			InitForm();
			//顯示商品紀錄
			DisplayProducts();

		}

		private void DisplayProducts()
		{
			string sql =@"SELECT P.Id, P.ProductName, P.ListPrice, C.CategoryName FROM Products P
INNER JOIN ProductCategories C ON P.CategoryId = C.Id";

			//加入where
			SqlParameter[] parameters = new SqlParameter[] { };
			//取得篩選值
			int categoryID = ((ProductCategoryVM)categoryidcombox.SelectedItem).id;
			if (categoryID > 0)
			{
				sql += "where categoryid=@categoryid";
				parameters = new sqlparameterbuilder().ADDint("categoryid", categoryID).build();
			}


			// 加入排序子句
			sql += " ORDER BY C.DisplayOrder, P.ProductName";
			var dbhelper = new SqlDBhelper("default");
			//存放field裡,稍後在grid cellClick 事件需要用到
			products = dbhelper.Select(sql,parameters)//paramerters
				.AsEnumerable()
				.Select(row =>parsetoindexvm(row))
				.ToArray();

			BindData(products);
		}
		private void BindData(ProductIndexView[] data)
		{
			dataGridView1.DataSource = data;
		}

		private ProductIndexView parsetoindexvm(DataRow row)
		{
			return new ProductIndexView
			{
				id = row.Field<int>("id"),
				CategoryName = row.Field<string>("Categoryname"),
				ProductName = row.Field<string>("ProductName"),
				ListPrice = row.Field<int>("ListPrice")
			};
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			ProductIndexView row = this.products[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditProductionForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProducts();
			}
		}

		private void InitForm()
		{
			var sql = "select * from productcategories order by displayorder";
			var dbhelper = new SqlDBhelper("default");
			List<ProductCategoryVM> categories = dbhelper.Select(sql, null).AsEnumerable().Select(row => TocategoryVM(row)).Prepend(new ProductCategoryVM { id=0, Categoryname =String.Empty }).ToList();
			this.categoryidcombox.DataSource = categories;
		}

		private ProductCategoryVM TocategoryVM(DataRow row)
		{
			return new ProductCategoryVM
			{
				id = row.Field<int>("id"),
				Categoryname = row.Field<string>("CategoryName"),
				Displayorder = row.Field<int>("DisplayOrder"),		
			};
		}

		private void searchbtn_Click(object sender, EventArgs e)
		{
			DisplayProducts();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindx = e.RowIndex;
			if (rowindx < 0) return;
			ProductIndexView row = this.products[rowindx];//data user click 
			int id = row.id;// user click data's id 

			// 把id傳給表單的建構函數
			var frm = new EditProductionForm(id);
			//frm.Show();
			
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProducts();
			}
		}

		private void addbtn_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductForm();
			//frm.ShowDialog();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}
		}
	}
}
