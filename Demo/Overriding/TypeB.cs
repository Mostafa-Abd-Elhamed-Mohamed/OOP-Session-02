using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        // Override Or Hide
        // Applay Overrid 
        // 1. Applay Override Using 'new' Ketword
        // 1. Applay Override Using 'override' Ketword

        public new void Fun01() // Override Using 'new' Ketword
        {

            Console.WriteLin e("Fun01 From TypeB");
        }

        // Must Not be Private and Virsual
        //public override Fun02() //Override Using 'override' Ketword
        //{

        //    Console.WriteLine($"A : {A} , B : {B}");
        //}

        public override void Fun02()
        {
            Console.WriteLine($"A : {A} , B : {B}");
        }
    }
}
