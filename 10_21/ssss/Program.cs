using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssss
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string value = "abcc";
			Console.WriteLine("請輸入您要的長度");
			int length = Convert.ToInt32(Console.ReadLine());
			try
			{
				string result = Left(value,length);//發生exception
				Console.WriteLine(result);
				string result2 = Left(value,length);
				Console.WriteLine(result2);
			}
			catch(Exception ex)
			{
				Console.WriteLine("抱歉程式發生錯誤,原因是:"+ex.Message);
				Console.WriteLine("抱歉程式發生錯誤, 原因是:" + ex.Message);
			}
			

		}


		static string Left(string value, int length)
		{

			if (length <= 0) throw new Exception("長度必須大於0");
			return value.Substring(0, length);

			if (length > 5) throw new Exception("長度必須在五之內");
			string result = value.Substring(0,length);

		}
		
	}
}
