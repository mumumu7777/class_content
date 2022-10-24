using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowform2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("您確定要刪除這筆紀錄?,刪除紀錄");
		}
		
		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("無法刪除紀錄,因為會員不存在", "刪除紀錄", MessageBoxButtons.OK,MessageBoxIcon.Error);

			

			//DialogResult result = MessageBox.Show("您確定要刪除這筆訂單紀錄嗎?", "刪除紀錄", MessageBoxButtons.YesNo);

			//if (result == DialogResult.Yes)
			//{
			//	MessageBox.Show("是的");
			//}


			//else
			//{
			//	MessageBox.Show("No");
			//}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
