namespace Domain;

public class Counters
{
   private int value;
   public Counters (int value)
    {
        this.value = value;
    } 
    public int Decrement()
    {
        if (value > 0)
        {
            return value--;
        }
        return 0;

    }
    public int Reset()
    {
        return value = 0;
    }
    public void PrintValue()
    {
        Console.WriteLine($"Value: {value}");
    }
}
