using System;
using Domain.Data;
using Domain.Models;
using Service.Interface;

namespace Service
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employees> GetAll() => AppDbContext.Employees();

        public List<Employees> GetByFilteredEmployees(DateTime startDate, DateTime endDate, decimal salary) => AppDbContext.Employees();
    }
}

