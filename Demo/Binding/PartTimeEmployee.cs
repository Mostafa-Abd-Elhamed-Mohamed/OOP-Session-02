using Demo.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class PartTimeEmployee : Employee
    {
 
        public double HourRate { get; set; }
        public int NumberOfHour { get; set; }


        public new void Fun01()
        {
            Console.WriteLine("I am Part Time Employee");
        }

        public override void Fun02()
        {
            Console.WriteLine($"Salary : {HourRate * NumberOfHour}");
        }
    }
}
