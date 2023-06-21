using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    class Hyena : Predators, IFactory
    {
        public Hyena()
        {
            MaxSatiety = 50;
            MaxSpeed = 3;
            RadiusOfView = 4;
            YoungAge = 18;
        }
        public Animals BorningChild()
        {
            return new Hyena();
        }
    }
}
