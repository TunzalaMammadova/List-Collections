using System;
using Domain;
using Domain.Data;
using Service.Interface;

namespace Service
{
    public class AuthorService : IAuthorService
    {
        public List<Authors> GetAll() => AppDbContext.Authors();

        public List<Authors> GetByAgeAuthors() => AppDbContext.Authors();
             
    }
}

