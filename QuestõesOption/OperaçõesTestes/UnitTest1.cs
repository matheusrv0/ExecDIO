using questoes;
using Xunit;    

namespace OperaçõesTestes
{
    public class OperacoesTestes
    {
        [Fact]
        public void CalcularAreaRetangulo_DeveRetornarAreaCorreta()
        {
            // Arrange
            double baseR = 5;
            double alturaR = 4;

            // Act
            double resultado = Operacoes.CalcularAreaRetangulo(baseR, alturaR);

            // Assert
            Assert.Equal(20, resultado);
        }
    }
 }  
