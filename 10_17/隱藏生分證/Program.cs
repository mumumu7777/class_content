using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 隱藏生分證
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//string id = "z123456789";
			Console.Write("請輸入id:");
			 string id = Console.ReadLine();

			if (string.IsNullOrEmpty(id) || id.Length !=10 )
			{

				Console.WriteLine( "id 格式部隊");
				
			}
			string displayid = id.Substring(0, 1) + new string('*', 6) + id.Substring(6, 3); //6後3
			Console.WriteLine(displayid);

		}
	}
}
