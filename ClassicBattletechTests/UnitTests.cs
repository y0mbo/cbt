using ClassicBattletech;

namespace ClassicBattletechTests;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void Add_Unit_to_Player()
    {
        Game game = new Game("Test");
        game.AddPlayer();
        Player player = game.Players[0];

        Assert.AreEqual(0, player.Units.Count());
     }
}