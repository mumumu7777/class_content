using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writeclass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			people p1 = new people();
			Employee e1 = new Employee();
			

			//p2 屬性2個//以宣告型別為準
			people p2 = new Employee();

			//以右邊型別為準
			var obj3 = new Employee();
		}

		/// <summary>
		/// human
		/// </summary>
		
		public class people
		{
			public bool Gender { get; set; }//gender
			public string SID { get; set; } //Id
		}

		public class Employee : people    // :  繼承
		{
			public string BageNumber { get; set; }//employeesId		
		}
	}
}
