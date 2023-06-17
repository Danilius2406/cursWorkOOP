using System.Drawing;

namespace WinForm
{
    class HyenaFactory : IGeneration
    {
        public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
             ActionsOnMap.AddObject(Coordinate, map, new Hyena());
        } 
    }
}