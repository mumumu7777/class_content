using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work01
{
	internal class Program
	{
		static void Main(string[] args)
		{


		}

		class address

		{
			//prop
			public string city { get; set; }

			public int zipcode { get; set; }

			public string street { get; set; }
		}


		class member
		{
			public address addr { get; set; }
			public void register( string name, string) { }
		}
	}
}
