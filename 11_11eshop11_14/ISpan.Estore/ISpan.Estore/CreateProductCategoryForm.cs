using ISpan.Estore.Infra.Extensions;
using ISpan.Utility;
using System;
using System.Windows.Forms;

namespace ISpan.Estore
{
	public partial class CreateNewProductCategory : Form
	{
		public CreateNewProductCategory()
		{
			InitializeComponent();
		}

		private void savebtn_Click(object sender, EventArgs e)
		{
			string categoryname = category.Text;
			// toint 轉失敗傳回預設-1
			int displayOrder = displaytext.Text.Toint(-1);

			string sql = @"insert into Productcategories(categoryname,displayorder)
                         values(@categoryname,@displayorder)";
			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("categoryname", 50, categoryname)
				.ADDint("displayorder", displayOrder)
				.build();
			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);
			MessageBox.Show("紀錄已新增");
		}
	}
}
