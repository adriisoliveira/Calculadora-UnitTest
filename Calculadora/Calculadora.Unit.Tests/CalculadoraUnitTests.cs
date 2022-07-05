using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Moq;

namespace Calculadora.Unit.Tests
{
    [TestFixture]
    public class CalculadoraUnitTests
    {
        public ICalculadoraFinanceira _calculadoraFinanceira;

        public Mock<ICalculadoraFinanceira> _calculadoraFinanceiraMock;

        public Calculadora _calculadora;

        [SetUp]
        public void Setup()
        {
            _calculadoraFinanceiraMock = new Mock<ICalculadoraFinanceira>(MockBehavior.Strict);
            _calculadora = new Calculadora { _calculadoraFinanceira = _calculadoraFinanceiraMock.Object };
        }

        [Test]
        public void Soma()
        {
            
            //Arrange
            _calculadoraFinanceiraMock.Setup(_ => _.AdicionaJuros(3, 8, 10)).Returns(30);

            //Act
            var response = _calculadora._calculadoraFinanceira.AdicionaJuros(3,8,10);

            //Assert
            _calculadoraFinanceiraMock.Verify(_ => _.AdicionaJuros(3, 8, 10), Times.Once);
        }

        [Test]
        public void Subtracao()
        {
            //Arrange
            _calculadoraFinanceiraMock.Setup(_ => _.AdicionaJuros(8, 3, 10)).Returns(30);

            //Act
            var response = _calculadora._calculadoraFinanceira.AdicionaJuros(8, 3, 10);

            //Assert
            _calculadoraFinanceiraMock.Verify(_ => _.AdicionaJuros(8, 3, 10), Times.Once);
        }

        [Test]
        public void Divisao()
        {
            //Arrange
            _calculadoraFinanceiraMock.Setup(_ => _.AdicionaJuros(8, 2, 10)).Returns(30);

            //Act
            var response = _calculadora._calculadoraFinanceira.AdicionaJuros(8, 2, 10);

            //Assert
            _calculadoraFinanceiraMock.Verify(_ => _.AdicionaJuros(8, 2, 10), Times.Once);
        }

        [Test]
        public void Multiplicacao()
        {
            //Arrange
            _calculadoraFinanceiraMock.Setup(_ => _.AdicionaJuros(3, 8, 10)).Returns(30);

            //Act
            var response = _calculadora._calculadoraFinanceira.AdicionaJuros(3, 8, 10);

            //Assert
            _calculadoraFinanceiraMock.Verify(_ => _.AdicionaJuros(3, 8, 10), Times.Once);
        }
    }
}
