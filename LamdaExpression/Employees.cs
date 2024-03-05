using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    class Employees
    {
        public string Name { get; set; }
        public int EmplyeeId {  get; set; }
        public double Salary { get; set; }

        public Employees(string name, int emplyeeId, double salary)
        {
            Name = name;
            EmplyeeId = emplyeeId;
            Salary = salary;
        }
    }
}
