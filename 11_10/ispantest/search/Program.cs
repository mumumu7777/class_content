using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["default"].ConnectionString;
			string sql = "select id,title from News where id >@id oreder by id desc";


			using (var conn = new SqlConnection(connstring))
			{

				try 
				{ 
					var command = new SqlCommand(sql, conn);
					var parameters = new SqlParameter[]
						{ new SqlParameter("@id",SqlDbType.Int){ Value = 0} };

					command.Parameters.AddRange(parameters);
					SqlDataAdapter adapter = new SqlDataAdapter(command);
					DataSet dataSet = new DataSet();
					adapter.Fill(dataSet,"news");

					DataTable news = dataSet.Tables["news"];
					foreach (DataRow row in news.Rows)
					{
						int id = row.Field<int>("id");
						string title = row.Field<string>("title");
						Console.WriteLine($"id={id},title={title}");
					}


				}



				catch (Exception ex) {}
			
			
			
			}





		}
	}
}
