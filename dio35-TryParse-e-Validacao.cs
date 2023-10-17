using ExemplosExplorando.Models;
using System.Globalization;

string dataString = "2022-04-17 18:00";

string dataString2 = "2022-13-33 25:63";

bool sucesso = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime data);


if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}

else
{
    Console.WriteLine($"{dataString} não é um formato de data válido!");
}


bool sucesso2 = DateTime.TryParseExact(dataString2,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime data2);

if (sucesso2)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data2}");
}

else
{
    Console.WriteLine($"{dataString2} não é um formato de data válido!");
}










