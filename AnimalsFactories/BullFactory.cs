using System.Drawing;

namespace WinForm
{
    class BullFactory : IGeneration
    {
        public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
             ActionsOnMap.AddObject(Coordinate, map, new Bull()); 
        }
    }
}