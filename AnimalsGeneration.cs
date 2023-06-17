using System.Drawing;
namespace WinForm
{
    class AnimalsGeneration
    {
        private Random RandomX = new Random();  
        private Random RandomY = new Random();  
       
        public AnimalsGeneration(List<GameObject>[,] map, int _mapLenght)
        {
            GenerateAnimals(map, _mapLenght);                                                       
        }
      
        private void GenerateAnimals(List<GameObject>[,] map, int _mapLenght)
        {
            GenerationFactory factory = new GenerationFactory();
            Point CoordOfAnimal = new Point(0, 0);
            Form1 winForm = new Form1();
            int DataNew;

            factory.SetFactory(new BearFactory());
            DataNew = winForm.numberOfBears;     
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new HyenaFactory());
            DataNew = winForm.numberOfHyenas;  
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new TigerFactory());
            DataNew = winForm.numberOfTigers; 
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new WolfFactory());
            DataNew = winForm.numberOfWolfs; 
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new BullFactory());
            DataNew = winForm.numberOfBulls; 
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new CowFactory());
            DataNew = winForm.numberOfCows; 
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new RabbitFactory());
            DataNew = winForm.numberOfRabbits; 
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new SheepFactory());
            DataNew = winForm.numberOfSheeps; 
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);
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