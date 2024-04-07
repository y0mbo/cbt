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

   
}