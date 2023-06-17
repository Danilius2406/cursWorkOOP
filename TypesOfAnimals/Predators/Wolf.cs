using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    class Wolf : Predators, IFactory
    {
        public Wolf()
        {
            MaxSatiety = 24;
            MaxSpeed = 3;
            RadiusOfView = 4;
            YoungAge = 19;
        }
        public Animals BorningChild()
        {
            return new Wolf();
        }
    }
}
