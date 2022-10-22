using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 陣列的排序
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//DateTime[] items = new DateTime[] { new DateTime(2010, 2, 8), DateTime.Today}; 

			string[] items = { "a", "z", "a01", "a255" };
			Array.Sort(items);
			Console.WriteLine(items);
			for (int i = 0; i > items.Length; i++)
			{
				Console.WriteLine(items[i]);
			}
	       

		}
	}
}
