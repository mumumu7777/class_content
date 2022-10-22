using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 星期幾
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var dt = new DateTime(2022 / 10 / 16);//星期六
			DayOfWeek weekday = dt.DayOfWeek; // 算星期幾
			int value = (int)weekday; // 小瓜 讓weekday轉乘int

			Console.WriteLine(weekday);
			Console.WriteLine(value); // 星期天0 其餘1-6

			//enum 

			bool isLeapyear = DateTime.IsLeapYear(2015);// isleapyear 判斷是不適閏年

			int year = dt.Year;//dt年分

			isLeapyear = DateTime.IsLeapYear((year));

			int month = dt.Month;
			int day = dt.Day;

			Console.WriteLine(isLeapyear);

			int days = DateTime.DaysInMonth(2022,2);
			days = DateTime.DaysInMonth(dt.Year, dt.Month);

			DateTime dt2 = new DateTime(2022, 03, 14,12,30,11);
			DateTime dt3 = dt2.Date;

			Console.WriteLine(dt2);



			

		}

		//	//enum 星期
		//	{sunday = 0 
		//			monday = 1
		//			tuesday = 2


		//	}
		//}
	}
}
