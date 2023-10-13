using C_.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("MT");
listaString.Add("MS");
listaString.Add("PR");
listaString.Add("SP");

Console.WriteLine("Percorrendo a lista com FOR:");
for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}


Console.WriteLine("Percorrendo a lista com o FOREACH:");
int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {item}");
    contadorForeach++;
}




// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Eli";
// pessoa1.Idade = 29;
// pessoa1.Apresentar();











