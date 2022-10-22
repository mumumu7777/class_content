using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 陣列
{
	internal class Program
	{
		static void Main(string[] args)
		{;
			//存人名
			string[] students = new string[] { "Ammy", "Shelly", "Sandra" };
			var students2 = new string[] { "Ammy", "Shelly", "Sandra" };
			string[] students3 = { "Ammy", "Shelly", "Sandra" };

			// 可以改植 不改長度

			string[] students4 = new string[5];
			students4[0] = "heddy";
			students4[1] = "shelly";
			students4[2] = "Andrew";
			students4[3] = "michael";

			//存成績

			int[] grades = new int[] {1,2,3};
			int[] grades2 = {1,2,3};

			//列舉陣列值
			int length = students.Length;
			for (int i = 0; i < students.Length; i++)

			{ Console.WriteLine(students[i]); }

			// (超常用) 
			string value = "ammy,allen,amma,amyu";
			string[] names = value.Split(',');
			var name2 = value.Split(',');

			// 去除分隔符號與空白項目
			value = "ammy,allen,,,,,,,,,amma,amyu";
			string[] name3 = value.Split(new char[] { ',', '/', ';' },StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < name3.Length; i++)
			{ Console.WriteLine(name3[i]); }
		}   


	}
}
