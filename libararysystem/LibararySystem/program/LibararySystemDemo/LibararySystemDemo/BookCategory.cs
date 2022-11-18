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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibararySystemDemo
{
	public partial class BookCategory : Form
	{
		private BookCategoryIndexView[] bookCategories = null; 
		 
		public BookCategory()
		{

			InitializeComponent();
			InitForm();
			DisplayBookCategory();


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
			string sql = @"SELECT * FROM BookCategory1 join BookClass on classid = classcategoryid"; 

			//取得篩選值
			SqlParameter[] parameters = new SqlParameter[] { };
			//表單選的直
			int categoryId = ((	BookClassIndexView)bookclasscombobox.SelectedItem).ClassID;

			if (categoryId > 0)
			{
				sql += " WHERE classcategoryid=@classcategoryid";
				parameters = new sqlparameterbuilder()
					.ADDint("classcategoryid", categoryId)
					.build();
			}

	
			//sql += " ORDER BY BookID ,class";
			var dbHelper = new SqlDBhelper("default");

			bookCategories = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseTobookcategoryIndexVM(row))
				.ToArray();

			BindData(bookCategories);
		}

		private void BindData(BookCategoryIndexView[] data)
		{
			dataGridView1.DataSource = data;
		}

		private BookClassIndexView TOBookClassIndex(DataRow row)
		{
			return new BookClassIndexView
			{
				 ClassID = row.Field<int>("ClassID"),
				  Class = row.Field<string>("Class"),
			};
		}

		private void InitForm()
		{
			 
			bookclasscombobox.DropDownStyle = ComboBoxStyle.DropDownList;

		    var sql = "SELECT * FROM BookClass order by class";
			var dbHelper = new SqlDBhelper("default");

			List<BookClassIndexView> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => TOBookClassIndex(row))
				.Prepend(new BookClassIndexView { ClassID = 0, Class= String.Empty })
				.ToList();

			this.bookclasscombobox.DataSource = categories;

		}

		private BookCategoryIndexView ParseTobookcategoryIndexVM(DataRow row)
		{
			return new BookCategoryIndexView
			{
				
				 Author = row.Field<string>("Author"),
				 Class = row.Field<string>("Class"),
				 BookName = row.Field<string>("BookName"),
				  ISBN = row.Field<string>("ISBN"),
				  PublishYear = row.Field<int>("PublishYear"),	
				  BookID = row.Field<int>("BookID")
			};
		}

		private void BookCategory_Load(object sender, EventArgs e)
		{

		}

		//private void textget
	}
}
