using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int value = 100;
			string valueb = "a";


			switch (value)
			{ 
			
			case 1 : valueb = "b"; break;
			
			case 2 : valueb = "c"; break;

				default:
					Console.WriteLine("ccc");
					break;
			}












		}

		
	}
}
