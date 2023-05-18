using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using health_calc_pack_dotnet_o3;
using health_calc_pack_dotnet_o3.Constants;
using health_calc_pack_dotnet_o3.Enums;
using health_calc_pack_dotnet_o3.Interfaces;
using health_calc_pack_dotnet_o3.Models;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class MacronutrientesTest
    {
        // TODO: Verificar como usar Theory com Model
        // TODO: Renomear para Ingles
      /*  static IEnumerable<object[]> expectedmodel =>
        new List<object[]> {
            new object[]  { "Carboidratos", 355.20 },
            new object[]  { "Proteinas", 177.60 },
            new object[]  { "Gorduras", 88.80 },
        };*/


        [Theory]
        [InlineData(ObjetivoFisicoEnum.GanhoMassa, 355.2, 177.6, 88.8)]
        [InlineData(ObjetivoFisicoEnum.ManterPeso, 355.2, 355.2, 177.6)]
        [InlineData(ObjetivoFisicoEnum.PerdaPeso, 266.4, 355.2, 266.4)]

        public void CalculaMacronutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes(
            ObjetivoFisicoEnum objetivoFisico,
            double expectedCarboidrato, double expectedProteina, double expectedGordura)
        {

            IMacronutrientes macronutrientes = new Macronutrientes();
            double weight = 88.8;
            // var expected = new MacronutrientesModel();

            /*  if(objetivoFisico == ObjetivoFisicoEnum.PerdaPeso)
              {
                  expected.Carboidratos = 266.4;
                  expected.Proteinas = 355.2;
                  expected.Gorduras = 266.4;
              }
              else if (objetivoFisico == ObjetivoFisicoEnum.ManterPeso)
              {
                  expected.Carboidratos = 355.2; ;
                  expected.Proteinas = 355.2;
                  expected.Gorduras = 177.6;
              }
              else if (objetivoFisico == ObjetivoFisicoEnum.GanhoMassa)
              {
                  expected.Carboidratos = 355.2;
                  expected.Proteinas = 177.6;
                  expected.Gorduras = 88.8;
              }*/

            var result = macronutrientes.CalcularMacronutrientes(objetivoFisico,weight);

            // Assert.Equivalent(expected, result); //compare two objects
            
            Assert.Equal(expectedCarboidrato, result.Carboidratos); 
            Assert.Equal(expectedProteina, result.Proteinas);
            Assert.Equal(expectedGordura, result.Gorduras); 
        }
    }
}
