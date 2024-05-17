namespace Calculator;

public static class DiscountService
{
    public static decimal CalculateWithDiscount(decimal price)
    {
        var discount = price switch
        {
            < 1000 => 0,
            < 5000 => 3,
            < 7000 => 5,
            < 10000 => 7,
            < 15000 => 10,
            > 15000 => 15,
            _ => 0
        };

        return discount > 0 ? price * (1 - (decimal)discount / 100) : price;
    }
}