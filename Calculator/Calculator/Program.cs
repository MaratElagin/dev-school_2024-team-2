// See https://aka.ms/new-console-template for more information

using Calculator;

Console.WriteLine("Цена за единицу:");
var pricePerUnit = decimal.Parse(Console.ReadLine());

Console.WriteLine("Количество:");
var count = int.Parse(Console.ReadLine());


States state;
while (true)
{
    Console.WriteLine("Штат: ");
    var input = Console.ReadLine();
    if (!Validator.ValidateState(input, out var message))
    {
        Console.WriteLine(message);
        continue;
    }
    state = (States)Enum.Parse(typeof(States), input);
    break;
}


var total = TotalCalculator.Calculate(count, pricePerUnit);

var totalWithDiscount = DiscountService.CalculateWithDiscount(total);

var totalWithTax = TaxService.AddTax(totalWithDiscount, state);

Console.WriteLine($"Итого: {totalWithTax} USD");