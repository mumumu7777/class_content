using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace build_hansu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1027 316

			Member member1 = new Member("阿陳", 136); //建構函數
			member1.creat(); //叫用method 

		}

	}

	public class Member
	//多載(over loading),同名稱,但參數不同 ()型別順序不能一樣
	{
		public Member(string name, int age)
		{
		

     	}
		public void creat()
		{ 
		
		
		}
		//public Member (string name, int age)-----錯誤因為一樣
		public Member(string email, int phonenum, int zipcode)
		{ 
		
		}
	
	}



}
