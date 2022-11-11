using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan.Utility;
using System.Data;
using System.Runtime.InteropServices;

namespace select
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var dbhelper = new SqlDBhelper("default");
			string sql = "select id , Title from News where id >@id order by id desc";
			try
			{
				var parameters = new sqlparameterbuilder().ADDint("id", 0).build();
				DataTable news = dbhelper.Select(sql,parameters);
				foreach (DataRow row in news.Rows)
				{
					int id = row.Field<int>("id");
					string title = row.Field<string>("title");
					Console.WriteLine($"id ={id},title={title}");

				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"未執行因為{ex}");
			}

		}
	}
}
