using C_.Common.Models;

using System;

namespace SimulacaoFalhaTeste 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      // TODO: Solicite ao usuário que digite o nome do teste:
      Console.Write("digite o nome do teste:");
      string nomeDoTeste = Console.ReadLine();

      // TODO: Solicite ao usuário que digite a descrição do erro:
      Console.Write("digite a descricao do erro:");
      string descricaoDoErro = Console.ReadLine();

      // Se o teste falhar, exibe a descrição do erro:
      //Console.WriteLine($"O teste falhou. Descrição: {descricaoDoErro}");
      Console.WriteLine($"O teste {nomeDoTeste} falhou. Descricao: {descricaoDoErro}");
    }
  }
}












// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Eli";
// pessoa1.Idade = 29;
// pessoa1.Apresentar();











