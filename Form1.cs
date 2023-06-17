namespace WinForm
{
    public partial class Form1 : Form
    {
        public int numberOfBears, numberOfHyenas, numberOfTigers, numberOfWolfs, numberOfBulls, numberOfCows, numberOfRabbits, numberOfSheeps;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberOfBears = int.Parse(textBox1.Text);
            numberOfHyenas = int.Parse(textBox2.Text);
            numberOfTigers = int.Parse(textBox3.Text);
            numberOfWolfs = int.Parse(textBox4.Text);
            numberOfBulls = int.Parse(textBox5.Text);
            numberOfCows = int.Parse(textBox6.Text);
            numberOfRabbits = int.Parse(textBox7.Text);
            numberOfSheeps = int.Parse(textBox8.Text);

            int n = 64;
            int a = 65;
            for (int i = 0; i < n; i++)
            {
                int b = 200;
                for (int j = 0; j < n; j++)
                {
                    var textBox = new TextBox();
                    textBox.Multiline = true;
                    textBox.Height = 7;
                    textBox.Width = 7;
                    textBox.Top = a;
                    textBox.Left = b;
                    b = b + 7;
                    textBox.Name = $"textBox{i}{j}";
                    Controls.Add(textBox);
                }
                a = a + 7;
            }






        }
    }
}