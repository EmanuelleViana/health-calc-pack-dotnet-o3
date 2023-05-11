using health_calc_pack_dotnet_o3.Constants;
using health_calc_pack_dotnet_o3.Interfaces;

namespace health_calc_pack_dotnet_o3
{
    public class IMC : IIMC
    {
        /*
         *  IMC = PESO / (ALTURA * ALTURA)
         */
        public double Calc(double height, double weight)
        {
            if (!IsValidData(height, weight))
                throw new Exception("Peso e/ou altura inválidos.");

            double imc = weight / Math.Pow(height, 2);
            return Math.Round(imc, 2);
        }

        /*
         * 
         * IMC	               CLASSIFICAÇÃO	OBESIDADE (GRAU)
         * MENOR QUE 18,5	    MAGREZA	            0
         * ENTRE 18,5 E 24,9	NORMAL	            0
         * ENTRE 25,0 E 29,9	SOBREPESO	        I
         * ENTRE 30,0 E 39,9	OBESIDADE	        II
         * MAIOR QUE 40,0	    OBESIDADE GRAVE	    III
         */ 
        public string GetIMCCategory(double IMC)
        {
            if (IMC < 18.5)
                return IMCClassification.Magreza;
            else if (IMC >= 18.5 && IMC < 25)
                return IMCClassification.Normal;
            else if (IMC >= 25 && IMC < 30)
                return IMCClassification.Sobrepeso;
            else if (IMC >= 30 && IMC < 40)
                return IMCClassification.Obesidade;
            else if (IMC >= 40)
                return IMCClassification.ObesidadeGrave;

            return string.Empty;
        }

        /*
         * Verificar se altura e peso sao validos.
         */
        public bool IsValidData(double height, double weight)
        {
            return (height > 0 && weight > 0);
        }
    }
}