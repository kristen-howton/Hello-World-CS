using System;

namespace Hello {
    class Program {
        //Starting pint of the application, look for main method
        static void Main (string[] args) {
            //what will run
            Console.WriteLine ("Hello World!");
            SayHi("Bubba");

        }

        static void SayHi(string name) 
        {
            Console.WriteLine($"Hi, {name}");
            
        }
    }
}