using System;
using Domain.Models;

namespace Domain.Data
{
	public class AppDbContext
	{
		public static List<Authors> Authors()
		{
			return new List<Authors>
			{
				new Authors{Id = 1,Name ="Abbas" , Surname = "Sehhet", Age = 44},
				new Authors{Id = 2,Name ="Huseyn" , Surname = "Cavid", Age = 59},
				new Authors{Id = 3,Name ="Memmed" , Surname = "Arif", Age =38},
				new Authors{Id = 4,Name ="Elxan" , Surname = "Elatli", Age = 36}
			};
		}


        public static List<Employees> Employees()
        {
            return new List<Employees>
            {
                new Employees{Id = 1,Name ="Semed" , Surname = "Huseynov", Birthday =new(1997,04,20), Salary = 2500},
                new Employees{Id = 2,Name ="Tunzale" , Surname = "Memmedova", Birthday =new(1999,08,08), Salary = 1000},
                new Employees{Id = 3,Name ="Elnur" , Surname = "Memmedov", Birthday =new(2003,04,24), Salary = 1500},
                new Employees{Id = 4,Name ="Nergiz" , Surname = "Memmedova", Birthday =new(1998,05,15), Salary = 3000},
            };
        }


		public static List<Products> Products()
		{
			return new List<Products>
			{
				new Products{Id = 1 , Name ="Iphone", Count = 10 , Price = 2500},
                new Products{Id = 2 , Name ="Samsung", Count = 8 , Price = 1500},
                new Products{Id = 3 , Name ="Nokia", Count = 7 , Price = 500},
                new Products{Id = 4 , Name ="Sony", Count = 15 , Price = 1000}

            };
		}


		public static List<Accounts> Accounts()
		{
			return new List<Accounts>
			{
				new Accounts{Id= 1, Email = "tuni@gmail.com", Password = "12345"},
				new Accounts{Id= 2, Email = "semed@gmail.com", Password = "elnur123"},
				new Accounts{Id= 3, Email = "elnur@gmail.com", Password = "semed123"}
			};
		}
    }
}

