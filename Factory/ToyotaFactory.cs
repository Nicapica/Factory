using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ToyotaFactory : Car
    {
        public void toyotaFactory(string model, int speed)
        {
            model = "Camry";
            speed = 180;
        }

        public void GetCar()
        {

        }
    }
}
