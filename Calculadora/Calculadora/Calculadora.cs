using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculadora.Unit.Tests;

namespace Calculadora
{
    public class Calculadora 
    
    {
        public ICalculadoraFinanceira _calculadoraFinanceira;
        public int Soma(int num1, int num2)
        {
        return num1 + num2;
        }

        public int Subtracao(int num1, int num2)
        {
        return num1 - num2;
        }

        public int Divisao(int num1, int num2)
        {
        return num1 / num2;
        }

        public int Multiplicacao(int num1, int num2)
        {
        return num1 * num2;
        }
    }

}
