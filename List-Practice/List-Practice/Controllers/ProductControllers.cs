using System;
using List_Practice.Services;
using List_Practice.Services.Interface;

namespace List_Practice.Controllers
{
	public class ProductControllers
	{
        private readonly IProductService _service;
        public ProductControllers()
        {
            _service = new ProductService();
        }

        public void GetAll()
        {
            var datas = _service.GetAll();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }
        }


        public void GetById()
        {
            var data = _service.GetById(2);
            Console.WriteLine(data.Name + " " + data.Price);
        }

        

        public void GetSorting()
        {
            var datas = _service.GetAllByDescending();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }
        }
    }
}

