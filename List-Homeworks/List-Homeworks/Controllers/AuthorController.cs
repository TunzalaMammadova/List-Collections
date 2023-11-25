using System;
using Service;
using Service.Interface;

namespace List_Homeworks.Controllers
{
	public class AuthorController
	{
		private readonly IAuthorService _authorService;

		public AuthorController()
		{
			_authorService = new AuthorService();
		}

		public void GetAll()
		{
			var datas = _authorService.GetAll();

			foreach (var item in datas)
			{
				Console.WriteLine($"Name - {item.Name}; Surname - {item.Surname}; Age - {item.Age}");
			}
		}



		public void GetByAgeAuthors()
		{
            var datas = _authorService.GetAll();

            foreach (var item in datas)
            {
				if(item.Age > 40)
				{
                    Console.WriteLine($"Name - {item.Name}; Surname - {item.Surname}");
                }
                
			}
        }


    }				
}

