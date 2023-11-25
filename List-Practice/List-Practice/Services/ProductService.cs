using System;
using List_Practice.Data;
using List_Practice.Models;
using List_Practice.Services.Interface;

namespace List_Practice.Services
{
    public class ProductService : IProductService
    {
        public List<Products> GetAll()
        {
            return AppDbContext.Products();
        }


        public List<Products> GetAllByDescending()
        {
            return AppDbContext.Products().OrderByDescending(M => M.Price).ToList();
        }


        public Products GetById(int id)
        {
            return AppDbContext.Products().FirstOrDefault(m => m.Id == id);
        }
    }
}

