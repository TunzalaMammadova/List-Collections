using System;
namespace Domain.Models
{
	public class Employees : BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime Birthday { get; set; }
		public decimal Salary { get; set; }
	}
}

