using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculadoraFinanceira;
using Moq;

namespace Calculadora.Financeira.Unit.Tests
{
    [TestFixture]
    public class CalculadoraFinanceiraUnitTests
    {
        private Mock<ICalculadoraFinanceira> _calculadoraFinanceiraMock = new Mock<ICalculadoraFinanceira>(MockBehavior.Strict);
        private Calculadora _calculadora = new Calculadora() { _calculadoraFinanceira = _calculadoraFinanceiraMock.Object };

    }
}
