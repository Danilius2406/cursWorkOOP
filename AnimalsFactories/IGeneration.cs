using System.Drawing;

namespace WinForm
{
    interface IGeneration
    {
     public void Generation(List<GameObject>[,] map, Point Coordinate);
    }
}