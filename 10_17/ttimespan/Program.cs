using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttimespan
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var dtstart = new DateTime(2022, 10, 17);
			var dtend = new DateTime(2022, 10, 22, 12, 30, 0);
			TimeSpan timeSpan = dtend - dtstart;//5天
			int days = timeSpan.Days;//日期相減而已
			double todaydays = timeSpan.TotalDays;//總天數  //double 小數點

			Console.WriteLine(todaydays);//可能有小數點
			Console.WriteLine(days);

			int hours = timeSpan.Hours;//單純小時值相減
			double hours2 = timeSpan.TotalHours;//5 天的小時

			Console.WriteLine(hours);
			Console.WriteLine(hours2); 


		}
	}
}
