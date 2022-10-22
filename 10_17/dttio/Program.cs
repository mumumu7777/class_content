using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dttio
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//日期變換  3/28 - month = 2/28  加一月超過的會變最後一天


		DateTime today = DateTime.Today;

			//tomorow

			var tomorow = today.AddDays(1);

			// yesterday

			var yesterday = today.AddDays(-1);

			// next month 

			var nextmonth =	today.AddMonths(+1);

			var dt = new DateTime(2022, 03, 14 );

			var nexmdt = dt.AddMonths(1);
			Console.WriteLine(yesterday);
		}
		
	}
}
