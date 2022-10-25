using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_cotent
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new Form2();
			frm.MdiParent = this;
			frm.Show();
		}

		private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new Form3();
			frm.MdiParent = this;
			frm.Show();
		}
	}
}
