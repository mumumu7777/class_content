using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接收使用者0_99
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.Write("請輸入1~99之間的值:");
			string input = Console.ReadLine();

			bool isint = int.TryParse(input, out int number);

			if (isint == false) 

			{ Console.WriteLine("必須輸入整數");
				return;
			}

			if (number > 99 || number < 1)
			{ Console.WriteLine("必須輸入1~99內的整數");return; }

			Console.WriteLine($"您輸入的值是{number}");





		}
	}
}
