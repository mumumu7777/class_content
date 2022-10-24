using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//allen kuo 名子不同寫法

			Console.WriteLine("輸入名:");
			string input =Console.ReadLine();

			//變小寫 切割成正烈
			string[] words = input.ToLower().Split(' ');//{"allen","kuo"}
			for (int i =0; i < words.Length; i++)
			{words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);}
			string result = string.Join(" ", words);//將陣列合成字串,每項目用空格切割
			Console.WriteLine(result);

		}
	}
}
