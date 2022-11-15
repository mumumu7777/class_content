using ISpan.Estore.Infra.Extensions;
using ISpan.Estore.Models.Services;
using ISpan.Estore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Estore
{
	public partial class CreatUsersForm : Form
	{
		public CreatUsersForm()
		{
			InitializeComponent();
		}

		private void Savebtn_Click(object sender, EventArgs e)
		{

			// 取得表單的各欄位值

			string account = Accounttxtbox.Text;
			string Name = Nametxtbox.Text; //如果没填牌價,傳回-1
			string password = Passwordtxtbox.Text;

			//// 將它們繫結到ViewModel
			uservm model = new uservm
			{

				Account = account,
				PassWord = password,
				Name = Name

			};

			//	// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
		{
			{ "account",Accounttxtbox},
			{ "password",Passwordtxtbox},
			{ "name",Nametxtbox},
		};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;
			// 如果通過驗證,就新增記錄
			try
			{
				new UserService().Create(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("註冊失敗, 因為:" + ex.Message);
			}

		}

		//private bool Validate(uservm model)
		//{//得知要驗證規則
		//	ValidationContext context = new ValidationContext(model, null, null);
		//	//用來存放錯誤的集合
		//	List<ValidationResult> errors = new List<ValidationResult>();
		//	//驗證model
		//	this.errorProvider1.Clear();
		//	bool validateAllProperties = true;//是否驗證所有規則,而分只驗證REQUIRE 規則
		//	bool ISValid = Validator.TryValidateObject(model, context, errors, validateAllProperties);
		//	if (ISValid)
		//	{
		//		DISPLAY(errors);
		//	}
		//	return ISValid;


		//}
		//private void DisplayErrorsByErrorProvider(List<ValidationResult> errors)
		//{
		//	Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
		//{
		//	{ "account",Accounttxtbox},
		//	{ "password",Passwordtxtbox},
		//	{ "name",Nametxtbox},
		//};
		//	this.errorProvider1.Clear();
		//	foreach (ValidationResult error in errors)
		//	{
		//		string propName = error.MemberNames.FirstOrDefault();
		//		if (map.TryGetValue(propName, out Control ctrl))
		//		{
		//			this.errorProvider1.SetError(ctrl, error.ErrorMessage);
		//		}

		//	}
		//}

	}   
}
