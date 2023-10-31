using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string nome = Console.ReadLine();
            string email = Console.ReadLine();
            string telefone = Console.ReadLine();

            // TODO: Exiba a confirmação de que o contato foi adicionado com sucesso
            Console.WriteLine("Contato adicionado!");

            // TODO: Exiba as informações do contato
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"E-mail: {email}");
            Console.WriteLine($"Tel: {telefone}");

            break; // Este break encerra o loop após a primeira iteração. Se desejar continuar adicionando mais contatos, remova-o.
        }
    }
}
