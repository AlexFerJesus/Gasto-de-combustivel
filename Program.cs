using System.Globalization;

double H;
double Km;
double mult;
double L = 12;
double result;

Console.WriteLine("");
Console.WriteLine(@"Em um carro que gasta 12Km/L voce de saber 
quantos litros de gasolina é gasto após o 
tempo gasto de viagem(Horas) e a velocidade 
media durante a mesma(em Km/h).");
Console.WriteLine("");
Console.WriteLine(@"Agora em forma de calculo use as horas multiplicada pela 
distancia dividida pelo gasto de litos do carro");
Console.WriteLine("");
Console.WriteLine("Ou seja a (litragem gasta = horas * Km/h / Km/L)");
Console.WriteLine("");

Console.WriteLine("Coloque a quantidade de Horas gasta:");
H = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Agora coloque a velocidade media em Km/h:");
Km = Convert.ToDouble (Console.ReadLine());

mult = H * Km;

result = mult / L;

Console.WriteLine(result.ToString("F3"));
