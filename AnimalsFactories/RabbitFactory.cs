using System.Drawing;
namespace WinForm
{
    class RabbitFactory : IGeneration
    {
        public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
             ActionsOnMap.AddObject(Coordinate, map, new Rabbit());
        }
    }
}