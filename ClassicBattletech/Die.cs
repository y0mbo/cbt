namespace AssaultSimulator;

public interface IDie
{
     int Roll();
}

public class Die : IDie
{
    public int Sides { get; }

    private Random random;

    public Die() : this (6)
    {

    }
        
    public Die(int sides)
    {
        Sides = sides;
        random = new Random();
    }

    public int Roll()
    {
        return random.Next(1, Sides + 1);
    }

    public int Roll2D6()
    {
        return Roll() + Roll();
    }
}
