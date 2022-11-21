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
	public partial class EditBooksForm : Form
	{
		private int id;
		public EditBooksForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
		}

		private void BindData(int id)
		{
			string sql = "SELECT * FROM books WHERE bookid=@bookid";
			var parameters = new sqlparameterbuilder()
				.ADDint("bookid", id)
			.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				// this.Close();
				return;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			BooksIndexView model = TobooksIndexVM(data.Rows[0]);

			// 再將 viewModel值繫結到各控制項
			categorycombobox.SelectedItem = ((List<BookCategoryIndexView>)categorycombobox.DataSource)
												.Where(x => x.CategoryID == model.CategoryID).FirstOrDefault();

			booknametxtbox.Text = model.BookName;
			authortxtbox.Text = model.Author;
			isbntxtbox.Text = model.ISBN;
			pbytxtbox.Text = model.PublishYear.ToString();

		}

		private BooksIndexView TobooksIndexVM(DataRow row)
		{
			return new BooksIndexView
			{
				BookID = row.Field<int>("BookID"),
				Author = row.Field<string>("Author"),
				CategoryID = row.Field<int>("CategoryID"),
				//CategoryName = row.Field<string>("CategoryName"),
				BookName = row.Field<string>("BookName"),
				ISBN = row.Field<string>("ISBN"),
				PublishYear = row.Field<int>("PublishYear"),
				//BookID = row.Field<int>("BookID")
			};
		}

		private void InitForm()
		{
			// 設定 categoryIdComboBox property
			categorycombobox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM bookcategory ORDER BY categoryid";
			var dbHelper = new SqlDBhelper("default");

			List<BookCategoryIndexView> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => TOBookClassIndex(row))
				//.Prepend(new BookCategoryIndexView { ca = 0, CategoryName = String.Empty })
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

		private void updateButton_Click(object sender, EventArgs e)
		{
			int categoryId = ((BookCategoryIndexView)categorycombobox.SelectedItem).CategoryID;
			string bookName = booknametxtbox.Text;
			string author = authortxtbox.Text;
			string isbn = isbntxtbox.Text;
			int pYear = pbytxtbox.Text.Toint(-1);


			// 將它們繫結到ViewModel
			BooksIndexView model = new BooksIndexView
			{
				CategoryID = categoryId,
				BookName = bookName,
				Author = author,
				ISBN = isbn,
				PublishYear = pYear,

			};

			// 針對ViewModel進行欄位驗證
			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.BookName)) errorMsg += "書名必填\r\n";
			if (string.IsNullOrEmpty(model.Author)) errorMsg += "作者必填\r\n";
			if (string.IsNullOrEmpty(model.ISBN)) errorMsg += "ISBN\r\n";
			if (model.PublishYear < 0) errorMsg += "請正確輸入西元年分,如:1911\r\n";

			if (string.IsNullOrEmpty(errorMsg) == false)
			{
				//表示至少一欄有錯誤
				MessageBox.Show(errorMsg);
				return; // 不再向下執行
			}


			//如果通過驗證,就新增記錄
			string sql = @"update BOOKS
set
CategoryId=@CategoryId,BookName=@BookName,Author= @Author,ISBN=@ISBN,PublishYear=@PublishYear where categoryid=@categoryid";

			var parameters = new sqlparameterbuilder()
				.ADDint("CategoryId", model.CategoryID)
				.ADDNvarchar("BookName", 50, model.BookName)
				.ADDNvarchar("Author", 50, model.Author)
				.ADDNvarchar("ISBN", 50, model.ISBN)
				.ADDint("PublishYear", model.PublishYear)
				.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void deletebtn_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			string sql = @"DELETE FROM books WHERE bookid=@bookid";

			var parameters = new sqlparameterbuilder()
				.ADDint("bookid", this.id)
				.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void EditBooksForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void booknametxtbox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
