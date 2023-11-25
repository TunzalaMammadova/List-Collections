using List_Practice;
using List_Practice.Controllers;
using List_Practice.Exceptions;
using List_Practice.Models;


#region Homework
//Generics<Products> products = new();
//products.Add(new Products { Id = 1, Name = "Iphone", Price = 2000 });
//products.Add(new Products { Id = 2, Name = "Samsung", Price = 1000 });
//products.Add(new Products { Id = 3, Name = "Sony", Price = 3000 });


//var res = products.ShowAll();

//foreach (var item in res)
//{
//    Console.WriteLine($"Name: {item.Name}");
//}



//var res = products.GetById(2);

//Console.WriteLine($"Name: {res.Name}");



//products.Delete(1);


//var res = products.ShowAll();

//foreach (var item in res)
//{
//    Console.WriteLine($"Name: {item.Name}");
//}


//try
//{
//    int number = 5;
//    int factorial = 1;

//    if (number < 0)
//    {
//        throw new LestThanZeroExceptions();
//    }
//    for (int i = 1; i <= number; i++)
//    {
//        factorial *= i;
//    }

//    Console.WriteLine(factorial);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}




#endregion



//Animal animal = new Animal();

//Fish fish1 = new Fish();

////fish1.Sound();

//Bird bird = new Bird();

//Animal animal2 = fish1;

//Animal animal3 = bird;

////Bird bird2 = (Bird)animal;



//Animal[] datas = { animal, fish1, bird, animal2, animal3};

//foreach (var item in datas)
//{
//    item.Name = "xxx";
//    Console.WriteLine(item.Name);
//}



//int num1 = 5;

//object obj = num1;

//int num2 = (int)obj;



//bool isMarried = false;

//object data = isMarried;

//bool test = (bool)data;



//string name = "test";

//object data2 = name;

//string name2 = data2.ToString();



//byte num1 = 5;

//int num2 = num1;

//int a1 = 3;

//byte a2 = (byte)a1;

//Console.WriteLine(a2);



//Bird bird = new Bird();

//Fish fish = new Fish();

//Animal animal1 = new Bird();

//Animal animal2 = new Fish();



//object[] datas = { 1, 2, bird, "salam", fish, animal1, 100, animal2 };

//foreach (var data in datas)
//{
//    if (data is Animal t)
//    {
//        t.Name = "xxx";
//        Console.WriteLine(t.Name);
//    }
//    else
//    {
//        Console.WriteLine($"{data} can not convert");
//    }
//}


//foreach (var data in datas)
//{
//    Animal animal = data as Animal;

//    if (animal != null)
//    {
//        animal.Name = "test";
//        Console.WriteLine(animal.Name);
//    }
//}





//List<int> nums = new List<int>();
//List<int> nums2 = new();

//nums2.Add(100);
//nums2.Add(200);

//nums.Add(5);
//nums.Add(2);
//nums.Add(3);

//nums.AddRange(nums2);

//Console.WriteLine(nums.Count);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}


//List<string> names = new List<string>() { "Tunzale", "Arzu", "Semmed", "Ilham" };
//for (int i = 0; i < names.Count; i++)
//{
//    //Console.WriteLine(names[i]);
//}




//List<string> emails = new() { "t@gmail.com", "m@code.edu.az", "c@gmail.com" };

//static void CheckEmail(string email , List<string> emails)
//{
//    if (emails.Contains(email))
//    {
//        Console.WriteLine("yes");
//    }
//    else
//    {
//        Console.WriteLine("No");
//    }
//}

//CheckEmail("c@gmail.com", emails);




//List<Products> products = new();

//products.Add(new Products { Id = 1, Name = "Iphone", Price = 2000 });
//products.Add(new Products { Id = 2, Name = "Samsung", Price = 1000 });
//products.Add(new Products { Id = 3, Name = "Sony", Price = 3000 });

//foreach (var item in products)
//{
//    Console.WriteLine(item.Name);
//}




//static List<Products> Search (string str, List<Products> products)
//{
//    //var datas = products.FindAll(m => m.Name.Contains(str));

//    return products.Where(m => m.Name.Contains(str)).ToList();
//}




//List<int> nums = new() { 1, 2, 3, 4, 5, 6,9,100 };

//for (int i = 0; i < nums.Count; i++)
//{
//    if (i <= 4)
//    {
//        //Console.WriteLine(nums[i]);
//    }
//}



//for (int i = 0; i < nums.Count; i++)
//{
//    if (nums[i] == 5)
//    {
//        break;
//    }
//    else
//    {
//        //Console.WriteLine(nums[i]);
//    }
//}



//for (int i = 0; i < nums.Count; i++)
//{
//    int index = nums.IndexOf(5);

//    if (i<= index)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}


ProductControllers productController = new();

//productController.GetById();

//productController.GetAll();

//productController.GetById();

//Console.WriteLine("---------------");

//productController.GetSorting();

