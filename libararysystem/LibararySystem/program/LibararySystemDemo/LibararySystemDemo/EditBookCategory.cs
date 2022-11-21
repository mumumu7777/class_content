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
	public partial class EditBookCategory : Form
	{
		private int categoryid;
		public EditBookCategory(int id)
		{
			InitializeComponent();
			this.categoryid = id;
			BindData(id);
		}



		private void BindData(int id)
		{
			string sql = "SELECT * FROM BookCategory WHERE categoryid=@categoryid";
			var parameters = new sqlparameterbuilder()
			.ADDint("categoryid", id)
			.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				this.Close();
				return;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			DataRow row = data.Rows[0];
			categoryNameTextBox.Text = row.Field<string>("categoryname");

		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string categoryName = categoryNameTextBox.Text;		

			string sql = @"UPDATE BookCategory
SET CategoryName=@CategoryName
WHERE categoryid=@categoryid";

			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("CategoryName", 50, categoryName)			
				.ADDint("categoryid", this.categoryid)
				.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			string sql = @"DELETE FROM BookCategory WHERE categoryid=@categoryid";

			var parameters = new sqlparameterbuilder()
				.ADDint("categoryid", this.categoryid)
				.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;

		}
	}


}
