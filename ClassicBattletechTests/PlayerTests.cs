using AssaultSimulator;

namespace AssaultSimulatorTests;

[TestClass]
public class PlayerTests
{
    [TestMethod]
    public void Add_Player_to_Game_With_Player_Object()
    {
        string playerName = "Player 1";
        Game game = new Game("Test");
        Player player = new Player("Player 1");

        game.AddPlayer(player);

        Assert.AreEqual(playerName, game.Players[0].Name); 
    }

    [TestMethod]
    public void Add_Player_to_Game_with_Name()
    {
        string playerName = "Player 1";
        Game game = new Game("Test");

        game.AddPlayer(playerName);

        Assert.AreEqual(playerName, game.Players[0].Name);
    }
        
    [TestMethod]
    public void Add_Player_to_Game_without_Name()
    {
        Game game = new Game("Test");

        game.AddPlayer();
        game.AddPlayer();
 
        Assert.AreEqual("Player 1", game.Players[0].Name);
        Assert.AreEqual("Player 2", game.Players[1].Name); 
     }
}