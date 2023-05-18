using health_calc_pack_dotnet_o3.Enums;
using health_calc_pack_dotnet_o3.Interfaces;
using health_calc_pack_dotnet_o3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet_o3
{
    public class Macronutrientes : IMacronutrientes
    {
        public MacronutrientesModel CalcularMacronutrientes(ObjetivoFisicoEnum objetivoFisicoEnum, double Peso)
        {

            if(ObjetivoFisicoEnum.PerdaPeso == objetivoFisicoEnum)
            {
                return new MacronutrientesModel()
                {
                    Carboidratos = 3.0 * Peso,
                    Proteinas = 4.0 * Peso,
                    Gorduras = 3.0 * Peso,
                };
            }
            else if (ObjetivoFisicoEnum.ManterPeso == objetivoFisicoEnum)
            {
                return new MacronutrientesModel()
                {
                    Carboidratos = 4.0 * Peso,
                    Proteinas = 4.0 * Peso,
                    Gorduras = 2.0 * Peso,
                };
            }

          //  else if (ObjetivoFisicoEnum.GanhoMassa == objetivoFisicoEnum)
          //  {
                return new MacronutrientesModel()
                {
                    Carboidratos = 4.0 * Peso,
                    Proteinas = 2.0 * Peso,
                    Gorduras = 1.0 * Peso,
                };
          //  }           
          
            // return new MacronutrientesModel() { };
            
        }
    }
}
