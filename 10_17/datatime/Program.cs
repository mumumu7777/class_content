using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatime
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			DateTime today = DateTime.Today;

			Console.WriteLine(today);
			Console.WriteLine(now);

			//指定某日

			DateTime dt = new DateTime(2000, 3, 14);
			dt = new DateTime(1999, 3, 14);
				//Console.WriteLine(dt);

			dt = new DateTime(1999, 3, 14, 15, 20, 20);

				//Console.WriteLine(dt);

			string dttime = "2000/3/14 12:30:15";

			dt = Convert.ToDateTime(dttime);

			dttime = "2000/3/15 12:25:16";

			dt = Convert.ToDateTime(dttime);

			dttime = "2022/10/14 13:10:10";
			dt = Convert.ToDateTime(dttime);


			Console.WriteLine(dttime);

			




		}
	}
}
