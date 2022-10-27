using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_name
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var member = new Member("ammy");

		}

		private class Member
			{
			
			private string name;
			public Member(string name)
			{ 
			this.name = name;
			
			}
			
			}
	}
}
