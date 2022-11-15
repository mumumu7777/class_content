using ISpan.Estore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Estore.Infra.Extensions
{
	public class ValidationHelper
	{
		public static bool Validate<T>(T model, Dictionary<string, Control> map ,ErrorProvider errorProvider)
		{//得知要驗證規則
			ValidationContext context = new ValidationContext(model, null, null);
			//用來存放錯誤的集合
			List<ValidationResult> errors = new List<ValidationResult>();
			//驗證model
			errorProvider.Clear();
			bool validateAllProperties = true;//是否驗證所有規則,而分只驗證REQUIRE 規則
			bool ISValid = Validator.TryValidateObject(model, context, errors, validateAllProperties);
			if (!ISValid)
			{
				DisplayErrorsByErrorProvider(errors,map,errorProvider);
			}
			return ISValid;


		}
		private static void DisplayErrorsByErrorProvider(List<ValidationResult> errors, Dictionary<string, Control> map, ErrorProvider errorProvider)
		{
			//this.errorProvider1.Clear();
			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					errorProvider.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

	}
}
