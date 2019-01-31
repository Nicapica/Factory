//Author: Nicholas Pica
//FileName: CarAssembler.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CarAssembler
    {
        public void AssembleCar(CarFactory factory)
        {
            factory.GetCar();
        }
    }
}
