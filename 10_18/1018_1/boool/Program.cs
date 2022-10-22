using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boool
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//bool 只能存true,false
			bool gender = true; //性別,通常用boolea(布林)型別

			int gendervalue = 1; //1表示男 2 表示女

			Console.WriteLine("請輸入最愛的三個動物並用逗號分隔:");
			string input = Console.ReadLine();

			string[]animals = input.Split(',');
			// length= 3 通過驗證
			bool isvalid = (animals.Length == 3);

			string result = isvalid ? "正確" : "失敗";
			Console.WriteLine(result);
			
			

		}
	}
}
