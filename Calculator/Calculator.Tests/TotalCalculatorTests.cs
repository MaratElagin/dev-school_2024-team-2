namespace Calculator.Tests;

[TestClass]
public class TotalCalculatorTests
{
    [TestMethod]
    [DataRow(100, 2, 200)]
    [DataRow(10, 2.5, 25)]
    public void TestMethod1(int count, double pricePerUnit, double expected)
    {
        var total = TotalCalculator.Calculate(count, (decimal)pricePerUnit);
        Assert.AreEqual((decimal)expected, (decimal)total);
    }
}