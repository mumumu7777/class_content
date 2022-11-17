using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1117LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Demo01();

			//Demo02();
			//Demo03();
			//Demo04();
			//Demo05();
			Demo06();
		}

		/// <summary>
		/// 聚合函數 sum,count,average,max,min,where,Take(抓幾筆)
		/// </summary>
		private static void Demo01() //items大於50第一筆 all
		{
			int[] items = new int[] { 1, 2, 3, 55, 77, 66, 999, 8888, 777777, 4444555};
			//items大於50第一筆
			int firstvalue = items.First(x=> x>6666);

			//沒有傳回預設0
			int firstvalue2 = items.FirstOrDefault(x => x > 5000);

			Console.WriteLine(firstvalue);

		}

		private static void Demo02()
		{

			int[] items = new int[] { 1, 2, 3, 55, 77, 66, 999, 8888, 777777, 4444555 };
			bool result = items.All(x => x == 0);
			Console.WriteLine( result);
		}

		private static void Demo03()//確認是否有一筆少於0 any
		{
			int[] items = new int[] { 1, 2, 3, 55, 77, 66, 999, -8888, 777777, 4444555 };
			bool result = items.Any(a => a < 0);
			Console.WriteLine(result);
		}

		private static void Demo04()
		{
			int[] items = new int[] { 1, 2, 3, 55, 77, 66, 999, -8888, 777777, 4444555 };

			

			Console.WriteLine(items.Where(x=> x >10).Sum());
			Console.WriteLine(items.Count());
			Console.WriteLine(items.Count(x=>x>10));


			Console.WriteLine( items.Take(3).Average());
			Console.WriteLine(items.Take(3).Average().ToString("f"));//顯示小數點兩位
			Console.WriteLine(items.Take(8).Average().ToString("f4"));

			Console.WriteLine(items.Max());

			


			
		}

		private static void Demo05()//把陣列串成字串 聚合
		{
			string[] items = new string[] { "A", "B", "C" };
			string RESULT = items.Aggregate((accumulation, next) => accumulation + "," + next);
			Console.WriteLine(RESULT);
		}

		private static void Demo05b()//轉字串 select--map 對照轉型
		{
			int[] items = new int[] { 8,7,7,6 };
			string RESULT = items.Select(x=>x.ToString()).Aggregate((accumulation, next) => accumulation + "," + next);
			Console.WriteLine(RESULT);
		}

		private static void Demo06()
		{
			//取分頁紀錄,假設一頁有三筆,取第二頁(4~6筆)
			int[] items = new int[] { 1, 2, 3, 55, 77, 66, 999, -8888, 777777, 4444555 };
			var SECONPAGE = items.Skip(3).Take(3);
			foreach (var item in SECONPAGE)
			{
				Console.WriteLine(item);
			}

		

		}

	}
}
