using ExemplosExplorando.Models;



DateTime data = DateTime.Now;

DateTime dataConvert = DateTime.Parse("17-05-1999 23:59");

Console.WriteLine(dataConvert);

Console.WriteLine(data);

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));

Console.WriteLine(data.ToString("HH:mm dd/MM/yy"));




