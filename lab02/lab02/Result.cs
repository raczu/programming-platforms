namespace lab02;

public class Result
{
    public int TotalValue { get; private set; }
    public int TotalWeight { get; private set; }
    public List<Item> Items { get; private set; }

    public Result(List<Item> items)
    {
        var totalValue = 0;
        var totalWeight = 0;
        foreach (var itm in items)
        {
            totalValue += itm.Value;
            totalWeight += itm.Weight;
        }

        TotalValue = totalValue;
        TotalWeight = totalWeight;
        Items = items;
    }

    public override string ToString()
    {
        var itemsString = string.Join(", ", Items);
        return $"Result(totalValue={TotalValue}, totalWeight={TotalWeight}, items=[{itemsString}])";
    }
}