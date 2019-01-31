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
        public virtual string Company { get; }
        public virtual string Model { get; set; }
        public virtual int Speed {get; set;}

    }
}
