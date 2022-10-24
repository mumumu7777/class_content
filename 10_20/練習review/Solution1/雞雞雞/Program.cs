using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 雞雞雞
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//聯立7x+4y=100 , 換數字就不能用了
			// 迴圈3曾for 要跑一百萬圈
			for (int cock = 0; cock <= 20; cock++)
			{
				for (int hen = 0; hen <= (100 - 5 * cock); hen++)
				{
					int chiken = 100 - cock - hen;

					//判斷是為一百

					double price = 5 * cock + 3 * hen + (double)chiken / 3;
					if (price == 100)
					{
						Console.WriteLine($"公雞{cock}隻,母雞{hen}隻,小雞{chiken};");



					}



				}

			}
		}
	}
}
