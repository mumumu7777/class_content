using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printstar
{
	public partial class printstar : Form
	{
		public printstar()
		{
			InitializeComponent();
		}
		private void starbox_TextChanged(object sender, EventArgs e)
		{
		}
		private void printbottom_Click(object sender, EventArgs e)
		{
			//取得列數
			int? rows = getrows();
			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入列數");
				return;
			}
			//判斷列數大於0
			if (rows.Value <= 0)
			{
				MessageBox.Show("請輸入整數");
				return;
			}
			//生成星號
			string stars = generatestar(rows.Value);
			//用textbox呈現
			starbox.Text = stars;				
		}
		private string generatestar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}
		private int? getrows()
		{
			string input = printbox.Text;
			bool isint = int.TryParse(input, out int rows);
			if (isint)
			{
				return rows;
			}
			else
			{
				return null;
			}
		}
	}
}


		




	

