namespace Calculator;

public static class TotalCalculator
{
    public static decimal Calculate(int count, decimal pricePerUnit)
        => pricePerUnit * count;
}