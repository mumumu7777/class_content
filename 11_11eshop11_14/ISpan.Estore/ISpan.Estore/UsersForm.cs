using ISpan.Estore.Models.Services;
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
	public partial class UsersForm : Form
	{
		private UserIndexVM[]users=null;
		public void DisplayUsers()
		{
			users = new UserService().GetAll().ToArray();
			BindData(users);
		}

		public UsersForm()
		{

			InitializeComponent();
			DisplayUsers();
		}
		private void BindData(UserIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void addbtn_Click(object sender, EventArgs e)
		{
			var frm = new CreatUsersForm();
			// frm.Show();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayUsers();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			UserIndexVM row =this.users[rowIndx]; // 使用者點到的那一筆記錄
			int id = row.ID; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditUsersForm(id);
			// frm.Show();
			// DialogResult result = frm.ShowDialog();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayUsers();
			}
		}
	}
}
