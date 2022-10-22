using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入一個值:");
			int current = Convert.ToInt32(Console.ReadLine());

			//do    do while 至少會跑一次
			//{
			//	Console.WriteLine(current);
			//	current++;

			//}while(current<= 20);


			while (current <= 10)
			{
				Console.WriteLine(current);
				current++;
			}


		}
	}
}
