using AssaultSimulator;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace AssaultSimulatorTests;

[TestClass]
public class GameTests
{
    [TestMethod]
    public void Test_GameConstructor()
    {
        // arrange
        string gameName = "This is my game";

        // act
        Game game = new Game(gameName);

        // assert
        Assert.AreEqual(gameName, game.Name);
        Assert.AreEqual(0, game.Round);
    }

    [TestMethod]
    public void Test_Game_StringTrimming()
    {
        string gameName = " Starts with a space";
        Game game = new Game(gameName);
        Assert.AreEqual(gameName.Trim(), game.Name);

        gameName = "Ends with a space ";
        game = new Game(gameName);
        Assert.AreEqual(gameName.Trim(), game.Name);
    }

    [TestMethod]
    [ExpectedException(typeof(NoPlayersException), "No players have been added to the game.")]
    public void Start_New_Game_Without_Players()
    {
        Game game = new Game("");
        game.StartGame();       
    }

    [TestMethod]
    [ExpectedException(typeof(NoUnitsException), "No units have been added to the game.")]
    public void Start_New_Game_Without_Units()
    {
        Game game = new Game("");
        game.AddPlayer();
        game.AddPlayer();

        game.StartGame();
    }

    [TestMethod]
    public void Start_New_Game_No_Round()
    {
        Game game = new Game();
        game.AddPlayer();
        game.AddPlayer();

        Assert.AreEqual(0, game.Round);
        
    }

    [TestMethod]
    [ExpectedException(typeof(GameAlreadyStartedException), "The game has already started.")]
    public void Game_Cannot_Be_Started_More_Than_Once()
    {
        Game game = new Game();
        game.AddPlayer();
        game.AddPlayer();
        Player p1 = game.Players[0];

        BattleMech mech1 = new BattleMech("1", 1);
        p1.Units.Add(mech1);

        Player p2 = game.Players[1];
        p2.Units.Add(mech1);

        game.StartGame();
        game.StartGame();

         
    }
}