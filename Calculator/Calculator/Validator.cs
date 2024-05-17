using System.Globalization;

namespace Calculator;

public static class Validator
{
    public static bool ValidateState(string? input, out string message)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            message = "Укажите штат";
            return false;
        }
        
        if (Enum.TryParse(input, out States _))
        {
            message = "";
            return true;
        }

        message = "Неизвестный штат";
        return false;
    }
    
    public static bool ValidatePrice(string? input, out string message)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            message = "Укажите стоимость";
            return false;
        }

        if (input.Contains(",") && input.Split(',')[1].Length > 2)
        {
            message = "Стоимость не должна иметь больше 2 знаков после запятой.";
            return false;
        }

        if (!decimal.TryParse(input, out var price))
        {
            message = "Некорректная стоимость";
            return false;
        }
        
        if (price < 0)
        {
            message = "Стоимость меньше нуля";
            return false;
        }

        message = "";
        return true;
    }
}