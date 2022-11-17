using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Estore
{
	public partial class DemoCheckBox : Form
	{
		public DemoCheckBox()
		{
			InitializeComponent();
		}

		private void getvaluebtn_Click(object sender, EventArgs e)
		{
			bool isChecked = checkBox1.Checked;
			int value = (isChecked == true) ? 1 : 0;
			MessageBox.Show(value.ToString());
		}

		private void setvaluebtn_Click(object sender, EventArgs e)
		{
			string valueIndb = textBox1.Text;   //模擬db的欄位是1或0
			checkBox1.Checked = (valueIndb == "1");
		}
	}
}
