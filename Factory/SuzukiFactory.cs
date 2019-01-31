//Author: Nicholas Pica
//FileName: SuzukiFactory.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class SuzukiFactory : CarFactory
    {
        public override Car GetCar()
        {
            Suzuki SCar = new Suzuki
            {
                model = "",
                speed = 0
            };
            Console.WriteLine("Car Company: " + SCar.company);
            Console.WriteLine("Model: " + SCar.model);
            Console.WriteLine("Top Speed: " + SCar.speed);
            return SCar;
        }
    }
}
