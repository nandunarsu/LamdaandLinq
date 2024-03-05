using System;
using System.Collections;
namespace LamdaExpression
{
    class Program
    {
        static void Main()
        {
            //List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //List<int> evenno = l.FindAll(i =>(i % 2 != 0));  

            //foreach(int i in evenno)
            //{
            //    Console.WriteLine(i);
            //}

            //List<Dog> dog  = new List<Dog>();
            //dog.Add(new Dog("Dainika", 5));
            //dog.Add(new Dog("Snoopy", 3));
            //dog.Add(new Dog("Dainika", 4));

            //var names = dog.Select(x=> x.Name);
            //var newDoglist = dog.Select(x=> new { Age = x.Age, FirstLetter = x.Name[0] });
            //foreach (var name in newDoglist)
            //{
            //    Console.WriteLine(name);
            //}
            //var DogSort = dog.OrderByDescending(x => x.Age);
            //foreach(var d in DogSort)
            //{
            //    Console.WriteLine($"Dogname : {d.Name}, DogAge : {d.Age}");
            //}

            //Filter a list of employees based on certain criteria using lambda expressions, such as selecting all
            //employees with a salary above a certain threshold.
            //List<Employees> employee = new List<Employees>();
            //employee.Add(new Employees("Anand", 1, 56789.0));
            //employee.Add(new Employees("Ananya", 4, 23489.0));
            //employee.Add(new Employees("Aravind", 2, 864779.0));

            //var price = employee.FindAll(x => (x.Salary > 30000.0));
            //foreach (var d in price)
            //{
            //    Console.WriteLine($"Employeename : {d.Name}, EmployeeId : {d.EmplyeeId}, Salary : {d.Salary}");
            //}

            List<Products> product = new List<Products>();
            product.Add(new Products(1, "Mobile", 23890.00));
            product.Add(new Products(3, "Bluetooth", 936.00));
            product.Add(new Products(2, "Headset", 2890.00));
            product.Add(new Products(4, "Adapter", 499.00));

            var SortedList = product.OrderByDescending(x => x.Price);
            foreach (var item in SortedList)
            {
                Console.WriteLine($"ProductId : {item.ProductId}, ProductName :{item.ProductName}, Price :{item.Price}");
            }


        }
    }
}