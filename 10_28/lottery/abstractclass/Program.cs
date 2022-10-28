using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
	internal class Program
	{
		static void Main(string[] args)
		{
		 

		}
	}

	class A
	{
		public string name;//field

		public String Email
		{
			get { return Email; }
			set { Email = value; }
		}
		public int Height { get; set; }
		public int Add(int num1, int num2)
		{
	      return num1 + num2;
		}

	}

	interface IB
	{
		//不能寫,field
		//不能寫public,private
		string Email { get; set; }
		int Add(int num1, int num2);
	}

	class Member : IB
	{
		//介面有時做也要有
		public string Email { get; set; }

		public int Add(int num1, int num2)
		{
			return num1 + num2;	
		}
	}
}
