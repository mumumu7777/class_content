using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan.Utility;
namespace update
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string sql = @"update News set Title = @Title,
             Vcontent=@vcontent,Modifytime=getdate() where id =@id";

			var dbhelper = new SqlDBhelper("default");


			try
			{

				var paramerters = new sqlparameterbuilder()
					.ADDNvarchar("title", 50, "eq5434w")
					.ADDNvarchar("vcontent", 3000, "wea3543awe")
					.ADDint("id",3)
					.build();

				dbhelper.ExecuteNonQuery(sql, paramerters);
				Console.WriteLine("更改成功");

			}
			catch (Exception ex)
			{
				Console.WriteLine($"操作失敗,原因:{ex.Message}");
			}


		}
	}
}
