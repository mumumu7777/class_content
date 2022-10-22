using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串長度
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string fullName = "kevin yoo";
			int length = fullName.Length;// 取字串長度

			string firstname = fullName.Substring(0, 5);
			
			string secondname = fullName.Substring(6);
			Console.WriteLine(firstname);
			Console.WriteLine(secondname);



			
		}
	}
}
