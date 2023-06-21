using System.Drawing;
namespace WinForm
{
    class AnimalsGeneration
    {
        private Random RandomX = new Random();  
        private Random RandomY = new Random();
        public AnimalsGeneration(List<GameObject>[,] map, int _mapLenght, int numberOfBears, int numberOfHyenas, int numberOfTigers, int numberOfWolfs, int numberOfBulls, int numberOfCows, int numberOfRabbits, int numberOfSheeps)
        {
            GenerateAnimals(map, _mapLenght, numberOfBears, numberOfHyenas, numberOfTigers, numberOfWolfs, numberOfBulls, numberOfCows, numberOfRabbits, numberOfSheeps);
        }
      
        private void GenerateAnimals(List<GameObject>[,] map, int _mapLenght, int numberOfBears, int numberOfHyenas, int numberOfTigers, int numberOfWolfs, int numberOfBulls, int numberOfCows, int numberOfRabbits, int numberOfSheeps)
        {
            GenerationFactory factory = new GenerationFactory();
            Point CoordOfAnimal = new Point(0, 0);          

            factory.SetFactory(new BearFactory()); 
            Setter(factory, numberOfBears, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new HyenaFactory());
            Setter(factory, numberOfHyenas, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new TigerFactory());
            Setter(factory, numberOfTigers, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new WolfFactory());
            Setter(factory, numberOfWolfs, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new BullFactory());
            Setter(factory, numberOfBulls, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new CowFactory());
            Setter(factory, numberOfCows, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new RabbitFactory());
            Setter(factory, numberOfRabbits, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new SheepFactory());
            Setter(factory, numberOfSheeps, CoordOfAnimal, _mapLenght, map);
        }
        private void Setter(GenerationFactory factory, int DataNew, Point CoordOfAnimal, int _mapLenght, List<GameObject>[,] map)
        {
                for(int i = 0; i < DataNew; i++)
                {
                    CoordOfAnimal.X = RandomX.Next(0, _mapLenght);
                    CoordOfAnimal.Y = RandomY.Next(0, _mapLenght);
                    factory.Generation(map, CoordOfAnimal);
                }
        }
    }
}