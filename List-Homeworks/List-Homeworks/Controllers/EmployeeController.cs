using System;
using Service;
using Service.Interface;

namespace List_Homeworks.Controllers
{
	public class EmployeeController
	{
		private readonly IEmployeeService _employeeService;

		public EmployeeController()
		{
			_employeeService = new EmployeeService();
		}


		public void GetAll()
		{
            var datas = _employeeService.GetAll();

			foreach (var item in datas)
			{
				Console.WriteLine($"Name - {item.Name}; Surname - {item.Surname}; Birthday - {item.Birthday.ToString("yyyy.MM.dd")}; Salary - {item.Salary}");
			}
        }


		public void GetByFilteredEmployees()
		{
			int count = 0;
			DateTime startDate = new(1997, 01, 01);
            DateTime endDate = new(2005, 01, 01);
			decimal salary = 2000;

			var datas = _employeeService.GetByFilteredEmployees(startDate, endDate, salary);

            foreach (var item in datas)
            {
				if (item.Birthday > startDate && item.Birthday < endDate)
				{
                    if (item.Salary > 2000)
                    {
						count++;
                    }
					
                }
                
            }
            Console.WriteLine(count);
        }
    }
}

