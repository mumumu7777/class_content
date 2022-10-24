using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test04
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("輸日入年分:");
			string input = Console.ReadLine();

			int year = Convert.ToInt32(input);

			//找到該年第一天

			DateTime firstday = new DateTime(year, 1, 1);

			//找出該年第一星期日
			DateTime firstsunday = firstday;
			int weekday = (int)firstday.DayOfWeek;
			if(weekday > 0)
			{ firstday = firstday.AddDays(7); }

			//cw($"第一個weekday is {firstSunday:yyyy/MM/dd}")

			DateTime endday = new DateTime(year, 12, 31);
			for (DateTime i = firstday; i <= endday; i = i.AddDays(7))
			{ Console.WriteLine(i.ToString("yyyy/MM/dd"));
			} 

		}
	}
}
