using LibararySystemDemo.infraa.DAOs;
using LibararySystemDemo.model.dataindex;
using LibararySystemDemo.model.DTOS;
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
	public partial class UsersForm : Form
	{
		private UserIndexVM[] users = null;
		public UsersForm()
		{
			InitializeComponent();
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateUserForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayUsers();
			}
		}
		private void DisplayUsers()
		{
			//string sql = @"SELECT * FROM Users ORDER BY ID DESC";

			//var dbHelper = new SqlDbHelper("default");
			//// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			//users = dbHelper.Select(sql, null)
			//	.AsEnumerable()
			//	.Select(row => ParseToIndexVM(row))
			//	.ToArray();

			users = new UserDAO().GetAll()
						.Select(dto => dto.ToIndexVM())
						.ToArray();
			BindData(users);
		}

		private void BindData(UserIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			UserIndexVM row = this.users[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditUserForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayUsers();
			}
		}
	}
}
