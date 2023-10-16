using ExemplosExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 1582.40m;

Console.WriteLine($"{valorMonetario:C}");

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));



