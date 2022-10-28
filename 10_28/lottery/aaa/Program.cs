using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace aaa
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Member[] items =
			{
			new Member{name = "a1",height = 190, Dateofbirth=new DateTime (1990,1,1)},
			new Member{name = "a2",height = 180, Dateofbirth=new DateTime (1980,1,1)},
			new Member{name = "a3",height = 170, Dateofbirth=new DateTime (1970,1,1)}

			};
			Array.Sort(items,Member.按姓名遞增排序);
			IComparer<Member> comparer = new comparebynameASC();
			foreach (var item in items)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
	}
	public class Member:IComparable<Member>
	{ 
	    public int height { get; set; }
		public string name { get; set;}
		public DateTime Dateofbirth { get; set; }
		public static IComparer<Member> 按姓名遞增排序 { get { return new comparebydayofbirthASC(); } }


		public int CompareTo(Member other)
		{
			//Member x = this;

			//Member y = other;

			//return x.height.CompareTo(y.height);

			Member x = this;

			Member y = other;

			return x.Dateofbirth.CompareTo(y.Dateofbirth);
			//相反寫遞減

			//if (x.height>y.height)

			//	return 1000;

			//else if(x.height==y.height)

			//	return 0;
			//else
			//	return -999;
			
		}

		public override string ToString()
		{
			return $"name={name},height={height},birthday={Dateofbirth:yyyy,MM,dd}";
		}

	}
	public class comparebynameDEC : IComparer<Member>
	{
		public int Compare(Member x, Member y)
		{
			return x.name.CompareTo(y.name);
		}
	}

	public class comparebynameASC : IComparer<Member>
	{
		public int Compare(Member x, Member y)
		{
			return y.name.CompareTo(x.name);
		}
	}

	public class comparebydayofbirthDEC : IComparer<Member>
	{
		public int Compare(Member x, Member y)
		{
			return x.Dateofbirth.CompareTo(y.Dateofbirth);
		}
	}
	public class comparebydayofbirthASC : IComparer<Member>
	{
		public int Compare(Member x, Member y)
		{
			return y.Dateofbirth.CompareTo(x.Dateofbirth);
		}
	}
}
