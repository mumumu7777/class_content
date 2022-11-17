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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.IsMdiContainer = true;

		}
		private void 維護商品ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new ProductsForm();
			form.MdiParent = this;
			form.Show();
		}

		private void 維護商品類別ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new ProductCategoriesForm();
			form.Show();
			form.MdiParent = this;
		}

		private void 維護使用者ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new UsersForm();
			form.Show();
			form.MdiParent = this;
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show
			("您確定要登出嗎?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{ return; }
			this.Close();
		}

		private void MainForm_formClosing(object sender, EventArgs e)
		{
			this.Owner.Show();
		}
	}
}
