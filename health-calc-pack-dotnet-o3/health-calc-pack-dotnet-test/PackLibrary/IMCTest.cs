using health_calc_pack_dotnet_o3;
using health_calc_pack_dotnet_o3.Constants;
using health_calc_pack_dotnet_o3.Interfaces;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class IMCTest
    {
        [Fact]
        public void CalculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
        {

            IIMC imc = new IMC();
            double height = 1.60;
            double weight = 50;
            double expectedIMC = 19.53;

            var result = imc.Calc(height, weight);

            Assert.Equal(expectedIMC, result);

        }

        [Fact]
        public void CalculaIMC_QuandoDadosInvalidos_EntaoRetornaExcecao()
        {

            IIMC imc = new IMC();
            double height = 0;
            double weight = 0;

            var exception = Assert.Throws<Exception>(() => imc.Calc(height, weight));
            Assert.Equal("Peso e/ou altura inválidos.", exception.Message);
        }

        [Fact]
        public void ValidaDadosIMC_QuandoDadosInvalidos_EntaoRetornaFalso()
        {

            IIMC imc = new IMC();
            double height = 10;
            double weight = 400;

            bool result = imc.IsValidData(height, weight);

            Assert.False(result);

        }
        [Theory]
        [InlineData(0, "")]
        [InlineData(17.5, IMCClassification.Magreza)]
        [InlineData(18.49, IMCClassification.Magreza)]
        [InlineData(18.5, IMCClassification.Normal)]
        [InlineData(24, IMCClassification.Normal)]
        [InlineData(19, IMCClassification.Normal)]
        [InlineData(29, IMCClassification.Sobrepeso)]
        [InlineData(25, IMCClassification.Sobrepeso)]
        [InlineData(30, IMCClassification.Obesidade)]
        [InlineData(39, IMCClassification.Obesidade)]
        [InlineData(40, IMCClassification.ObesidadeGrave)]
        [InlineData(46, IMCClassification.ObesidadeGrave)]
        public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaCategoria(double imcValue, string expected)
        {
            IIMC imc = new IMC();
            var result = imc.GetIMCCategory(imcValue);

            Assert.Equal(expected, result);
        }
  

    }
}