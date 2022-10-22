using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
	internal class Program
	{
		static void Main(string[] args)
		{
			student ammy = new student();
			//ammy.Age = 15;
			ammy.email = "xxxx@gmail.com";
			ammy.Gender = false;

			ammy.dateofbirth = new DateTime(1999, 5, 12);
			DateTime dt = ammy.dateofbirth;

			student kevin = new student();
			DateTime dt2 = kevin.dateofbirth;
			
		}


		class student
		{
			//預設private //field 可以亂打值
			public string name;
			public string email;
			//public int Age;
			public bool Gender;


			private DateTime _dateofbirth;
			//property(屬性),可以做欄位驗證,不能有不合理值
			//field做不到,只能是read/write 都允許 
			public DateTime dateofbirth
			
	        {get { return _dateofbirth; }
				
			set { 
					
					if(value > DateTime.Today)
					{ throw new Exception("生日不可以超過今天"); }					
															
					_dateofbirth = value; } 
						
			}	

			//readonly (唯讀)屬性
			public int age

			{ get { return DateTime.Today.Year - dateofbirth.Year; }
			}
		//method,方法通常命名會用動詞,ex: creat, save,delete,update,export
			public string Getinfo()
			{
				return 

			}
		}


		}

	}

		
	

