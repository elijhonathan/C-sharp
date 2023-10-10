using C_.Models;

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal!");
        break;

    default:
        Console.WriteLine("É uma consoante!");
        break;
}
