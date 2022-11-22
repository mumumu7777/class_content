using LibararySystemDemo.infraa;
using LibararySystemDemo.model.dataindex;
using LibararySystemDemo.model.Services;
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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}


		private void Loginbtn_Click_1(object sender, EventArgs e)
		{
			//將表單聯繫loginvm
			LoginVM model = new LoginVM
			{
				Account = Accounttxtbox.Text,
				Password = Passwordtxtbox.Text
			};


			//驗證欄位是否正確
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
		{
			{ "account",Accounttxtbox},
			{ "password",Passwordtxtbox},

		};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			//驗證帳密是否正確
			bool result = new UserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}
			//若正確,開啟mainform
			Accounttxtbox.Text = String.Empty;
			passwordbtn.Text = String.Empty;

			var frm = new MainForm();
			frm.Owner = this;

			frm.Show();
			this.Hide();
			//
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Close_Frm();
			var createaccount = new CreateUserForm();

			DialogResult result = createaccount.ShowDialog();
			
		}
		public void Close_Frm()
		{
			if (ActiveMdiChild != null) ActiveMdiChild.Close();
		}
	}
}
