using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibararySystemDemo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
			
		}
		public void Close_Frm()
		{
			if (ActiveMdiChild != null) ActiveMdiChild.Close();
		}
		private void 維護書本ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close_Frm();
			var frm = new BooksForm();
			frm.MdiParent = this;
			frm.Show();
			
		}

		

		private void 維護書本類別ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close_Frm();
			var frm = new BookCategoryForm();
			frm.MdiParent = this;
			frm.Show();
			
		}

		private void 維護使用者ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close_Frm();
			var frm = new UsersForm();
			frm.MdiParent = this;
			frm.Show();
			
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?",
				"登出",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		public void expressSet()
		{ 
			string dtlabel = DateTime.Now.ToString();
		
		}

		

		private void MainForm_Load(object sender, EventArgs e)
		{
		
			
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString();
		}
	}
}
