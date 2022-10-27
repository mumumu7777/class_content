using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hard
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonlogin_Click(object sender, EventArgs e)
		{
			string name = namebox.Text;


			//new form1 帳號傳過去
			var frm = new hiform(name);
			frm.Show();
		}

		
		
			
	}
}
