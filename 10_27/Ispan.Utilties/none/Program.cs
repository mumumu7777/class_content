using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispan.Utilties;

namespace none
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var obj2 = new Mymath();
			obj2.Gettotal(111, 0.8);
			var obj = new Mymath();
			int price = 1890;
			Double discount = 0.05;
			int total = obj.Gettotal(price, discount);
			Console.WriteLine(total);
		}
	}
}