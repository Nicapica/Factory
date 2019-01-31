using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ToyotaFactory : CarFactory
    {
        public void toyotaFactory(string model, int speed)
        {
            model = "Camry";
            speed = 180;
        }

        public void GetCar()
        {
            model = "Camry";
            speed = 180;
            Console.WriteLine("\nModel of toyota: " + Model + "\nTop speed: " + speed);
        }
    }
}
