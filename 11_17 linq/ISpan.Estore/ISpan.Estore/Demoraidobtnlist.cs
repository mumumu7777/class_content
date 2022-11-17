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
	public partial class Demoraidobtnlist : Form
	{
		public Demoraidobtnlist()
		{
			InitializeComponent();
		}

		private void GETVALU_Click(object sender, EventArgs e)
		{

			RadioButton[] controls = new RadioButton[] { gender0, Gender1 };
			int value = -1;
			foreach(RadioButton item in controls)
			{
				if (item.Checked == true)
				{
					value=Convert.ToInt32(item.Tag);
					break;
				}
			}
			MessageBox.Show(value.ToString());


		}

		private void SETVALUE_Click(object sender, EventArgs e)
		{
			bool isint = int.TryParse(textBox1.Text, out int number);
			int value = (isint == true) ? number : -1;
			RadioButton[] controls = new RadioButton[] { gender0, Gender1};
			foreach (RadioButton item in controls)
			{
				int controtag = Convert.ToInt32(item.Tag);
				if (controtag == value)
				{
					item.Checked=true;
					break;
				}


			}
			
		}
	}
}
