using System;
using Domain.Models;

namespace Service.Interface
{
	public interface IEmployeeService
	{
		List<Employees> GetAll();

        List<Employees> GetByFilteredEmployees(DateTime startDate, DateTime endDate, decimal salary);
	}
}

