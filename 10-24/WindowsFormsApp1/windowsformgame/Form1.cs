using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsformgame
{
	public partial class gamegame : Form
	{

		private int answer = 0;

		public gamegame()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//在表單一開始就先取亂數1~3,存放在變數中,並在label呈現答案
			answer = new Random().Next(1,4); //傳回1~3的亂數
			label1.Text = answer.ToString();
			label1.Visible = false;


		}

		private void button1_Click(object sender, EventArgs e)
		{
			//sender is bottom 轉成buttom之後取得tag直
			Button btm = (Button)sender;
			int tag = Convert.ToInt32(btm.Tag);
			MessageBox.Show(tag.ToString());


			//對答案

			if (tag == answer)
			{

				MessageBox.Show("答對瞜!");

			}

			else MessageBox.Show("答錯了拉");

		}

		
	}
}
