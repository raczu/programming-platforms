using lab02;

namespace UnitTests;

public class ResultTests
{
    [Test]
    public void Constructor_WhenEmptyItems_SetsTotalValueAndTotalWeightToZero()
    {
        var result = new Result([]);
        Assert.That(result.TotalValue, Is.EqualTo(0));
        Assert.That(result.TotalWeight, Is.EqualTo(0));
    }

    [Test]
    public void Constructor_ReturnsCorrectTotalValueAndTotalWeight()
    {
        var items = new List<Item>
        {
            new Item(1, 10, 2),
            new Item(2, 20, 3),
            new Item(3, 30, 4)
        };
        var result = new Result(items);
        Assert.That(result.TotalValue, Is.EqualTo(60));
        Assert.That(result.TotalWeight, Is.EqualTo(9));
    }
}