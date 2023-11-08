using Calculator.Services;

namespace CalculatorTests;

public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void Sum(int num1, int num2, int result)
    {
        CalculatorImp calc = new CalculatorImp();

        int resultcalc = calc.Sum(num1, num2);

        Assert.Equal(result, resultcalc);

    }

    [Theory]
    [InlineData (7, 6, 1)]
    [InlineData (5, 5, 0)]
    public void Sub(int num1, int num2, int result)
    {
        CalculatorImp calc = new CalculatorImp();

        int resultcalc = calc.Sub(num1, num2);

        Assert.Equal(result, resultcalc);

    }

    [Theory]
    [InlineData (6, 3, 2)]
    [InlineData (5, 5, 1)]
    public void Div(int num1, int num2, int result)
    {
        CalculatorImp calc = new CalculatorImp();

        int resultcalc = calc.Div(num1, num2);

        Assert.Equal(result, resultcalc);

    }

    [Fact]
    public void DivideByZeroException()
    {
        CalculatorImp calc = new CalculatorImp();

        Assert.Throws<DivideByZeroException>(
            () => calc.Div(3,0)
        );
    }
    
    [Theory]
    [InlineData (2, 2, 4)]
    [InlineData (7, 1, 7)]
    public void Multi(int num1, int num2, int result)
    {
        CalculatorImp calc = new CalculatorImp();

        int resultcalc = calc.Multi(num1, num2);

        Assert.Equal(result, resultcalc);

    }
    
}