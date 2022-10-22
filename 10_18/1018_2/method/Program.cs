using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
	internal class Program
	{
		static void Main(string[] args)
		{
			mathutility utill = new mathutility();
			int result = utill.Add(2, 5);
			//Console.WriteLine(utill.Add(2,5));

			Console.WriteLine(utill.sub(5,1));

			Console.WriteLine(utill.sqrt(4999,5000));

			Console.WriteLine(utill.round(13.5679));


		}

		public class mathutility

		{
			public int Add(int num1,int num2)//兩個相加
			{
				return num1 + num2;
			}

			public int sub(int num1,int num2)//兩數相減
			{ return num1 - num2;}


			public double sqrt(double num1,double num2)
				{ return (double)Math.Sqrt(num1 + num2); }

			public int round(double value)
			{  return (int)Math.Round(value,MidpointRounding.AwayFromZero); }
		}


	}
}
