namespace WinForm
{
    internal static class main
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var form = new Form1();
            Application.Run(form);
        }
    }
}