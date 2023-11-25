using System;
namespace List_Practice.Exceptions
{
	public class LestThanZeroExceptions : Exception
	{
		public LestThanZeroExceptions() : this("Cannot be less than zero!")
		{

		}

		public LestThanZeroExceptions(string msj) : base (msj)
		{

		}
	}
}

