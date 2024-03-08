namespace Calculators;

public class BasicCalculator
{
    private decimal LastResult { get; set; }

    public BasicCalculator()
    {
        Reset();
    }

    public BasicCalculator Reset()
    {
        LastResult = 0.0M;
        return this;
    }

    public BasicCalculator Enter(decimal number)
    {
        LastResult = number;
        return this;
    }

    public BasicCalculator Plus(decimal number)
    {
        LastResult += number;
        return this;
    }

    public BasicCalculator Minus(decimal number)
    {
        LastResult -= number;
        return this;
    }

    public BasicCalculator Multiply(decimal number)
    {
        LastResult *= number;
        return this;
    }

    public BasicCalculator Divide(decimal number)
    {
        LastResult /= number;
        return this;
    }

    public decimal Equals()
    {
        return LastResult;
    }
}
