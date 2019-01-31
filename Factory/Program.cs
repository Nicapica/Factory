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
            Console.WriteLine("Type '1' for 'toyota' and '2' for 'suzuki'");
            Console.WriteLine("Then hit ENTER\n");
            int car = Convert.ToInt32(Console.ReadLine());// This line reads in what the user has inputed, and also declares the variable 'car'
            // An if statement that uses the variable 'car' to see if the user inputed either a 'toyota' or a 'suzuki'.
            // If the user inputed '1' which is 'toyota', then the infomation from 'ToyotaFactory' will be called and displayed for the user to see.
            if (car == 1)
            {
                ToyotaFactory tf = new ToyotaFactory();
                tf.GetCar();
            }
            // If the user inputed '2' which is 'suzuki', then the infomation from 'SuzukiFactory' will be called and displayed for the user to see.
            else if (car == 2)
            {
                SuzukiFactory sf = new SuzukiFactory();
                sf.GetCar();
            }
            else
            // Incase the user input a invalid response they will get a message telling them so.
            {
                Console.WriteLine("\nIncorrect answer please try again!");
            }
            Console.ReadLine();// This line reads in what the user has inputed
            CarAssembler ca = new CarAssembler();
            ca.AssembleCar(factory);
        }
    }
}
