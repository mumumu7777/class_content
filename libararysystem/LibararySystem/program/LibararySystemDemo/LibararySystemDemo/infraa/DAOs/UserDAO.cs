﻿using ISpan.Utility;
using LibararySystemDemo.model.DTOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararySystemDemo.infraa.DAOs
{
	public class UserDAO
	{
		/// <summary>
		/// 傳回所有使用者記錄
		/// </summary>
		/// <returns></returns>
		public IEnumerable<UserDTO> GetAll()
		{
			string sql = @"SELECT * FROM Users ORDER BY ID DESC";

			var dbHelper = new SqlDBhelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new UserDTO
				{
					Id = row.Field<int>("Id"),
					Account = row.Field<string>("Account"),
					Name = row.Field<string>("Name")
				});

		}

		public bool AccountExists(string account)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account=@Account";

			var parameters = new sqlparameterbuilder()
			.ADDNvarchar("Account", 50, account)
				.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool AccountExists(UserDTO model)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE Account=@Account AND Id!=@Id";

			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("Account", 50, model.Account)
			.ADDint("Id", model.Id)
				.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public void Create(UserDTO model)
		{
			string sql = @"INSERT INTO Users
(Account,Password, Name)
VALUES
(@Account,@Password, @Name)";

			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("Account", 50, model.Account)
				.ADDNvarchar("Password", 50, model.Password)
			.ADDNvarchar("Name", 50, model.Name)
				.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(UserDTO model)
		{
			string sql = @"UPDATE Users
			SET Account=@Account, Password=@Password, Name=@Name
			WHERE Id=@Id";

			var parameters = new sqlparameterbuilder()
				.ADDNvarchar("Account", 50, model.Account)
				.ADDNvarchar("Password", 50, model.Password)
				.ADDNvarchar("Name", 50, model.Name)
			.ADDint("Id", model.Id)
				.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM Users WHERE Id=@Id";

			var parameters = new sqlparameterbuilder()
			.ADDint("Id", id)
				.build();

			new SqlDBhelper("default").ExecuteNonQuery(sql, parameters);

		}

		public UserDTO Get(string account)
		{
			string sql = "SELECT * FROM Users WHERE Account=@Account";
			var parameters = new sqlparameterbuilder()
			.ADDNvarchar("Account", 50, account)
				.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToUserDTO(data.Rows[0]);
		}

		public UserDTO Get(int id)
		{
			string sql = "SELECT * FROM Users WHERE Id=@Id";
			var parameters = new sqlparameterbuilder()
			.ADDint("Id", id)
				.build();

			DataTable data = new SqlDBhelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");

			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToUserDTO(data.Rows[0]);
		}


		private UserDTO ToUserDTO(DataRow row)
		{
			return new UserDTO
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
			};
		}
	}
}
