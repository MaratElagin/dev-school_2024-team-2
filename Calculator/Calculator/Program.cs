// See https://aka.ms/new-console-template for more information

using Calculator;

Console.WriteLine("Цена за единицу:");
var pricePerUnit = decimal.Parse(Console.ReadLine());

Console.WriteLine("Количество:");
var count = int.Parse(Console.ReadLine());

var total = TotalCalculator.Calculate(count, pricePerUnit);

Console.WriteLine($"Итого: {total} USD");