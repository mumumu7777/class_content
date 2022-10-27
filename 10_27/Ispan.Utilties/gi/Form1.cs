using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gi
{
	public partial class Form1:Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender; //顯示轉型,sender不適buttom會錯

			Button btn2 = sender as Button;// 無法轉型btn2=null 部會抱錯

			bool isbuttom = sender is Button;//如果sender是buttom回傳true

			
		}
	}
}
