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
	public partial class CreateProductForm : Form
	{
		public CreateProductForm()
		{
			InitializeComponent();
			InitForm();
		}

		private void CreateProductForm_Load(object sender, EventArgs e)
		{



		}

		private void InitForm()
		{
			categorycombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			var sql = "select * from productcategories order by displayorder";
			var dbhelper = new SqlDBhelper("default");
			List<ProductCategoryVM> categories = dbhelper.Select(sql, null).AsEnumerable().Select(row => TocategoryVM(row)).ToList();
			this.categorycombobox.DataSource = categories;
		}

		private ProductCategoryVM TocategoryVM(DataRow row)
		{
			return new ProductCategoryVM
			{
				id = row.Field<int>("id"),
				Categoryname = row.Field<string>("Categoryname"),
				Displayorder = row.Field<int>("Displayorder")
			};
		}

		private void savebtn_Click(object sender, EventArgs e)
		{
			//取得個表單值
			int categoryid = ((ProductCategoryVM)this.categorycombobox.SelectedItem).id;
			string productName = productnamebox.Text;
			int listprice = listpricebox.Text.Toint(-1);

			//將他們聯繫到viewmodel
			ProductVM model= new ProductVM { CategoryID = categoryid, ProductName = productName, ListPrice = listprice};

			//針對viewmodel進行欄位驗證
			string erreoMsg = string.Empty;
			if (string.IsNullOrEmpty(model.ProductName)) erreoMsg += "商品名稱必填\r\n";
			if (model.ListPrice < 0) erreoMsg += "商品名稱必填\r\n";
			if (string.IsNullOrEmpty(erreoMsg) == false)
			{
				MessageBox.Show(erreoMsg);
				return;
			}




			string sql = @"INSERT INTO Products
(CategoryId,ProductName, ListPrice)
VALUES
(@CategoryId,@ProductName, @ListPrice)";

			var parameters = new sqlparameterbuilder()
				.ADDint("CategoryId", model.CategoryID)
				.ADDNvarchar("ProductName", 50, model.ProductName)
				.ADDint("ListPrice", model.ListPrice)
				.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;



		}
	}
}
