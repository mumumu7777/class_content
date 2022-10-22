using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四捨五入
{
	internal class Program
	{
		static void Main(string[] args)
		{
	     double	d1= 124.456;
			double d2 = Math.Round(d1);
			Console.WriteLine(d2);

			d1 = 104.5; //靠0近 4捨6入五成雙
			d2 = Math.Round(d1);
			Console.WriteLine(d2);


			d1 = 103.5;
			d2=	Math.Round(d1,MidpointRounding.AwayFromZero);

			d1 = 104.5;
			d2 = Math.Round(d1, MidpointRounding.AwayFromZero);
			Console.WriteLine(d2);

			//無條件捨入.floor

			d1 = 122.5;
				d2= Math.Floor(d1);
			Console.WriteLine(d2);

			//無條件進入ceiling
			d1 = 12.000001;
				d2 = Math.Ceiling(d1);
			Console.WriteLine(d2);
		}
	}
}
