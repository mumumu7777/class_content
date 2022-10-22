using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryd
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> cities = new Dictionary<int, string>();

			cities.Add(1, "台北");
			cities.Add(2, "台中");
			cities.Add(3, "台南");

			string city = cities[2];

			bool b1 = cities.ContainsKey(99);//false
			if (cities.ContainsKey(3))

			{
				city= cities[3];

			}

			foreach( int key in cities.Keys)
				{ 
				string cityname = cities[key];
				Console.WriteLine(cityname);
			}
		}
	}
}
