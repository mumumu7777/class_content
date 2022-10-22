using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小數
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//雙精位數
			double d1 = 5.2;
			double d2 = 5.2d;
			double d3 = 5.2D;

			//float f1 = 5.2 (X 5.2預設是DOUBLE
			//單精位數
			float f1 = 5.2f;
			float f2 = 5.2F;

			//十精位數
			//decimal m1 = 5.2 錯誤同上
			decimal m1 = 5.2m;
			decimal m2 = 5.2M;

			//顯示轉型
			//int => double
			int number = 5;
			d1 = (double)number;//d1 = 5.0

			//隱式轉型
			d1= number; //int自動轉double

			d1 = 10/ 4;
			Console.WriteLine(d1);
			d1 = (double)10 / 3;
			Console.WriteLine(d1);
			d1 = (double)10 / (double)4;
				Console.WriteLine(d1);
			//數值格式化
			//百分比
			d1 = 0.125;
			string value = d1.ToString("p");//p 小數點幾位
			Console.WriteLine(value);
			string value2 = d1.ToString("p1");
			Console.WriteLine(value2);
			string value3 = d1.ToString("p0"); //0位會四捨五入
			Console.WriteLine(value3);

			//指定小數位數 10/18 2:19

			d1 = 0.13;
			string value4 = d1.ToString("#.####");//".13
			string value4_2 = d1.ToString("#.0000");//".1300"

			d1 = 0.1357;
			string value4B = d1.ToString("#.####");//".1357

			d1 = 0.13579;
			string value4c = d1.ToString("#.####");

			d1 = 123.456;
			string value4e = d1.ToString("000000.00000");//"000123.45600

			d1 = 123456789;
			string value4f = d1.ToString("#,#");//"12,345,678"


		}
	}
}
