using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//99乘法表只顯示基數

			string template = "{0}*{1}={2}";
			template = "{0}乘以{1}等於{2}";
			string row = string.Empty;
			for (int i = 2; i <= 9; i++)

			{
				for (int j = 1; j <= 9; j++)
				{
					if (j > i)//第二個值大於第一個直指顯示偶數

					{
						if (j % 2 == 0)
						{
							//Console.WriteLine($"{i}*{j}={i * j}");
							row = string.Format(template, i, j, i * j);
							Console.WriteLine(row);
						}

						else //第二個值沒有大於第一個值,show all

						{ //Console.WriteLine($"{i}*{j}={i * j}"); }

							row = string.Format(template, i, j, i * j);
							Console.WriteLine(row);



						}
					}


				}

			}
		}
	}
}
