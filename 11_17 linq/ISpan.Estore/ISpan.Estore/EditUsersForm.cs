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
	public partial class EditUsersForm : Form
	{
		private int id;
		public EditUsersForm(int id )
		{
			InitializeComponent();
			this.id = id;
			BindData(id);

		}

		private void updatebtn_Click(object sender, EventArgs e)
		{
			string Name = NameTEXTbox.Text;
			string PassWord = PassWordTextbox.Text;
			string Account = Accounttextbox.Text;
			

			string sql = @"UPDATE users
SET name=@name, PassWord=@PassWord,Account=@Account
WHERE Id=@Id";

			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("PassWord", 50, PassWord)
				.ADDNvarchar("Name", 50,Name)
				.ADDNvarchar("Account", 50,Account)
				.ADDint("ID",id)
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

			string sql = @"DELETE FROM users WHERE Id=@Id";

			var parameters = new sqlparameterbuilder()
				.ADDint("Id", this.id)
				.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;


		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM USERS WHERE Id=@Id";
			var parameters = new sqlparameterbuilder()
			.ADDint("Id", id)
			 .build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				this.Close();
				return;
			}

			// 將欄位值放入控制項裡

			uservm MODEL = TOuservm(data.Rows[0]);
			Accounttextbox.Text = MODEL.Account;
			PassWordTextbox.Text = MODEL.PassWord;
			NameTEXTbox.Text = MODEL.Name;
		}
		private static uservm TOuservm(DataRow row)
		{
			return new uservm
			{
				 PassWord= row.Field<string>("PassWord"),
				Name = row.Field<string>("Name"),
				Account = row.Field<string>("Account")
			};
		}



	}

		

	
}
