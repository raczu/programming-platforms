namespace lab02;

public class Item(int number, int value, int weight)
{
    public int Number { get; private set; } = number;
    public int Value { get; private set; } = value;
    public int Weight { get; private set; } = weight;
    public double Ratio() => (double)Value / Weight;

    public override string ToString()
    {
        return $"Item(n={Number}, value={Value}, weight={Weight})";
    }
}