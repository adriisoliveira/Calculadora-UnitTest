using Moq;
using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraFinanceira
{
    public class CalculadoraFinanceira
    {
        public ICalculadoraFinanceira _calculadoraFinanceira;
       
        Calculadora.Calculadora _calculadora = new Calculadora.Calculadora();


        public int Soma(int num1, int num2)
        {
            return _calculadoraFinanceira.AdicionaJuros(num1, num2, 10);
        }

        public int Subtracao(int num1, int num2)
        {
            return _calculadoraFinanceira.AdicionaJuros(num1, num2, 10);
        }

        public int Divisao(int num1, int num2)
        {
            return _calculadoraFinanceira.AdicionaJuros(num1, num2, 10);
        }

        public int Multiplicacao(int num1, int num2)
        {
            return _calculadoraFinanceira.AdicionaJuros(num1, num2, 10);
        }
	}
}
