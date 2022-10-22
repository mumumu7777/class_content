using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Dictionary<string, int> dics = new Dictionary<string, int>();

			//	dics.Add("aa", 5);
			//dics.Add("bb",1);
			//dics.Add("cc", 2);
			string value = "aa;b;cc;dd;s;fds;nghn";
			string[] items = value.Split(';');

			foreach (string item in items)

			{

				if (dics.ContainsKey(item))
				{

					dics[item]++;

				}
				else { 
				
				dics.Add(item, 1);
				}
				Console.WriteLine(item);
			
			}







			foreach (string key in dics.Keys) 
			{
				string row = $"{key}出現{dics[key]}次";


			}


		}
	}
}
