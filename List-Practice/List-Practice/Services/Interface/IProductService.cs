using System;
using List_Practice.Models;

namespace List_Practice.Services.Interface
{
	public interface IProductService
	{
		List<Products> GetAll();

		Products GetById(int id);

        List<Products> GetAllByDescending();
    }
}

