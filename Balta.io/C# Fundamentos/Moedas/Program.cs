// See https://aka.ms/new-console-template for more information

using System.IO;
using System.Globalization;

Console.Clear();

var valorDecimal = 10.510m;
var valor = 10.25;

var cultura = new CultureInfo("krw-ko");

var dataAtual = DateTime.Now;

Console.WriteLine("O valor na moeda escolhida é : {0:C}, a moeda escolhida é a pt-BR", valorDecimal);

Console.WriteLine("hora atual: " + dataAtual.ToUniversalTime());

Console.WriteLine(string.Format("Hoe é dia {0}, a hora atual é: {1:hh:mm:ss}", dataAtual.Date.Day, dataAtual));
Console.WriteLine(string.Format("Hoje é {0:D}", dataAtual));
Console.WriteLine(string.Format("A data atual é: {0:dd/MM/yyyy}", dataAtual));
Console.WriteLine(dataAtual.ToString("D", cultura));

Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-us")));
Console.WriteLine(valorDecimal.ToString("C", CultureInfo.CreateSpecificCulture("en-UK")));
Console.WriteLine(valorDecimal.ToString("C", CultureInfo.CreateSpecificCulture("es-es")));
Console.WriteLine(valorDecimal.ToString("C", CultureInfo.CreateSpecificCulture("jp-jp")));
Console.WriteLine(valorDecimal.ToString("C", cultura));

Console.WriteLine(Math.Round(valorDecimal));        // arredonda de 0 - 5.0 pra baixo e de 5.1 - 9.999 pra cima
Console.WriteLine(Math.Floor(valorDecimal));        // arredonda pra baixo
Console.WriteLine(Math.Ceiling(valorDecimal));      //arredonda pra cima
