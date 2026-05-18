public class Player
{
    System.Random random = new();
    
    public int RollDie()
    {
        return random.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return random.NextDouble() * 100;
    }
}
