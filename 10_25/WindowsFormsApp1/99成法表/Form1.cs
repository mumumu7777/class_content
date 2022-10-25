using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _99成法表
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//取被選取數值
			int firstnumber = Getnumber();

			//生成單一乘法表
			string table = Rendersingletable(firstnumber);

			//結果

			textBox1.Text = table;
		}

		private int Getnumber()
		=> Convert.ToInt32(comboBox1.SelectedItem);
		// =>(goes to)
		// return Convert.ToInt32(comboBox1.SelectedItem);


		//private int ninenie()
		private string Rendersingletable(int firstnumber)
		{ string result = string.Empty;
			for (int i = 0; i < 10; i++)
			{
				result += $"{firstnumber}*{i}={firstnumber * i}\r\n";
			}
		return result;
		}


	}
}

