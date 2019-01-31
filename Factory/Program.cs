//Author: Nicholas Pica
//FileName: Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = null;
            // This 3 'Console.WriteLine' lines display information to the user so they know how to interact with the program.
            Console.WriteLine("What car type would you like to buy?");
            Console.WriteLine("1. Toyota");
            Console.WriteLine("2. Suzuki");
            Console.WriteLine("Type 't' for 'toyota' and 's' for 'suzuki'");
            Console.WriteLine("Then hit ENTER\n");
            string car;// This line reads in what the user has inputed, and also declares the variable 'car'
            car = Console.ReadLine();
            // An if statement that uses the variable 'car' to see if the user inputed either a 'toyota' or a 'suzuki'.
            // If the user inputed 'toyota', then the infomation from 'ToyotaFactory' will be called and displayed for the user to see.
            if (car == "t")
            {
                ToyotaFactory tf = new ToyotaFactory();
                factory = tf;
            }
            // If the user inputed 'suzuki', then the infomation from 'SuzukiFactory' will be called and displayed for the user to see.
            else if (car == "s")
            {
                SuzukiFactory sf = new SuzukiFactory();
                factory = sf;
            }
            else
            // Incase the user input a invalid response they will get a message telling them so.
            {
                Console.WriteLine("\nIncorrect answer please try again!");
            }
            CarAssembler ca = new CarAssembler();
            ca.AssembleCar(factory);

            Console.ReadKey();
        }
    }
}
