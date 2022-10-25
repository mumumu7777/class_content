using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 四則運算
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void caculatebuttom_Click(object sender, EventArgs e)
		{
			int firstnumber, secondnumber;
			//取第一個數值
			try
			{ firstnumber = Getfirstnumber(); }


			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
				return;
			}
			//取第二個數值
			try { secondnumber = (Getsecondnumber()); }

			catch (Exception ex) { MessageBox.Show(ex.Message); return; }

			//取得計算方式
			string operation;
			try { operation = Getoperation(); }

			catch (Exception ex){ MessageBox.Show(ex.Message);return; }

			//計算答案
			int result;
			try { result = Clac(firstnumber, secondnumber, operation);
				Resultlabel.Text = result.ToString(); 
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); return; }
			
		}

		private int Clac(int firstnumber, int secondnumber, string operation)
		{
			switch (operation)
			{

				case "+":
					return firstnumber + secondnumber;
				case "-":
					return firstnumber - secondnumber;
				case "*":
					return firstnumber * secondnumber;
				case "/":
					return firstnumber / secondnumber;				
			}
			throw new Exception("uuuu");
		}
		private int Getfirstnumber()
		{

			TextBox txt = NUMBER1;
			string title = "第二個數字";
			return Getint(txt, title);
		}
		private int Getsecondnumber()
		{
			TextBox txt = NUMBER2;
			string title = "第二個數字";
			return Getint(txt, title);
		}
		private int Getint(TextBox control, string title)
		{
			string value = control.Text;
			bool isint = int.TryParse(value, out int number);
			return isint ? number : throw new Exception($"{title}必須填寫數值");
		}
		private string Getoperation()
		{
			ComboBox control = this.OPTIONS;
			object selecteditem = control.SelectedItem;//沒選,是null
			return selecteditem != null ? selecteditem.ToString() : throw new Exception("請選擇計算方式");
		}

	
	}
		}




