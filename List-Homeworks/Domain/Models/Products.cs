using System;
namespace Domain.Models
{
	public class Products : BaseEntity
	{
		public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}

