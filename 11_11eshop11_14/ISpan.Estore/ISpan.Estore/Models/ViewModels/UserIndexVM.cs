using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Estore.Models.ViewModels
{
	public class UserIndexVM
	{

		public int ID { get; set; }
		public string Account { get; set; }

		public string PassWord { get; set; }

		public string Name { get; set; }

	}

	public class uservm

	{
		public int id { get; set; }
		[Required(ErrorMessage = "帳號必填")]
		public int Account { get; set; }
		[Required(ErrorMessage = "密碼必填")]
		public int PassWord { get; set; }

		[Required(ErrorMessage = "姓名必填")]
		public int Name { get; set; }

	}
}
