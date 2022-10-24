using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laBel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text = String.Empty;
		}

		private void 身高_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//得到輸入姓名
			string name = textBox1.Text;

			//組合問候

			string message = $"你好,{name}";
			//丟給LABEL

			label1.Text = message;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
