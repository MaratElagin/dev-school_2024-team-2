namespace Calculator;

public static class DiscountService
{
    public static decimal CalculateWithDiscount(decimal price)
    {
        int discount = 0;
        if (price < 1000)
        {
            discount = 0;
        }
        else if (price < 5000)
        {
            discount = 3;
        }
        else if (price < 7000)
        {
            discount = 5;
        }
        else if (price < 10000)
        {
            discount = 7;
        }
        else if (price < 15000)
        {
            discount = 10;
        }
        else if (price > 15000)
        {
            discount = 15;
        }

        return discount > 0 ? price * (1 - (decimal)discount / 100) : price;

    }
}