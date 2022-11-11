using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Utility
{
	public class sqlparameterbuilder
	{

		private List<SqlParameter> parameters = new List<SqlParameter>();
		public sqlparameterbuilder ADDNvarchar(string name, int length, string value)
		{ 
		var param = new SqlParameter(name, SqlDbType.NVarChar, length) { Value = value};
			parameters.Add(param);
			return this;
		}

		public sqlparameterbuilder ADDint(string name, int value)
		{
			var param = new SqlParameter(name, SqlDbType.Int) { Value = value };
			parameters.Add(param);
			return this;
		}




		public SqlParameter[] build()
		{ 
		return parameters.ToArray();
		
		}


	}
}
