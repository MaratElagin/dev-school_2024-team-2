namespace Calculator;

public static class Validator
{
    public static bool ValidateState(string input, out string message)
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
}