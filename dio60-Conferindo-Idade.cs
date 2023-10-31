using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int idade = int.Parse(Console.ReadLine());

        // TODO: Faça a verificação se o usuário é maior ou igual a 18 anos e imprima a mensagem exigida
        if ( idade >= 18 )
        {
          Console.WriteLine("Seja bem-vindo!\nAcesso permitido ao CRM.");
            
        }
        else
        {
            Console.WriteLine("Acesso negado. Você não tem idade suficiente para acessar o CRM.");
        }

    }
}
