using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace con3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sql = @"INSERT INTO News(Title,vcontent,modifytime)values(@Title,@vContent,getdate())";
			

			var dbhelper = new SqlDBhelper("default");

				try
				{	
					//SqlParameter titleParam = new SqlParameter("@Title", SqlDbType.NVarChar, 50)
					//{ Value = "878787" };
					//SqlParameter contentParam = new SqlParameter("@vContent", SqlDbType.NVarChar, 3000)
					//{ Value = "  --)  create database ooo" };
					//var parameters = new SqlParameter[] { titleParam, contentParam };
					//dbhelper.ExecuteNonQuery(sql, parameters);

					Console.WriteLine("記錄成功");


				var paramerters = new sqlparameterbuilder()
					.ADDNvarchar("title",50,"eqw")
					.ADDNvarchar("vcontent",3000,"weaawe").build();

				dbhelper.ExecuteNonQuery(sql, paramerters);




				}
				catch (Exception ex)
				{
					Console.WriteLine($"操作失敗,原因:{ex.Message}");
				}
		}
	}
}
