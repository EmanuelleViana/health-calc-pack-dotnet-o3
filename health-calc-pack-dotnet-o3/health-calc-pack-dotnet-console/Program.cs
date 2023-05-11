using health_calc_pack_dotnet_o3;

var imc = new IMC();

var height = 1.60;
var weight = 50;
var result = imc.Calc(height, weight);

var classification = imc.GetIMCCategory(result);

Console.WriteLine($"O valor do seu IMC é: {result} e a classificação é: {classification} [PESO]: {weight} [ALTURA]:");