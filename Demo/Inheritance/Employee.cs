﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Eimal { get; set; }

        public void Fun01()
        {
            Console.WriteLine("I am Part Time Employee");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"Salary : ????");
        }
    }
}
