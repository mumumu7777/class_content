using ISpan.Utility;
using LibararySystemDemo.model.dataindex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibararySystemDemo
{
	public partial class BookCategory : Form
	{
		private BookCategoryIndexView2[] bookCategories = null; 
		 
		public BookCategory()
		{

			InitializeComponent();
			InitForm();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void addbtn_Click(object sender, EventArgs e)
		{

		}

		private void Searchbtn_Click(object sender, EventArgs e)
		{
			DisplayBookCategory();
			
		}

		private void DisplayBookCategory()
		{
			string sql = @"select * from bookcategory";

			SqlParameter[] parameters = new SqlParameter[] { };








			var dbHelper = new SqlDBhelper("default");
			bookCategories = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseTobookcategoryIndexVM(row))
				.ToArray();
			BindData(bookCategories);
		}

		private void BindData(BookCategory[] data)
		{
			dataGridView1.DataSource = data;
		}

		private BookClassIndexView TOBookCategoryIndex(DataRow row)
		{
			return new BookClassIndexView
			{
				 ID = row.Field<int>("ID"),
				  Class = row.Field<string>("Class"),
			};
		}

		private void InitForm()
		{
			 
			bookclasscombobox.DropDownStyle = ComboBoxStyle.DropDownList;

		    var sql = "SELECT * FROM bookclass ORDER BY id";
			var dbHelper = new SqlDBhelper("default");

			List<BookClassIndexView> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => TOBookCategoryIndex(row))
				.Prepend(new BookClassIndexView { ID = 0,   Class= String.Empty })
				.ToList();

			this.bookclasscombobox.DataSource = categories;

		}

		private BookCategoryIndexView ParseTobookcategoryIndexVM(DataRow row)
		{
			return new BookCategoryIndexView
			{
				 Author = row.Field<string>("Author"),
				 BookClass = row.Field<string>("BookClass"),
				 BookName = row.Field<string>("BookName"),
				  ISBN = row.Field<string>("ISBN"),
				  PublishYear = row.Field<int>("PublishYear"),	
			};
		}




	}
}
