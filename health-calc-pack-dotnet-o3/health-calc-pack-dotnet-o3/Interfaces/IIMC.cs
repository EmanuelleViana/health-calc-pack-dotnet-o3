using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet_o3.Interfaces
{
    public interface IIMC
    {
        double Calc(Double height, Double weight);
        string GetIMCCategory(double IMC);
        bool IsValidData(double height, double weight);
    }
}
