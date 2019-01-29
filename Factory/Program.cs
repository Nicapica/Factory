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
            Console.WriteLine("What car type would you like to buy?");
            Console.WriteLine("1. Toyota");
            Console.WriteLine("2. Suzuki\n");
            int car = Convert.ToInt32(Console.ReadLine());

            if (car == 1)
            {
                ToyotaFactory tf = new ToyotaFactory();
                tf.GetCar();
            }
            else if (car == 2)
            {
                SuzukiFactory sf = new SuzukiFactory();
                sf.GetCar();
            }
            else
            {
                Console.WriteLine("\nIncorrect answer please try again!");
            }
            Console.ReadLine();
        }
    }
}
