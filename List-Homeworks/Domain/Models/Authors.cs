using System;
namespace Domain
{
	public class Authors : BaseEntity
	{
		public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

    }
}

