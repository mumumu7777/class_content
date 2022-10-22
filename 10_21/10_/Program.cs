using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exxx
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入一個英文句子");
			string input =	Console.ReadLine();

			//delete space

			input = input.Trim();

			//刪除最後句點

			if (input.EndsWith("."))

				{ input = input.Substring(0, input.Length - 1);
			
			}

			//split 切割陣列

			string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			

			
		}


		
	}
}
