using NUnit.Framework;
using lab02;

namespace UnitTests;

public class ItemTests
{
    [Test]
    public void Ratio_ReturnsCorrectRatio()
    {
        var item = new Item(1, 10, 2);
        var ratio = item.Ratio();
        Assert.That(ratio, Is.EqualTo(5));
    }
}