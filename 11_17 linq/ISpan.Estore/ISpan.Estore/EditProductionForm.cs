using ISpan.Estore.Infra.Extensions;
using ISpan.Estore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Estore
{
	public partial class EditProductionForm : Form
	{
		private int id;
		public EditProductionForm(int id)
		{
			InitializeComponent();
			InitForm();	
			this.id = id;
		}
		private void InitForm()
		{
			var sql = "select * from productcategories order by displayorder";
			var dbhelper = new SqlDBhelper("default");
			List<ProductCategoryVM> categories = 
				dbhelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => TocategoryVM(row))
				.Prepend(new ProductCategoryVM { id = 0, Categoryname = String.Empty }).ToList();
			this.categoridcombox.DataSource = categories;
		}
		private void Binddata(int id)
		{
			string sql = "select * from ProductCategories where Id=@Id";
			var parameters = new sqlparameterbuilder().ADDint("Id", id).build();
			DataTable data = new SqlDBhelper("default").Select(sql, parameters);
			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉不知道發生什麼事");
				this.DialogResult = DialogResult.Abort;
				//this.Close();
				//return;		
			}
			else
			{
				DataRow row = data.Rows[0];

				productnametxt.Text = row.Field<string>("CategoryName");
				listpricetxt.Text = row.Field<int>("DisplayOrder").ToString();
			}
			//將找到的一筆紀錄由data table轉換到productVM
			ProductVM model = ToproductVM(data.Rows[0]);
			//再將viewmodel值聯繫各控制向
			categoridcombox.SelectedItem = ((List<ProductCategoryVM>)categoridcombox.DataSource).FirstOrDefault(x => x.id == model.CategoryID);

			
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
		private ProductVM ToproductVM(DataRow row)
		{
			return new ProductVM
			{
				Id = row.Field<int>("id"),
				CategoryID = row.Field<int>("CategoryID"),
				ProductName = row.Field<string>("ProductName"),
				ListPrice = row.Field<int>("ListPrice"),
			};
		}

		private void updatebtn_Click(object sender, EventArgs e)
		{
			//取得個表單值
			int categoryid = ((ProductCategoryVM)this.categoridcombox.SelectedItem).id;
			string productName = productnametxt.Text;
			int listprice = listpricetxt.Text.Toint(-1);

			//將他們聯繫到viewmodel
			ProductVM model = new ProductVM { CategoryID = categoryid, ProductName = productName, ListPrice = listprice };

			//針對viewmodel進行欄位驗證
			string erreoMsg = string.Empty;
			if (string.IsNullOrEmpty(model.ProductName)) erreoMsg += "商品名稱必填\r\n";
			if (model.ListPrice < 0) erreoMsg += "商品名稱必填\r\n";
			if (string.IsNullOrEmpty(erreoMsg) == false)
			{
				MessageBox.Show(erreoMsg);
				return;
			}

			//update record
			

			string sql = @"update products set categoryid = @categoryid,ProductName=@ProductName,ListPrice=@ListPrice where id=@id";

			var parameters = new sqlparameterbuilder().ADDint("categoryid", model.CategoryID)
				.ADDNvarchar("ProductName", 50, ProductName)
				.ADDint("ListPrice", model.ListPrice)
				.ADDint("id", this.id)
				.build();
			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);
			MessageBox.Show("紀錄已新增");

			this.DialogResult = DialogResult.OK;

		}
	}
}
