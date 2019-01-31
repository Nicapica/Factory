//Author: Nicholas Pica
//FileName: CarAssembler.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CarAssembler : CarFactory
    {
        public void AssembleCar(CarFactory factory)
        {
            SuzukiFactory sf = new SuzukiFactory();
            sf.GetCar();
            Console.WriteLine(model + speed + "this is working");
        }
    }
}
