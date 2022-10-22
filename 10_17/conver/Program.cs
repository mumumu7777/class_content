using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conver
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//輸入生日

			Console.Write("請輸入生日:");
			string input = Console.ReadLine();

			DateTime birthday = Convert.ToDateTime(input);
			DateTime today = DateTime.Today;


			if (input == null) 
			{
			Console.WriteLine("請輸入生日:");
			}

			if (today < birthday)
			{
				Console.WriteLine("請輸入正確日期"); }

			else
			{
				Console.WriteLine($"您的生日是{birthday:yyyy:MM:dd}");
				Console.WriteLine("您的生日是" + birthday.ToString("yyyy,M,d"))
				; }


			}




			

		}
	}

