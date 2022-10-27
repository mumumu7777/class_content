using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @virtual
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var emp = new Employee();
			emp.salary = 30000;
			int result = emp.Getsalary();
			Console.WriteLine(result);
			
			
			

		}
		public class Employee
		{ 
		     public int salary { get; set; }//月薪
			public virtual int Getsalary()//算應負月薪
			{ 
			return salary;
			}				
		}

		public class sales : Employee
		{
			public int bonus { get; set; }//bonus
			public override int Getsalary()//calc salary
			{
				return salary + bonus;
			}

		}



	}
}
