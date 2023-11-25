using System;
using Domain.Data;
using Domain.Models;
using Service.Interface;

namespace Service
{
    public class ProductService : IProductService
    {
        public List<Products> GetAll() => AppDbContext.Products();

        public List<Products> SearchProducts(string searchtext) => AppDbContext.Products().FindAll(m => m.Name.Contains(searchtext.ToLower().ToUpper().Trim()));
        
    }
}

