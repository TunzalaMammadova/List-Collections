using System;
using Service;
using Service.Interface;

namespace List_Homeworks.Controllers
{
	public class ProductController
	{
		private readonly IProductService _product;

		public ProductController()
		{
			_product = new ProductService();
		}


        public void GetAll()
        {
            var datas = _product.GetAll();

            foreach (var item in datas)
            {
                Console.WriteLine($"Email: {item.Name}; Count: {item.Count}; Price: {item.Price}");
            }

        }


        public void Search()
        {
            Console.WriteLine("Please enter text");
            string searchtext = Console.ReadLine();

            var result = _product.SearchProducts(searchtext);

            foreach (var item in result)
            {
                Console.WriteLine($"Email: {item.Name}; Count: {item.Count}; Price: {item.Price}");
            }
        }

    }
}

