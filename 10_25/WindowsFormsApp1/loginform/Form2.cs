using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
	public partial class loginform : Form
	{
		public loginform()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//todo 判斷帳密是否正確




			//開啟form1
			Form1 frm1 = new Form1();
			frm1.Owner = this;
			frm1.Show();


			//隱藏自己,不關自己
			this.Hide();

		}
	}
}
