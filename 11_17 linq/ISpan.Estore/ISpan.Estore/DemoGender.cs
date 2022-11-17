using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISpan.Estore
{
	public partial class DemoGender : Form
	{
		public DemoGender()
		{
			InitializeComponent();
		}

		private void getvaluebtn_Click(object sender, EventArgs e)
		{

			int gender = this.usGender1.GetValue();
			MessageBox.Show(gender.ToString());
			
		}

		private void DemoGender_Load(object sender, EventArgs e)
		{

		}

		private void usGender1_Load(object sender, EventArgs e)
		{
		}

		private void setbtn_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textBox1.Text, out int number);
			int value = isInt ? number : -1;

			this.usGender1.SetValue(value);
		}
	}
}
