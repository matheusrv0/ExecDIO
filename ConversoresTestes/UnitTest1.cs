using Conversion;

namespace ConversoresTestes
{
    public class ConversoresTestes
    {
        [Fact]
        public void cParaF_DeveConverter0CelsiusPara32Fahrenheit()
        {
            // Arrange
            double celsius = 0;
            double esperado = 32;

            // Act
            double resultado = Conversores.cParaF(celsius);

            // Assert
            Assert.Equal(esperado, resultado, 2);
        }
        [Fact]
        public void CParaK_DeveConverterZeroCelsiusPara273_15Kelvin()
        {
            // Arrange
            double celsius = 0;
            double esperado = 273.15;

            // Act
            double resultado = Conversores.CParaK(celsius);

            // Assert
            Assert.Equal(esperado, resultado, 2);

        }
    }
}
