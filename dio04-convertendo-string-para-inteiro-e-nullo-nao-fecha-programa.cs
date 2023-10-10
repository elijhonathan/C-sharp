using C_.Models;

string a = "";
Console.WriteLine("Digite um numéro: ");
a = Console.ReadLine();

 int b = 0;

 int.TryParse(a, out b);


 Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso");
