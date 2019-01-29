using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class SuzukiFactory : Car
    {
        public void suzukiFactory(string model, int speed)
        {
            model = "DZIRE";
            speed = 220;
        }

        public void GetCar()
        {
            model = "DZIRE";
            speed = 220;
            Console.WriteLine("\nModel of suzuki: " + Model + "\nTop speed: " + speed);
        }
    }
}
