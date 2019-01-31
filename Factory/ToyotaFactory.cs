//Author: Nicholas Pica
//FileName: ToyotaFactory.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ToyotaFactory : CarFactory
    {
        public override Car GetCar()
        {
            Toyota TCar = new Toyota
            {
                model = "",
                speed = 0
            };
            Console.WriteLine("Car Company: " + TCar.company);
            Console.WriteLine("Model: " + TCar.model);
            Console.WriteLine("Top Speed: " + TCar.speed);
            return TCar;
        }
    }
}
