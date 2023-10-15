namespace CalculadoraTeste;
using Calculadora.Services;
public class CalculadoraTeste
{  
    Calculadora newCalc = new();

    [Theory]
    [InlineData(20, 10, 10)]
    [InlineData(10, 5, 5)]
    [InlineData(2, 1, 1)]
    [InlineData(50, 30, 20)]
    [InlineData(60, 10, 50)]

    public void TestSoma(int soma, int n1, int n2)
    {

        int res = newCalc.Soma(n1, n2);

        Assert.Equal(soma, res);

    }

    [Fact]
    public void TestHistorico()
    {
        newCalc.Soma(1, 2);
        newCalc.Soma(2, 5);
        newCalc.Soma(10, 2);
        newCalc.Soma(8, 4);
             
        Assert.NotEmpty(newCalc.historicoTresUltimasOperacoes());
        Assert.Equal(3, newCalc.historicoTresUltimasOperacoes().Count);
    } 
    
}