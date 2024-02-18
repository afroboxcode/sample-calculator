namespace unitTests;
using calculator;

public class CalculatorTests
{
    [Fact]
    public void Test1()
    {
        var calculator = new Calculator();
        var resultado = calculator.Soma(1, 2);
        Assert.Equal(3, resultado);
    }
}