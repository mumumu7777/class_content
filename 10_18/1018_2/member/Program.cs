using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace member
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var member = new member();
			member.register("allen","123","Allen Kuo","allen@gmail.com");


		}



		class member//會員
		{
			
			public void register(string account, string password, string name, string email)
		    {






            }
		
		
		
		
		}
			///註冊會員
			///name= account <summary>
			/// 註冊會員
			/// 
			/// 
			/// </summary>
		class stringhelper
		{ 
			public string Left(string source,int length)

			{
				if (string.IsNullOrEmpty(source)) return string.Empty;
				if (length<=0) return string.Empty;
				if(source.Length< length) return source;

				return source.Substring(0,length);





			}
		
		
		
		
		
		
		
		
		
		}
	}
}
