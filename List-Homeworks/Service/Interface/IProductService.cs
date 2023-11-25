using System;
using Domain.Models;

namespace Service.Interface
{
	public interface IProductService
	{
		List<Products> GetAll();

		List<Products> SearchProducts(string searchtext);
    }
}

