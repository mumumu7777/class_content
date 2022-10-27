using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//等腰

			int rows = 5;

			for (int i = 1; i <= rows; i++)
			{ //空白
				string sapce = new string(' ', rows - 1);


				//星號
				string stars = new string('*', 2 * i - 1);
				string row = sapce + stars;
				Console.WriteLine(row);

			}
			

			//string stars = string.Empty;

			//for (int k = 1; k <= 2 * i - 1; k++)
			//{ stars + 1"+"; }

			//string row = spcae + stars

			//三種

			//int rows = 5;
			//for (int i =1; i<=rows; i++)
			//{ string row = new string('*,2*i-1.'),}





		}
		}
}
