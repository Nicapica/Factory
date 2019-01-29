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
        public String Model;
        public int Speed;

            public string company
        {
            get { return company; }
            set { company = value; }
        }

        public string model
        {
            get { return model; }
            set { model = value; }
        }

        public string speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
