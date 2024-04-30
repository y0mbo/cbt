using AssaultSimulator;

namespace AssaultSimulatorTests;

[TestClass]
public class RoundTests
{
    private Game game = new Game();
    
    [TestInitialize]
    public void TestInitialize() 
    {
        this.game = new Game(); 
        this.game.AddPlayer();
        Player player1 = this.game.Players[0];
        BattleMech mech1 = new BattleMech("1", 1);
        player1.Units.Add(mech1);
        this.game.AddPlayer();
        Player player2 = this.game.Players[1];
        BattleMech mech2 = new BattleMech("2", 2);
        player2.Units.Add(mech2);
    }

    [TestCleanup]
    public void RoundTestCleanup() { }

    [TestMethod]
    public void Start_Game_Sets_First_Round()
    {
        Assert.AreEqual(2, this.game.Players.Count);
        Assert.AreEqual(0, this.game.Round);
        this.game.StartGame();
        Assert.AreEqual(1, this.game.Round);
        Assert.AreEqual(Phase.Initiative, this.game.Phase);
    }

    [TestMethod]
    public void Initiative_Phase_Moves_To_Movement_Phase()
    {
        this.game.StartGame();
        Assert.AreEqual(Phase.Initiative, this.game.Phase);
        this.game.NextPhase();
        Assert.AreEqual(Phase.Movement, this.game.Phase);   
    }
}
