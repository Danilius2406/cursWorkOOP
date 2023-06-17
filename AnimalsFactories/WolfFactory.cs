using System.Drawing;

namespace WinForm
{
    class WolfFactory : IGeneration
    {
        public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
             ActionsOnMap.AddObject(Coordinate, map, new Wolf());
        }
    }
}