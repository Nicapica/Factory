﻿//Author: Nicholas Pica
//FileName: CarFactory.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class CarFactory
    {
        public abstract Car GetCar();
    }
}
