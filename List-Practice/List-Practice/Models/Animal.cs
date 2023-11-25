using System;
namespace List_Practice.Models
{
	public class Animal
	{
		//public Animal()
		//{
		//	Console.WriteLine("Animal constructor");
		//}
        public int Id { get; set; }
        public string Name { get; set; }

		public virtual void Sound()
		{
			Console.WriteLine("Animal sound");
		}
	}
}

