using System;
using List_Practice.Models;

namespace List_Practice.Data
{
	public static class AppDbContext
	{
		public static List<Products> Products()
		{
			return new List<Products>()
			{
				new Products { Id = 1, Name = "Iphone", Price = 2000 },
				new Products { Id = 2, Name = "Samsung", Price = 1000 },
				new Products { Id = 3, Name = "Sony", Price = 3000 },


			};
        }
	}
}

