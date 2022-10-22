using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converto
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "12";

		    int n1 = Convert.ToInt32(value);//轉不成失敗

			n1= int.Parse(value);//不推

			//推薦 成功船true n1 裡有值 失敗船false n1=0

			
			bool isint = int.TryParse(value, out n1);

			decimal m1 = Convert.ToDecimal(value);
			bool isdecimal = decimal.TryParse(value, out decimal d3);
			Console.WriteLine( d3);

			double d2 = Convert.ToDouble(value);
			d2 = double.Parse(value);
			bool isDouble = double.TryParse(value, out double d4);



		}
	}
}
