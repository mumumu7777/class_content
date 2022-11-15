﻿using ISpan.Estore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Estore.Models.Services
{
	public class UserService
	{

		public List<UserIndexVM> GetAll()
		{

			string sql = @"select * from Users order by id desc";
			var dbHelper = new SqlDBhelper("default");
			//存放field李,稍後在gridcellclick需要用到
			 return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToList();
		}

		public void Create(uservm model)
		{

			bool isExist = AccountExists(model.Account);
			if (isExist) throw new Exception("帳號已存在");
			string sql = @"INSERT INTO users
			(Account,PassWord, Name)
			VALUES
			(@Account,@PassWord, @Name)";

			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("Account", 50,model.Account)
				.ADDNvarchar("PassWord", 50, model.PassWord)
			.ADDNvarchar("Name", 50,model.Name)
			.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

		}

		private bool AccountExists(string account)
		{
			string sql = @"select count(*) as count from users where account=@account";
			var parameters = new sqlparameterbuilder()
			.ADDNvarchar("Account", 50, account)
			.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;

		}
		private UserIndexVM ParseToIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				ID = row.Field<int>("id"),
				Account = row.Field<string>("Account"),
				Name = row.Field<string>("Name"),
				PassWord = row.Field<string>("password")
			};
		}

		internal bool authenticate(LoginVM model)
		{
			var user = GetUservm(model.Account);
			if (user == null)return false;
			return (user.PassWord == model.PassWord);
		}

		public uservm GetUservm(string account)
		{
			string sql = @"select * from users where account=@account";
			var parameters = new sqlparameterbuilder()
			.ADDNvarchar("Account", 50, account)
			.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);
			if (data.Rows.Count == 0)
			{
				return null;
			}
			//將找到的一筆紀錄由datatable 轉道uservm
			return TOuservm(data.Rows[0]);
		}
		private static uservm TOuservm(DataRow row)
		{
			return new uservm
			
			{
				id = row.Field<int>("id"),
				PassWord = row.Field<string>("PassWord"),
				Name = row.Field<string>("Name"),
				Account = row.Field<string>("Account")
			};
		}
		

	}


}
