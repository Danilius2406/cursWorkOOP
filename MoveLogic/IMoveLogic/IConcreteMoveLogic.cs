using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    interface IConcreteMoveLogic
    {
        void Move(List<GameObject>[,] map, Animals animal);
    }
}
