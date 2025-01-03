using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {

        public int z { get; set; }

        public Child(int x , int y , int z) : base (x,y)
        {
      
            this.z = z;
            
        }

        // Overried
        public void Fun01()
        {
            Console.WriteLine("I am Child [Drived]");
        }

        public void Fun02()
        {
            Console.WriteLine($"X : {x} , Y : {y} , Z : {z}");
        }


        public override string ToString()
        {
            return $"X : {x} , Y : {y} , Z : {z}";
        }




    }
}
