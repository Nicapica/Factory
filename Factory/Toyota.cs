//Author: Nicholas Pica
//FileName: Toyota.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Toyota : Car
    {
        private string Company = "Toyota";
        private string Model;
        private int Speed;

        public string company
        {
            get { return Company; }
        }

        public string model
        {
            get { return Model; }
            set { Model = "Camry"; }
        }

        public int speed
        {
            get { return Speed; }
            set { Speed = 180; }
        }
    }
}
