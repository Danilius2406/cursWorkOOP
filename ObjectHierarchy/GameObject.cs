﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public abstract class GameObject
    {
        public int Saturability { get; set; }
        public Point Coordinate {get; set;}

    }
}