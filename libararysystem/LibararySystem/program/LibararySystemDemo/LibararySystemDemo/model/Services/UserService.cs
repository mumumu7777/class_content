using ISpan.Utility;
using LibararySystemDemo.infraa.DAOs;
using LibararySystemDemo.model.dataindex;
using LibararySystemDemo.model.DTOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararySystemDemo.model.Services
{
	public class UserService
	{

		public void Create(UserDTO model)
		{
			bool isExists = AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");

			new UserDAO().Create(model);
		}

		private bool AccountExists(string account)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account=@Account";

			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("Account", 50, account)
				.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private bool AccountExists(UserDTO model)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account=@Account AND Id!=@Id";
			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("Account", 50, model.Account)
				.ADDint("Id", model.Id)
				.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private UserIndexVM ParseToIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Name = row.Field<string>("Name")
			};
		}

		internal void Update(UserDTO model)
		{
			bool isExists = AccountExists(model);
			if (isExists) throw new Exception("帳號已存在");

			new UserDAO().Update(model);
		}

		internal void Delete(int id)
		{
			new UserDAO().Delete(id);
		}

		public bool Authenticate(LoginVM model)
		{
			var user = new UserDAO().Get(model.Account);
			if (user == null) return false; // 找不到符合的帳號

			return (user.Password == model.Password);
		}
	}
}
