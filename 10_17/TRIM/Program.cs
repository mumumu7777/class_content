using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIM
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//TRIM 山佐又空白

			string value1 = "    abc    ";
			string value2 = value1.Trim();
			string value3 = value2.TrimStart();
			// trimend 

			string email = "kevvin35777@gmail.com";
			int indexofat = email.IndexOf("@");

			if (indexofat < 0)

			{ Console.WriteLine("請輸入@"); }

			else
			{ Console.WriteLine("格式對了"); }


			string url = "http//www.chiken.tw";
			bool isurl = url.StartsWith("http");

			if (isurl)

			{ Console.WriteLine("正確"); }

			else
			{ Console.WriteLine("必須以http開頭"); }



			
		}
	}
}
