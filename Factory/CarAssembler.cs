using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CarAssembler : CarFactory
    {
        public void AssembleCar()
        {
            SuzukiFactory sf = new SuzukiFactory();
            sf.GetCar();
        }
    }
}
