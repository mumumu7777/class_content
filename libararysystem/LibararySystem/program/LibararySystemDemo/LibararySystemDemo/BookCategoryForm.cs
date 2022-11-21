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

namespace LibararySystemDemo
{
	public partial class BookCategoryForm : Form
	{

		DataTable bookcategory;
		public BookCategoryForm()
		{
			InitializeComponent();

			DisplayBookCategory();
		}


		private void DisplayBookCategory()
		{
			string sql = @"SELECT * from bookcategory order by CategoryID ";
			
			bookcategory = new SqlDBhelper("default").Select(sql, null);

			BindData(bookcategory);
		}
		private void BindData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}

		private void Addbtn_Click(object sender, EventArgs e)
		{
			var frm = new CreateBooksCategoryform();
			// frm.Show();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayBookCategory();
			}

		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			DataRow row = this.bookcategory.Rows[rowIndx]; // 使用者點到的那一筆記錄
			int categoryid = row.Field<int>("categoryid"); // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditBookCategory(categoryid);
			// frm.Show();
			// DialogResult result = frm.ShowDialog();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayBookCategory();
			}

		}
	}
}
