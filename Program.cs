using System;
namespace ConsoleApp
    {
    class myException : Exception
    { 
      
    }

    
    class Program
    {  
        static void Main()
        {   

            QuadraticEducation Q=new QuadraticEducation();

            Console.WriteLine(Q.ToString());
            Console.WriteLine(Q.Solve());
        }
    }
}