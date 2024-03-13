using lab02;
using NUnit.Framework;

namespace UnitTests;

public class ProblemTests
{
    [Test]
    public void Constructor_WhenNumberOfItemsIsNegative_ThrowsArgumentException()
    {
        Assert.That(() => new Problem(-1, 1), Throws.ArgumentException);
    }
    
    [Test]
    public void Constructor_GeneratesWantedNumberOfItems()
    {
        var sizes = new List<int> { 1, 10, 100, 1000 };
        foreach (var size in sizes)
        {
            var problem = new Problem(size, 1);
            Assert.That(problem.Items, Has.Count.EqualTo(size));
        }
            
    }
    
    [Test]
    public void Solve_WhenCapacityIsNegative_ThrowsArgumentException()
    {
        var problem = new Problem(10, 1);
        Assert.That(() => problem.Solve(-1), Throws.ArgumentException);
    }

    [Test]
    public void Solve_WhenNoItems_ReturnsEmptyResult()
    {
        var problem = new Problem(0, 1);
        var result = problem.Solve(10);
        Assert.That(result.Items, Is.Empty);
    }

    [Test]
    public void Solve_WhenCapacityIsZero_ReturnsEmptyResult()
    {
        var problem = new Problem(10, 1);
        var result = problem.Solve(0);
        Assert.That(result.Items, Is.Empty);
    }
    
    [Test]
    public void Solve_WhenItemsAndCapacity_ReturnsResult()
    {
        var problem = new Problem(10, 1);
        var result = problem.Solve(10);
        Assert.That(result.Items, Has.Count.GreaterThanOrEqualTo(1));
    }

    [Test]
    public void Solve_ReturnsCorrectResult()
    {
        var items = new List<Item>
        {
            new Item(0, 4, 12),
            new Item(1, 2, 1),
            new Item(2, 1, 1),
            new Item(3, 2, 2),
            new Item(4, 10, 4)
        };
        var problem = new Problem(items);
        var result = problem.Solve(15);
        
        var expected = items.Where(item => item.Number != 0).ToList();
        CollectionAssert.AreEquivalent(expected, result.Items);
        Assert.That(result.TotalValue, Is.EqualTo(15));
        Assert.That(result.TotalWeight, Is.EqualTo(8));
    }
    
    [Test]
    public void Solve_WhenSameItemsOrderIsDifferent_ReturnsSameResult()
    {
        var problem01 = new Problem(10, 10);
        var shuffledItems = problem01.Items.OrderBy(_ => Guid.NewGuid()).ToList();
        var problem02 = new Problem(shuffledItems);
        
        var result1 = problem01.Solve(15);
        var result2 = problem02.Solve(15);
        CollectionAssert.AreEquivalent(result1.Items, result2.Items);
        Assert.That(result1.TotalValue, Is.EqualTo(result2.TotalValue));
        Assert.That(result1.TotalWeight, Is.EqualTo(result2.TotalWeight));
    }

    [Test]
    public void Solve_WhenCapacityIsExactlyWeightOfOneItem_ReturnsThatItem()
    {
        var items = new List<Item>
        {
            new Item(0, 10, 1),
            new Item(1, 5, 5),
            new Item(2, 1, 10)
        };
        var problem = new Problem(items);
        var result = problem.Solve(1);
        Assert.That(result.Items, Has.Count.EqualTo(1));
        Assert.That(result.Items[0], Is.EqualTo(items[0]));
    }
    
    [Test]
    public void Solve_WhenCapacityIsMoreThanTotalWeight_ReturnsAllItems()
    {
        var items = new List<Item>
        {
            new Item(0, 10, 1),
            new Item(1, 20, 5),
            new Item(2, 15, 10)
        };
        var problem = new Problem(items);
        var result = problem.Solve(100);
        CollectionAssert.AreEquivalent(items, result.Items);
    }
}