using health_calc_pack_dotnet_o3.Enums;
using health_calc_pack_dotnet_o3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet_o3.Interfaces
{
    public interface IMacronutrientes
    {
        MacronutrientesModel CalcularMacronutrientes(
            ObjetivoFisicoEnum objetivoFisicoEnum,
            double Peso           
            );

    }
}
