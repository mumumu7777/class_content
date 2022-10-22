using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toup_tolow
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string answer = "abb555";
			Console.Write("輸入以下英文:");
			string input = Console.ReadLine();
			
			if (string.IsNullOrEmpty(input))
			{ Console.WriteLine("輸入以下英文:");
				return;
			}

			if (input.ToLower() == answer)

			{ Console.WriteLine("正確"); }

			else

			{ Console.WriteLine("錯誤"); }

		}
	}
}
