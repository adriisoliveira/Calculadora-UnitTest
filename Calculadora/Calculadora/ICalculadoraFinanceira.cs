namespace Calculadora.Unit.Tests
{
    public interface ICalculadoraFinanceira
    {
        int AdicionaJuros(int num1, int num2, int porcentagem);
        int TiraJuros(int num1, int num2, int porcentagem);

    }
}