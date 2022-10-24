using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int rows = 5;

			for(int i =1 ; i <= rows; i++)
			{
				string plus = new string('+', rows-i);

				string numbers = new string((char)(49-i), i);
				//string numbers = new string(i.ToString()[0],i );
				string row = plus + numbers;

				Console.WriteLine(row);

			}
		}
	}
}
