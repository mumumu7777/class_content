using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//字串切割int
			string values = " 10 88 55 66 44";
			string[] scores = values.Split(' ');
			//空白切割得到string 

			//宣告int[] 長度等於scores長度
			int[] result = new int[scores.Length];
			for (int i = 0; i < scores.Length; i++)

			{ result[i] = Convert.ToInt32(scores[i]);
				
			}




			//string 由char[]組成
			//string 

		}
	}
}
