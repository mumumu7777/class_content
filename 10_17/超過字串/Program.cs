using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超過字串
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("新聞標題:");
			string name = Console.ReadLine();

			if (string.IsNullOrEmpty(name))
			{ Console.WriteLine("標題");

				return;
			}

			if (name.Length <= 10)

			{ Console.WriteLine(name); }


			else

			{ string name2 = name.Substring(0, 10);
				Console.WriteLine(name2+"...");
			
			}






		}
	}
}
