namespace Calculator.Tests;

[TestClass]
public sealed class TaxServiceTests
{
    [TestMethod]
    [DataRow(1000, States.CA, 1082.5)]
    public void AddTax(double price, States state, double expected)
    {
        // Act
        var taxedPrice = TaxService.AddTax((decimal)price, state);

        // Assert
        Assert.AreEqual((decimal)expected, taxedPrice);
    }
}