namespace ClassicBattletech;

public class Game
{
    public string Name { get; }
    public DateTime CreatedDate { get; }

    public Game(string name)    
    {
        Name = name.Trim();
        CreatedDate = DateTime.Now;
    }
}
