using ISpan.Utility;
using LibararySystemDemo.extensiontool;
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
	public partial class CreateBooks : Form
	{
		public CreateBooks()	
		{
			InitializeComponent();
			InitForm();
		}



		private BookCategoryIndexView ParseTobookcategoryIndexVM(DataRow row)
		{
			return new BookCategoryIndexView
            {

                CategoryName = row.Field<string>("CategoryName"),
                CategoryID = row.Field<int>("CategoryID")
            };
		}

        private void InitForm()
        {

			categorycombobox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM BookCategory order by CategoryName";
			var dbHelper = new SqlDBhelper("default");

			List<BookCategoryIndexView> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseTobookcategoryIndexVM(row))
				.Prepend(new BookCategoryIndexView { CategoryID = 0, CategoryName = String.Empty })
				.ToList();

			this.categorycombobox.DataSource = categories;

		}

        private BooksView TOBooksIndex(DataRow row)
		{
			return new BooksView
            {
				CategoryID = row.Field<int>("CategoryID"),
                CategoryName = row.Field<string>("CategoryName"),
                Author = row.Field<string>("Author"),
                 BookID = row.Field<int>("BookID"),
                 BookName = row.Field<string>("BookName"),
                 ISBN = row.Field<string>("ISBN"),
                PublishYear = row.Field<int>("PublishYear"),
            };
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			//取得表單的各欄位值
			int Categoryid = ((BookCategoryIndexView)this.categorycombobox.SelectedItem).CategoryID;
			string bookname = BookTXTBOX.Text;
			string author = authortxtbox.Text;
			string isbn = isbmtxtbox.Text;
			int publishyear = pbyeartxtbox.Text.Toint(-1);
			 //如果没填,傳回-1


			//將它們繫結到ViewModel
		   BooksIndexView model = new BooksIndexView
           {
               BookName = bookname,
			   Author = author,
			   ISBN = isbn,
			   PublishYear = publishyear,
			   CategoryID = Categoryid 			 
           };

			//針對ViewModel進行欄位驗證
			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.BookName)) errorMsg += "書名必填\r\n";
            if (string.IsNullOrEmpty(model.Author)) errorMsg += "作者必填\r\n";
            if (string.IsNullOrEmpty(model.ISBN)) errorMsg += "ISBN\r\n";
            if (model.PublishYear <0 ) errorMsg += "請正確輸入西元年分,如:1911\r\n";
			
			if (string.IsNullOrEmpty(errorMsg) == false)
			{
				//表示至少一欄有錯誤
				MessageBox.Show(errorMsg);
				return; // 不再向下執行
			}


			//如果通過驗證,就新增記錄
			string sql = @"INSERT INTO BOOKS
(CategoryId,BookName,Author, ISBN,PublishYear)
VALUES
(@CategoryId,@BookName, @Author,@ISBN,@PublishYear)";

			var parameters = new sqlparameterbuilder()
				.ADDint("CategoryId", model.CategoryID)
				.ADDNvarchar("BookName", 50, model.BookName)
				.ADDNvarchar("Author", 50, model.Author)
                .ADDNvarchar("ISBN", 50,model.ISBN)
                .ADDint("PublishYear",model.PublishYear)
                .build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void categorycombobox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void CreateBooks_Load(object sender, EventArgs e)
		{

		}
	}
}
