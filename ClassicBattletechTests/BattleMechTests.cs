using AssaultSimulator;

namespace AssaultSimulatorTests;

[TestClass]
public class BattleMechTests
{
    [TestMethod]
    public void Test_BattleMech_Constructor()
    {
        // arrange
        string mechName = "Phoenix Hawk";
        int battleValue = 12;

        // act
        BattleMech mech = new BattleMech(mechName, battleValue);    

        // assert
        Assert.AreEqual(mechName, mech.Name);
        Assert.AreEqual(battleValue, mech.BattleValue);
    }
}