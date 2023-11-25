using System;
using Domain.Models;

namespace Service.Interface
{
	public interface IAccountService
	{
		List<Accounts> GetAll();

		public bool CheckEmail(string email, string password);

    }
}

