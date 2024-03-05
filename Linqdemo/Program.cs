using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Linqdemo
{
    class Program
    {
        static void Main()
        {
            //var MethodSyntx = Employee.GetAllEmployees().ToList();  

            //foreach(var Employee in MethodSyntx)
            //{
            //    Console.WriteLine($"ID : {Employee.ID},Name : {Employee.Name}, Salary : {Employee.Salary}");
            //}

            //var QuerySyntx = (from emp in Employee.GetAllEmployees() select emp).ToList();
            //foreach (var Employee in QuerySyntx)
            //{
            //    Console.WriteLine($"ID : {Employee.ID},Name : {Employee.Name}, Salary : {Employee.Salary}");
            //}

            //int[] arr = { 10, 20, 30,40,50,60,70,80 };
            //var usinglamdba = arr.Where(num => num > 30);
            //foreach (var item in usinglamdba)
            //{
            //    Console.WriteLine(item);
            //}
            //var usingquery = (from a in arr where a > 30 select a);
            //foreach (var item in usingquery)
            //{
            //    Console.WriteLine(item);
            //}
            //var usingmethod = Employee.GetAllEmployees().Where(emp => emp.Department == "IT").ToList();
            //foreach (var emp in usingmethod)
            //{
            //    Console.WriteLine($" Name : {emp.Name}, Salary : {emp.Salary}, Department : {emp.Department}");
            //}

            //var querymethod = (from emp in Employee.GetAllEmployees() where (emp.Department == "IT" && emp.Salary > 15000) select emp);
            //foreach (var emp in querymethod)
            //{
            //    Console.WriteLine($" Name : {emp.Name}, Salary : {emp.Salary}, Department : {emp.Department}");
            //}
            int[] arr = { 10, 20, 30, 70, 50, 10, 80 };
            //var usingmethod = arr.Distinct();
            //foreach (var item in usingmethod)
            //{
            //    Console.WriteLine(item);
            //}
            //var usingquery = (from a in arr select a).Distinct();
            //foreach(var item in usingquery)
            //{
            //    Console.WriteLine(item);
            //}
            //var query = (from n in arr select n).ElementAtOrDefault(2);

            //Console.WriteLine(query);
            //var result = Employee.GetAllEmployees() ?? Enumerable.Empty<Employee>();
            //if (result != null)
            //{
            //    foreach (var item in result) { 
            //    Console.WriteLine(item.ID);
            //    }
            //}
            //var res = (from n in arr select n).First();

            //    Console.WriteLine(res);
            //var query = (from emp in Employee.GetAllEmployees() select emp).Last(emp => emp.Department == "Sales");
            //Console.WriteLine($"{query.ID}, {query.Name}, {query.Salary}.{query.Department}");
            //bool res = (from a in arr select a).All(a => a%2 == 0 ? true: false);
            //  if (res)
            //  {

            //          Console.WriteLine(res);
            //  }
            //Dictionary<int, string> employeeDictionarys = Employee.GetAllEmployees().ToDictionary(x => x.ID, x => x.Name);
            //foreach (KeyValuePair<int, string> kvp in employeeDictionarys)
            //{
            //    Console.WriteLine($"Key : {kvp.Key} Value : {kvp.Value}");
            //}
            //Console.ReadKey();
            //var res = (from n in arr orderby n descending  select n);
            //foreach (var n in res)
            //{
            //    Console.WriteLine(n);
            //}
            //var res = (from a in arr select a).Reverse();
            //foreach (var n in res)
            //{
            //    Console.WriteLine(n);
            //}
            //var qury = (from emp in Employee.GetAllEmployees() where emp.Department == "Sales" orderby emp.Salary descending, emp.Name descending select emp);
            //foreach(var item in qury)
            //{
            //    Console.WriteLine($"{item.Name},{item.ID},{item.Salary},{item.Department}");
            //}
            //var res = (from n in arr select n).Skip(3);//Sum();//Min();//Max();//Average();
            //foreach(int n in res)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine(res);
            //var res = (from n in arr select n).SkipWhile(n => n > 20);
            //foreach (var n in res) {
            //Console.WriteLine(n);
            //}
            //var res = (from n in arr select n).Take(n => n  < 40);
            //foreach (var n in res) {
            //Console.WriteLine(n);
            //}
            //int[] arr1 = { 10, 20, 30, 70, 10, 80 };
            //var res = (from n in arr select n)./*Union*/Except(from n in arr1 select n);
            //foreach(var n in res)
            //{
            //    Console.WriteLine(n);
            //}
            var product = (from emp in Employee.GetAllEmployees() group emp by emp.Department into departmentgroup orderby departmentgroup.Key select new { Department = departmentgroup.Key, AverageSalary = departmentgroup.Average(emp => emp.Salary) });
                
            foreach (var item in product) {
                Console.WriteLine($"{item.Department},{item.AverageSalary}");
            }

            

        }
    }
}