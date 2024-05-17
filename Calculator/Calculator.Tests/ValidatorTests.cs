namespace Calculator.Tests;

[TestClass]
public class ValidatorTests
{
    [TestMethod]
    [DataRow("111", "")]
    [DataRow("", "Укажите стоимость")]
    [DataRow("qqqqqq", "Некорректная стоимость")]
    [DataRow("-1", "Стоимость меньше нуля")]
    public void TestMethod1(string price, string expected)
    {
        Validator.ValidatePrice(price, out string message);
        Assert.AreEqual(expected, message);
    }
}