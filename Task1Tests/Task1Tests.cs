using Calculators;

namespace Task1Tests;

public class Task1Tests
{
    [Test]
    public void AdditionTest()
    {
        var calculator = new BasicCalculator();
        var result = calculator.Enter(2).Plus(2).Equals();
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void SubtractionTest()
    {
        var calculator = new BasicCalculator();
        var result = calculator.Enter(3).Minus(2).Equals();
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void MultiplyTest()
    {
        var calculator = new BasicCalculator();
        var result = calculator.Enter(4).Multiply(4).Equals();
        Assert.That(result, Is.EqualTo(16));
    }

    [Test]
    public void DivideTest()
    {
        var calculator = new BasicCalculator();
        var result = calculator.Enter(6).Divide(3).Equals();
        Assert.That(result, Is.EqualTo(2));
    }
}