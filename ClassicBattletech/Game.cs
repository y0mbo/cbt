namespace AssaultSimulator;


public enum Phase
{
    Initiative,
    Movement,
    AerospaceMovement,
    WeaponAttack,
    PhysicalAttack,
    Heat,
    End
}

public class Game
{
    private bool _isGameStarted = false;
    private int _round = 0;
    private Phase _phase;

    public DateTime CreatedDate { get; }
    public string? Description { get; set; }
    public bool IsGameStarted { get { return _isGameStarted; } }
    public string Name { get; }
    public Phase Phase { get { return _phase; } }
    public List<Player> Players { get; }
    public int Round { get { return _round; } }
    

    public Game() : this ("")
    {
        DateTime now = DateTime.Now;

        Name = now.ToString();
        CreatedDate = now;
        Players = new List<Player>();
    }

    public Game(string name)    
    {
        DateTime now = DateTime.Now;

        if (name.Trim() == "")
        {
            Name = now.ToString(); 
        }
        else
        {
            Name = name.Trim();
        }
        CreatedDate = now;
        _round = 0;
        Players = new List<Player>();
    }  

    public void AddPlayer()
    {
        Player player = new Player("Player " + (Players.Count + 1).ToString());
        Players.Add(player);
    }
    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }

    public void AddPlayer(string name)
    {
        if (!_isGameStarted) { 
        Players.Add(new Player(name));
        }
        else
        {
            throw new Exception("Players cannot be added because the game has aleady started.");
        }
    }

    public Phase NextPhase()
    {
        switch(_phase)
        {
            case Phase.Initiative:
                _phase = Phase.Movement;
                return _phase;

            case Phase.Movement:
                _phase = Phase.AerospaceMovement;
                return _phase;

            case Phase.AerospaceMovement:
                _phase = Phase.WeaponAttack;
                return _phase;

            case Phase.WeaponAttack:
                _phase = Phase.PhysicalAttack;
                return _phase;

            case Phase.PhysicalAttack:
                _phase = Phase.Heat;
                return _phase;
                
            default:
                // end phase
                _phase = Phase.Initiative;
                return _phase;

        }
    }
    public void StartGame()
    {
        if(_isGameStarted)
        {
            throw new GameAlreadyStartedException("The game has already started.");
        }


        if (Players.Count == 0)
        {
            throw new NoPlayersException("No players have been added to the game.");
        }
        
        foreach(Player player in Players)
        { 
            if(player.Units.Count == 0)
            {
                throw new NoUnitsException("No units have been added for the players.");
            }
        }
        _round = 1;
        _isGameStarted = true;
        
    }
}

public class NoPlayersException : Exception  
{
    public NoPlayersException() 
    {
    }

    public NoPlayersException(string message) : base(message)
    {
    }
}

public class NoUnitsException : Exception
{
    public NoUnitsException()
    {
    }

    public NoUnitsException(string message) : base(message)
    {
    }
}

public class GameAlreadyStartedException : Exception
{
    public GameAlreadyStartedException()
    {
    }

    public GameAlreadyStartedException(string message) : base(message)
    {
    }
}