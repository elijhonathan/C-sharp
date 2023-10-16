using ExemplosExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 1582.40m;

Console.WriteLine($"{valorMonetario:C}");



