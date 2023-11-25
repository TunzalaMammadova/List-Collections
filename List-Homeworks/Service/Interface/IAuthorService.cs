using System;
using Domain;

namespace Service.Interface
{
	public interface IAuthorService
	{
		List<Authors> GetAll();
        List<Authors> GetByAgeAuthors();
	}
}

