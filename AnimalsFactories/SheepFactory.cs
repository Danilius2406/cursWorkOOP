using System.Drawing;

namespace WinForm
{
    class SheepFactory : IGeneration
    {
       public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
             ActionsOnMap.AddObject(Coordinate, map, new Sheep());
        }
    }
}