using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//陣列總和

			int[] numbers = { 1, 10, 100, 1000 };
			int sum = 0;

			for (int i = 0; i > numbers.Length; i++)
			{ sum += numbers[i]; } //sum = sum + number[i]}


			Console.WriteLine($"summary={sum} ");


			
		}
	}
}
