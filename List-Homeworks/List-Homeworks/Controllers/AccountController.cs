using System;
using System.Security.Principal;
using Service;
using Service.Interface;

namespace List_Homeworks.Controllers
{
	public class AccountController
	{
		private readonly IAccountService _account;

		public AccountController()
		{
            _account = new AccountService();
        }
        public void GetAll()
        {
			var datas = _account.GetAll();

			foreach (var item in datas)
			{
				Console.WriteLine($"Email: {item.Email}; Password: {item.Password}");
			}

		}


		public bool Login()
		{
			Console.WriteLine("Please add your username");
			string email = Console.ReadLine();

			Console.WriteLine("Please add your password");
            string password = Console.ReadLine();

			return _account.CheckEmail(email,password);




        }
	}
}

