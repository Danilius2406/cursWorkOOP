using System.Drawing;

namespace WinForm
{
    class TigerFactory : IGeneration
    {
      public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
             ActionsOnMap.AddObject(Coordinate, map, new Tiger());
        }
    }
}