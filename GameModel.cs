namespace WinForm
{        
     class GameModel
     {
        public List<GameObject>[,] map;
        public int mapLenght = 64;       
        public GameModel(int numberOfBears, int numberOfHyenas, int numberOfTigers, int numberOfWolfs, int numberOfBulls, int numberOfCows, int numberOfRabbits, int numberOfSheeps)
        {
            map = new List<GameObject>[mapLenght, mapLenght]; 
            for (int i = 0; i < mapLenght; i++)
                for (int j = 0; j < mapLenght; j++)
                    map[i, j] = new List<GameObject>(); 
            GrassGeneration grassGeneration = new GrassGeneration(map);
            AnimalsGeneration animalsGeneration = new AnimalsGeneration(map, mapLenght, numberOfBears, numberOfHyenas, numberOfTigers, numberOfWolfs, numberOfBulls, numberOfCows, numberOfRabbits, numberOfSheeps);
        } 
     }

}   