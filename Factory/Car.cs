//Author: Nicholas Pica
//FileName: Car.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class Car
    {
        public String Company;
        public String Model = "";
        public int Speed;

            public String company
        {
            get { return Company; }
            set { Company = value; }
        }

        public String model
        {
            get { return Model; }
            set { Model = value; }
        }

        public int speed
        {
            get { return Speed; }
            set { Speed = value; }
        }
    }
}
