//Author: Nicholas Pica
//FileName: Suzuki.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Suzuki : Car
    {
        private string Company = "Suzuki";
        private string Model;
        private int Speed;

        public string company
        {
            get { return Company; }
        }

        public string model
        {
            get { return Model; }
            set { Model = "DZIRE"; }
        }

        public int speed
        {
            get { return Speed; }
            set { Speed = 220; }
        }
    }
}
