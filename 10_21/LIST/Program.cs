using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST
{
	internal class Program
	{
		static void Main(string[] args)
		{
			

			List<int> ITEMS = new List<int>();

			ITEMS.Add(1);//[5]
			ITEMS.Add(2);//[5,10]
			ITEMS.Clear();// 清空
			ITEMS.Add(6);//[6]
			ITEMS.Add(12);//[6,12]
			ITEMS.Insert(0,99);//[99,6,12]
			ITEMS.Remove(6);//[99,12]

			foreach (var item in ITEMS)
			{ Console.WriteLine(item); }

			Console.WriteLine(ITEMS.Count);//集合的筆數
			
			

		}
	}
}
