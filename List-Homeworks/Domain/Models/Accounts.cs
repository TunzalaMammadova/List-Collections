using System;
namespace Domain.Models
{
	public class Accounts : BaseEntity
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}
}

