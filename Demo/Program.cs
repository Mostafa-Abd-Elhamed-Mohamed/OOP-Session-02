
using Demo.Binding;
using Demo.Inheritance;
using Demo.Overriding;

namespace Demo
{
    internal class Program
    {

        #region 3.1.  Polymorphism Methods (Functions) Overloading
        //static int Sum(int x, int y)
        //{
        //    return x + y;
        //}

        //static int Sum(int x, int y, int z)
        //{
        //    return x + y + z;
        //}
        //static double Sum(double x, double y)
        //{
        //    return x + y;
        //}

        //static double Sum(int x, double y)
        //{
        //    return x + y;
        //}
        //static double Sum(double x, int y)
        //{
        //    return x + y;
        //}

        #endregion


        #region When U Need To Use Biding
        //static void EmployeeProcess (FullTimeEmployee employee)
        //{
        //    if (employee == null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //    }

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    if (employee == null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}

        //static void EmployeeProcess(Employee employee)
        //{
        //    if (employee == null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}

        #endregion
        static void Main(string[] args)
        {



            #region Class Vs Struct 
            // Class Vs Struct  
            #endregion



            #region Inheritance
            // Inheritance :

            // X --> Y
            // DRY


            //Parent parent = new Parent(1,2);

            //Console.WriteLine(parent);

            //parent.Fun01();
            //parent.Fun02();


            //Child child = new Child(1,2,3);


            //child.Fun01();
            //child.Fun02();

            #endregion


            #region Relationships Between Classes
            //  Relationships Between Classes

            //1. Inheritance : is a Relationship
            // FullTimeEmployee ---> Employee
            // FullTimeEmployee is a  Employee
            // Child ---> Parent
            // Child is a Parent
            //Child child = new Child(1,2,3);


            // 2. Association : Has a Relationship
            // Book Has Author
            // Library Has Books

            // 2.1. Composition : Has a Relationship
            // 2.1. Aggregation : Has a Relationship 
            #endregion


            #region Polymorphism Overview
            // 3.  Polymorphism
            // 3.1.  Polymorphism Methods (Functions) Overloading
            // 3.2.  Polymorphism Methods (Functions) Overriding 
            #endregion


            #region 3.1.  Polymorphism Methods (Functions) Overloading

            // 3.1.  Polymorphism Methods (Functions) Overloading
            // There are more than Function (in the same scope [class - struct]) 
            //have a same name But With Different Signture
            // (Count - Type - Order) Parameters

            //Sum (1, 2); 
            #endregion

            #region 3.2. Polymorphism Methods (Functions) Overriding
            // 3.2.  Polymorphism Methods (Functions) Overriding 
            // There are more than Function (in the Different scope [class - struct]) 
            //have a same Signture But With Different behaviour


            //TypeB typeB = new TypeB() { A = 12 , B = 13};

            ////typeB.A = 12;
            ////typeB.B = 13;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);
            //        typeB.Fun01();
            // typeB.Fun02(); 
            #endregion


            #region What is The Binding ?
            //// Binding 
            //// What is The Binding ?

            //// Reference From Parent --> Object From Child


            // TypeA Ref ;

            //  Ref = new TypeA();
            //  Ref = new TypeB(); 
            #endregion


            #region Not Binding
            //TypeB Ref = new TypeB();

            //Ref = new TypeA();  // Invalid

            //Child is A Parnet 

            //    // Animal ---> Dog : Dog is Animal
            //    // Not Animal Is Dog 
            #endregion


            #region When U Need To Use Biding
            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{
            //    Id = 1, Address ="Cairo" ,Eimal ="Ahmed@@" ,Name ="Ahmed" ,Salary=12000
            //};

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Address = "Cairo",
            //    Eimal = "Ali@@",
            //    Name = "Ali",
            //    HourRate = 500,
            //    NumberOfHour = 200
            //};

            //EmployeeProcess(fullTime);
            //EmployeeProcess(partTimeEmployee); 
            #endregion

            #region Binding EX

            //TypeA typeA;

            //typeA = new TypeA();
            //typeA = new TypeB();  // TypeA is a Parent Of TypeB
            //typeA = new TypeC();  // TypeA is a Indirect Parent Of TypeC
            //typeA = new TypeD();  // TypeA is a Indirect Parent Of TypeD


            //typeA.Fun01();
            //typeA.Fun02(); 
            #endregion






        }
    }
}
