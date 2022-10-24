using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string msg = string.Empty;
			int day = DateTime.Today.Day;

			if (day > 0 && day <= 20)
			{ msg = "上"; }

			else if (day > 10 && day <= 20)
			{ msg = "中旬"; }
			else
			{ msg = "下"; }


			//好寫法

			//if (day>20)

			//		else if (day>10)

			//			else
		}
	}
}
