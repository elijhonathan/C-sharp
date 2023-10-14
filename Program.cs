using C_.Common.Models;

using System;

namespace VerificacaoDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Aqui é solicitado ao usuário que insira o ID do teste:
      int idTeste;
      if (int.TryParse(Console.ReadLine(), out idTeste)) 
      {
        // Solicita ao usuário que insira a descrição do teste:
        string descricaoTeste = Console.ReadLine();

        // Verifica se o ID do teste é válido e a descrição está dentro dos limites:
        if (idTeste > 0 && descricaoTeste.Length <= 50) 
        {
          // TODO: Adicione um Console.WriteLine para verificar se o ID do teste é válido e a descrição está dentro dos limites:
          Console.WriteLine("ID de teste valido. \nDescricao valida.");
          // TODO: Lembre-se: ID de teste valido. e Descricao valida. 

        }
        else 
        {
          //TODO: Adicione um Console.WriteLine para verificar se o ID do teste é válido:
          Console.WriteLine("ID de teste invalido ou descricao muito longa.");
          //TODO: Lembre-se da validação solicitada na descrição do desafio.

        }
      }
      else 
      {
        Console.WriteLine("ID de teste invalido.");
      }
    }
  }
}












// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Eli";
// pessoa1.Idade = 29;
// pessoa1.Apresentar();











