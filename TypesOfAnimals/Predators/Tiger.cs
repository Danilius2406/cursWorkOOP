﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    class Tiger : Predators, IFactory
    {
        public Tiger()
        {
            MaxSatiety = 55;
            MaxSpeed = 3;
            RadiusOfView = 4;
            YoungAge = 23;
        }
        public Animals BorningChild()
        {
            return new Tiger();
        }
    }
}
