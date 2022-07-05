using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace Calculadora.Unit.Tests.TestCases
{
    public class TestCases
    {

        private Calculadora _calculadora = new Calculadora();

        [TestCase(3,8)]
        [TestCase(1, 10)]
        [TestCase(4, 7)]
        public void Soma_WhenValoresInteiros_ShouldSomar(int num1, int num2)
        {
            //Arrange

            //Act
            var response = _calculadora.Soma(num1, num2);

            //Assert
            response.Should().Be(11);
        }

        [TestCase(8, 3)]
        public void Subtracao_WhenValoresInteiros_ShouldSubtrair(int num1, int num2)
        {
            //Arrange

            //Act
            var response = _calculadora.Subtracao(num1, num2);

            //Assert
            response.Should().Be(5);
        }

        [TestCase(8, 4)]
        public void Divisao_WhenValoresInteiros_ShouldDividir(int num1, int num2)
        {
            //Arrange

            //Act
            var response = _calculadora.Divisao(num1, num2);

            //Assert
            response.Should().Be(2);
        }

        [TestCase(3, 8)]
        public void Multiplicacao_WhenValoresInteiros_ShouldMultiplicar(int num1, int num2)
        {
            //Arrange

            //Act
            var response = _calculadora.Multiplicacao(num1, num2);

            //Assert
            response.Should().Be(24);
        }





    }
}
