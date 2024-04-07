namespace ClassicBattletech;

public class Game
{
    public string Name { get; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; }
    public int Round { get; }
    public List<Player> Players { get; }

    public Game(string name)    
    {
        Name = name.Trim();
        CreatedDate = DateTime.Now;
        Round = 1;
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
        Players.Add(new Player(name));
    }

}
