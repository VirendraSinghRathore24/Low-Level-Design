public class Dice
{
    private int size;
    public Dice(int size)
    {
        this.size = size;
    }

    public int RollDice()
    {
        Random random = new Random();
        return random.Next(1, size);  
    }
}