namespace WinForm
{
    internal static class main
    {
        [STAThread]
        static void Main()
        {
            
           
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
           // GameModel gameModel = new GameModel();
            //Simulation simulation = new Simulation(gameModel.map);
            simulation.Start();
        }
    }
}