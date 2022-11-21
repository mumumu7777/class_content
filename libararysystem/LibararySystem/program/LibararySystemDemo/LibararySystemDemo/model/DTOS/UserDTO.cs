using LibararySystemDemo.model.dataindex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararySystemDemo.model.DTOS
{
	public class UserDTO
	{
		public int Id { get; set; }

		public string Account { get; set; }

		public string Password { get; set; }


		public string Name { get; set; }
	}

	public static class UserDTOExts
	{
		public static UserVM ToVM(this UserDTO dto)
		{
			return new UserVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Password = dto.Password,
				Name = dto.Name,
			};
		}

		public static UserIndexVM ToIndexVM(this UserDTO dto)
		{
			return new UserIndexVM
			{
				Id = dto.Id,
				Account = dto.Account,
				// Password = dto.Password,
				Name = dto.Name,
			};
		}
	}
}
