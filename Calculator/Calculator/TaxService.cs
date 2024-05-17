namespace Calculator;

public static class TaxService
{
    public static Decimal AddTax(decimal price, States state)
    {
        var percent = state switch
        {
            States.UT => 6.85,
            States.NV => 8,
            States.TX => 6.25,
            States.AL => 4,
            States.CA => 8.25,
            _ => throw new ArgumentException("Not valid state provided.")
        };

        var taxedPrice = Math.Round((double)price * (1 + percent / 100), 2);

        return (decimal)taxedPrice;
    }
}