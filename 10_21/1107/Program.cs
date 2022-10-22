using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1107
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "******ooo*****";
			StringBuilder result =	new StringBuilder();

			for(int i = 0; i < 1000000; i++)

			{ result.Append(value); }
			Console.WriteLine(result.ToString().Length);
			






		}
	}
}
