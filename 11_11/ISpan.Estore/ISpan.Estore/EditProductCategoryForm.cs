using ISpan.Estore.Infra.Extensions;
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
	public partial class EditProductCategoryForm : Form
	{

		private int id;
		public EditProductCategoryForm(int id )
		{
			InitializeComponent();
			this.id = id;
			Binddata(id);	
		}

		private void Binddata(int id)
		{

			string sql = "select * from ProductCategories where Id=@Id";
		    var parameters = new sqlparameterbuilder().ADDint("Id",id).build();
			DataTable data = new SqlDBhelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉不知道發生什麼事");
				this.DialogResult = DialogResult.OK;
				//this.Close();
				//return;		
			}
			else
			{
				DataRow row = data.Rows[0];

				category.Text = row.Field<string>("CategoryName");
				displaytext.Text = row.Field<int>("DisplayOrder").ToString();
			}
		}

		private void updatebtn_Click(object sender, EventArgs e)
		{
			string categoryname = category.Text;
			// toint 轉失敗傳回預設-1
			int displayOrder = displaytext.Text.Toint(-1);

			string sql = @"update Productcategories set categoryname = @categoryname,displayorder=@displayorder where id=@id";
                        
			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("categoryname", 50, categoryname)
				.ADDint("displayorder", displayOrder).ADDint("id", this.id)
				.build();
			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);
			MessageBox.Show("紀錄已新增");

			this.DialogResult = DialogResult.OK;
		}

		private void deletebtn_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show
			("確定要刪除嗎?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{ return; }
			string sql = @"delete from productcategories where id=@id";
			var parameters = new sqlparameterbuilder().ADDint("id",this.id).build();
			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);
			this.DialogResult = DialogResult.OK;

		}
	}
}
