
using List_Homeworks.Controllers;



AuthorController author = new();

//author.GetAll();
//author.GetByAgeAuthors();




EmployeeController employee = new();

//employee.GetAll();
//employee.GetByFilteredEmployees();




AccountController account = new();

ProductController product = new();



    
if (account.Login() is true)
{
    Console.WriteLine("Please enter choice");
    int number = int.Parse(Console.ReadLine());

    switch (number)
    {
        case 1:
            product.GetAll();
            break;

        case 2:
            product.Search();
            break;
    }
}
