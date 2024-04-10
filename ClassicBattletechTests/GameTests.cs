using ClassicBattletech;

namespace ClassicBattletechTests;

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
        Assert.AreEqual(1, game.Round);
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

}