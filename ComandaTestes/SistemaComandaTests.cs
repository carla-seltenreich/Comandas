using ComandaApp.Services;
using Xunit;

namespace ComandaApp.Tests
{
    public class SistemaComandasTests
    {
        [Fact]
        public void TestContarComandasAbertas()
        {
            var sistema = new SistemaComandas();

            var abertas = sistema.ContarComandasAbertas();

            Assert.Equal(2, abertas);
        }

        [Fact]
        public void TestContarComandasFechadas()
        {
            var sistema = new SistemaComandas();

            var fechadas = sistema.ContarComandasFechadas();

            Assert.Equal(4, fechadas);
        }

        [Fact]
        public void TestObterComandaMaiorValor()
        {
            var sistema = new SistemaComandas();

            var comandaMaiorValor = sistema.ObterComandaMaiorValor();

            Assert.NotNull(comandaMaiorValor); 
            Assert.Equal(4, comandaMaiorValor.Numero);
            Assert.Equal(200.00m, comandaMaiorValor.ValorTotal);
        }
    }
}
