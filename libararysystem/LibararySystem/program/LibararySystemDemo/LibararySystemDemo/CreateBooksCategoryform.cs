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
	public partial class CreateBooksCategoryform : Form
	{
		public CreateBooksCategoryform()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string categoryname = textBox1.Text;


			string sql = @"INSERT INTO bookcategory
(CategoryName)
VALUES
(@CategoryName)"
			;

			 var parameters = new sqlparameterbuilder()
				.ADDNvarchar("CategoryName", 50, categoryname)				
			    .build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

			// MessageBox.Show("記錄已新增");
			this.DialogResult = DialogResult.OK;


		}

		
	}
}
