using System;
using Domain.Data;
using Domain.Models;
using Service.Interface;

namespace Service
{
    public class AccountService : IAccountService
    {
        public List<Accounts> GetAll() => AppDbContext.Accounts();

        public bool CheckEmail(string email, string password) => AppDbContext.Accounts().Exists(m => m.Email == email && m.Password == password);
          
         
    }
   
}

