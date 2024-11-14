using ComandaApp.Services;
using Xunit;

namespace ComandaApp.Tests
{
    public class ComandaImpTests
    {
        [Fact]
        public void TestCriarComanda()
        {
            // Arrange: Criar uma comanda com número 1
            var comanda = new ComandaImp(1, false, 0m);

            // Act: Ação de criação já feita no Arrange, sem ação adicional necessária

            // Assert: Validar os valores iniciais da comanda
            Assert.Equal(1, comanda.Numero); // O número da comanda deve ser 1
            Assert.False(comanda.EstaFechada); // A comanda deve estar aberta inicialmente
            Assert.Equal(0m, comanda.ValorTotal); // O valor da comanda deve ser 0 inicialmente
        }

        [Fact]
        public void TestFecharComanda()
        {
            // Arrange: Criar uma comanda e fechá-la com um valor
            var comanda = new ComandaImp(1, false, 0m);

            // Act: Fechar a comanda com o valor 150.75
            comanda.FecharComanda(150.75m); // Fechar com o valor de 150.75

            // Assert: Verificar se a comanda foi fechada corretamente
            Assert.True(comanda.EstaFechada); // A comanda deve estar fechada
            Assert.Equal(150.75m, comanda.ValorTotal); // O valor total deve ser 150.75
        }

        [Fact]
        public void TestAbrirComanda()
        {
            var comanda = new ComandaImp(1, true, 200.0m);

            comanda.AbrirComanda(); 

            Assert.False(comanda.EstaFechada);
            Assert.Equal(0m, comanda.ValorTotal);
        }
    }
}
