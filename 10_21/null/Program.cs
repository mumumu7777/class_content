
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @null
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int deciamal double bool datetime 不能是null

			int n1 = 1;

			int? n2 = null;// int? 等於nullable<int>的簡寫,可以是null
			n2 = 10;

			Nullable<int> n3 = null;//沒人寫


			var member = new member();
			Console.WriteLine(member.height);
			

			Console.WriteLine(member.gender);
			Console.WriteLine(member.dayofbirth.HasValue);

			member.gender = false;
			Console.WriteLine(member.gender.HasValue);

			int height = member.height.HasValue ? member.height.Value :-1 ;
			Console.WriteLine(height);
		}

		class member
		{
			public bool? gender;

			public DateTime?dayofbirth;

			public int?height;
		
		
		
		
		}


	}
}
