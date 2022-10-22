using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<String> LIST = new List<string>();
			List<DateTime> LIST2 = new List<DateTime>();
			List<MEMBER> MEMBERS = new List<MEMBER>();

			List<int> items2 = new List<int> {3,5,8,11,22 };

			List<String> items3 = new List<string> 
			{
			"aaa",
			"e",
			"ghjkk"			
						
			};

			List<string> items4 = new List<string> {
			"aaaa",
			"bbbb"
			};

			List<MEMBER> members = new List<MEMBER>

			{
				new MEMBER {Id=1, Name="allen"},
				new MEMBER {Id=2 , Name="ANNY"}

			};




		}


		class MEMBER
		{

			public int Id { get; set; }

			public string Name { get; set; }

			
		}
	}
}
