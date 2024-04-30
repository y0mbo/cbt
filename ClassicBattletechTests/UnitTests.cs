using AssaultSimulator;

namespace AssaultSimulatorTests;

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
        BattleMech mech1 = new BattleMech("1", 1);

        player.Units.Add(mech1);
     }
}