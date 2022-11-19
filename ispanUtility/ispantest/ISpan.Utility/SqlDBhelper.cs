using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Utility
{
	public class SqlDBhelper
	{

		private string connstring;
	/// <summary>
	/// 
	/// </summary>
	/// <param name="keyofConectionstring">app.config的值,如'default'</param>
		public SqlDBhelper(string keyofConectionstring)
		{
			 connstring = System.Configuration
				.ConfigurationManager
				.ConnectionStrings[keyofConectionstring]
				.ConnectionString;
			
		}

		public void ExecuteNonQuery(string sql, SqlParameter[] parameters)
		{
			using (var conn = new SqlConnection(connstring))
			{ 
			  SqlCommand command = new SqlCommand(sql, conn);
				conn.Open();

				command.Parameters.AddRange(parameters);
				command.ExecuteNonQuery();	
			}
		}


		public DataTable Select(string sql, SqlParameter[] parameters)
		{


			using (var conn = new SqlConnection(connstring))
			{

				var command = new SqlCommand(sql, conn);
					if (parameters != null)
				{
					command.Parameters.AddRange(parameters);
				};

				
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataSet dataSet = new DataSet();
				adapter.Fill(dataSet, "default");
				return dataSet.Tables["default"];
				
			}
		}
	}


}
