using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        
        double valorTotalCompras = double.Parse(Console.ReadLine());

        // TODO: Faça a verificação se o contato é um cliente ou lead
        string categoria;
        if ( valorTotalCompras >= 500 )
        {
            categoria = "CLIENTE";
        }
        else
        {
            categoria = "LEAD";
        }

        
        Console.WriteLine($"{nome} foi classificado(a) como {categoria}");
               
    }
}
