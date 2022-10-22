using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	namespace 格式dt
	{
	internal class Program
	{
	static void Main(string[] args)
	{

			//格式化

			DateTime dt = new DateTime(2000, 3, 15, 10, 05, 1);

			//不常用 預設格式
			string value = dt.ToString();
			Console.WriteLine(value);


			//只有日期 m = 分鐘  MM 有0
			value = dt.ToString("yyyy,M,d");
			Console.WriteLine(value);

			value = dt.ToString("您的生日是 西元 yyyy年MM月dd日");
			Console.WriteLine(value);

			value = dt.ToString("yyyy/MM/dd HH:mm:ss");
			Console.WriteLine(value);

			value = dt.ToString("yyyy/MM/dd \r\nHH:mm:ss");
			Console.WriteLine(value);


		}
	}
	}
