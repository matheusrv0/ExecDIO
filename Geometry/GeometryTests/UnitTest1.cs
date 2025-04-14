using Xunit;
using Geometry;

namespace GeometryTests
{
    public class CalculoFigurasTests
    {
        [Fact]
        public void CalcularAreaTriangulo_DeveRetornarResultadoCorreto1()
        {
            //arrange(preparação)
            double baseT = 10;
            double alturaT = 5;
            double resultadoEsperado = 25;

            //act(execução)
            double resultado = CalculoFiguras.CalcularAreaTriangulo(baseT, alturaT);

            //assert(afirmação)
            Assert.Equal(resultadoEsperado, resultado);

        }
    }
}
