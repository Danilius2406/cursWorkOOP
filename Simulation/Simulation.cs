using System.Threading;
namespace WinForm;

class Simulation
{
    public static event Action Update;
    public delegate void AnimalsMove(List<GameObject>[,] map);
    public static event AnimalsMove Move;
    private int _delay;
    public static int MaxTurns { get; private set; }
    private readonly List<GameObject>[,] _map;
    private int _turnsCount;


    public Simulation(List<GameObject>[,] map)
    {
        _delay = 100;
        MaxTurns = 100;
        _map = map;
        _turnsCount = 0;      
    }

    public void Start(Form1 form)
    {
        try
        {
            while (_turnsCount < MaxTurns)
            {
                Update.Invoke();
                Move.Invoke(_map);
                Thread.Sleep(_delay);
                form.Visualization();
                _turnsCount++;
            }
        }
        catch (Exception)
        {
            
        }
        
    }

}