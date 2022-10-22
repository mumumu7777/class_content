using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filee
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string content = "Hello world";
			string fullname = @"d:\files\docs\readme.txt";
			fileutility.creatfile(content, fullname,true);
			fileutility.creatfile(content, fullname);

		}


		class fileutility

		{ public static void creatfile(string content, string fullname, bool overrideifexit = true)
			{ }
				
				
				}
	}
}
