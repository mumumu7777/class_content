using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//迴圈找陣列第一個基數

			int[] number = { 66, 88, 30, 5,6,9 };

			for (int i = 0; i < number.Length;i++)

			{ if (number[i]%2==1)
				{ Console.WriteLine(number[i]);
					return;
					
				}
					}

		}
	}
}
