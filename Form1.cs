using System;
using System.Drawing;
using System.Windows.Forms;
namespace WinForm
{
    public partial class Form1 : Form
    {
        public int numberOfBears, numberOfHyenas, numberOfTigers, numberOfWolfs, numberOfBulls, numberOfCows, numberOfRabbits, numberOfSheeps;
        private List<GameObject>[,] _gameModelMap;
        private GameModel gameModel;
        private Simulation simulation;
        private int _mapLenght;
        public Form1()
        {
            InitializeComponent();                  
        }

        public void button1_Click(object sender, EventArgs e)
        {
            numberOfBears = int.Parse(textBox5001.Text);
            numberOfHyenas = int.Parse(textBox5002.Text);
            numberOfTigers = int.Parse(textBox5003.Text);
            numberOfWolfs = int.Parse(textBox5004.Text);
            numberOfBulls = int.Parse(textBox5005.Text);
            numberOfCows = int.Parse(textBox5006.Text);
            numberOfRabbits = int.Parse(textBox5007.Text);
            numberOfSheeps = int.Parse(textBox5008.Text);

            gameModel = new GameModel(numberOfBears, numberOfHyenas, numberOfTigers, numberOfWolfs, numberOfBulls, numberOfCows, numberOfRabbits, numberOfSheeps);
            _mapLenght = gameModel.mapLenght;
            _gameModelMap = gameModel.map;
             simulation = new Simulation(gameModel.map);

            int indentTop = 65;
            for (int i = 0; i < _mapLenght; i++)
            {
                int indentLeft = 200;
                for (int j = 0; j < _mapLenght; j++)
                {
                    var textBox = new TextBox();
                    textBox.Multiline = true;
                    textBox.Height = 9;
                    textBox.Width = 9;
                    textBox.Top = indentTop;
                    textBox.Left = indentLeft;
                    indentLeft += 9;
                    textBox.Name = $"textBox{i}{j}";
                    Controls.Add(textBox);
                }
                indentTop += 9;
            }

            //simulation.Start(this);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            simulation.Start(this);
        }

        public void Visualization()
        {
            
            foreach (var cell in _gameModelMap)
            {

                foreach (var obj in cell)
                {
                    TextBox textBox = Controls[$"textBox{obj.Coordinate.X + 1}{obj.Coordinate.Y + 1}"] as TextBox;
                    if (obj is Predators)
                    {                      
                        textBox.BackColor = Color.Red;
                        continue;
                    }
                    else if (obj is Preys)
                    {                       
                        textBox.BackColor = Color.Blue;
                        continue;
                    }
                    else if (obj is Grass)
                    {                
                        textBox.BackColor = Color.Green;
                        continue;
                    }
                }
            }

        }


    }
}