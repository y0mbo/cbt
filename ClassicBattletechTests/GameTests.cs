using ClassicBattletech;

namespace ClassicBattletechTests;

[TestClass]
public class GameTests
{
    [TestMethod]
    public void TestGameConstructor()
    {
        // arrange
        string gameName = "This is my game";

        // act
        Game game = new Game(gameName);

        // assert
        Assert.AreEqual(gameName, game.Name);
    }

    [TestMethod]
    public void TestGameStringTrimming()
    {
        string gameName = " Starts with a space";
        Game game = new Game(gameName);
        Assert.AreEqual(gameName.Trim(), game.Name);

        gameName = "Ends with a space ";
        game = new Game(gameName);
        Assert.AreEqual(gameName.Trim(), game.Name);
    }
}