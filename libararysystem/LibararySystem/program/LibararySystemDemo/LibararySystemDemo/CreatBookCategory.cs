using ISpan.Utility;
using LibararySystemDemo.model.dataindex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibararySystemDemo
{
	public partial class CreatBookCategory : Form
	{
		public CreatBookCategory()
		{
			InitializeComponent();
			InitForm();
		}



		private BooksIndexView ParseTobookcategoryIndexVM(DataRow row)
		{
			return new BooksIndexView
			{

				Author = row.Field<string>("Author"),
                //CategoryID = row.Field<int>("CategoryID"),
				BookName = row.Field<string>("BookName"),
				ISBN = row.Field<string>("ISBN"),
				PublishYear = row.Field<int>("PublishYear"),
				//BookID = row.Field<int>("BookID")
			};
		}

		private void InitForm()
		{

			categorycombobox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM BookClass order by class";
			var dbHelper = new SqlDBhelper("default");

			List<BookCategoryIndexView> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => TOBookClassIndex(row))
				.Prepend(new BookCategoryIndexView { CategoryID = 0, CategoryName = String.Empty })
				.ToList();

			this.categorycombobox.DataSource = categories;

		}

		private BookCategoryIndexView TOBookClassIndex(DataRow row)
		{
			return new BookCategoryIndexView
            {
				CategoryID = row.Field<int>("CategoryID"),
                CategoryName = row.Field<string>("CategoryName"),
			};
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{ 
//			//取得表單的各欄位值
//			int CategoryID = ((BooksIndexView)this.categoryIdComboBox.SelectedItem).Id;
//			string productName = productNameTextBox.Text;
//			int listPrice = listPriceTextBox.Text.ToInt(-1); //如果没填牌價,傳回-1


//			// 將它們繫結到ViewModel
//			BookCategoryView model = new BookCategoryView
//			{
//				CategoryId = categoryId,
//				ProductName = productName,
//				ListPrice = listPrice
//			};

//			// 針對ViewModel進行欄位驗證
//			string errorMsg = string.Empty;
//			if (string.IsNullOrEmpty(model.ProductName)) errorMsg += "商品名稱必填\r\n";
//			if (model.ListPrice < 0) errorMsg += "牌價必需輸入大於或等於零的整數\r\n";

//			if (string.IsNullOrEmpty(errorMsg) == false)
//			{
//				//表示至少一欄有錯誤
//				MessageBox.Show(errorMsg);
//				return; // 不再向下執行
//			}


//			// 如果通過驗證,就新增記錄
//			string sql = @"INSERT INTO Products
//(CategoryId,ProductName, ListPrice)
//VALUES
//(@CategoryId,@ProductName, @ListPrice)";

//			var parameters = new sqlparameterbuilder()
//				.AddInt("CategoryId", model.CategoryId)
//				.AddNVarchar("ProductName", 50, model.ProductName)
//				.AddInt("ListPrice", model.ListPrice)
//				.Build();

//			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

//			this.DialogResult = DialogResult.OK;
		}
	}
}
