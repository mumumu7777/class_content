using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 格式化
{
	internal class Program//3:39
	{
		static void Main(string[] args)
		{

			string name = "ammy";
			bool gender = true;
			string genderdescription = (gender == true) ? "先生" : "女士";
			int age = 18;
			DateTime datebir = new DateTime(1998,3,15);
			string template = "嗨 {0}{1} 您好，您的年紀是{2}";
			string template2 = "你好{0}{1} 您的生日是{2:yyyy,M,d}\r\n{2:M}月是您的生日";
			string message2 = string.Format(template2, name, genderdescription, datebir);
			string message = string.Format(template, name, genderdescription, age);

			Console.WriteLine(	message);
			Console.WriteLine( message2);	
			//c13 1017

			//$ 簡潔 message = $"{(name)(genderdesscription)}
			//最差的 mesasage= "hi"+name +....)
		}
	}
}
