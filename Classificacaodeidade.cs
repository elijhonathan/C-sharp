using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrada
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "";
            Console.WriteLine("Escreva Seu Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Escreva Sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Olá " + nome + " de " + idade + " anos de idade.");
            //Console.Write(nome);
            //Console.Write(" de ");
            //Console.Write(idade);
            //Console.Write(" anos de idade.");

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine(" Você é considerado uma Criança!");
            }
            else if (idade >= 12 && idade <= 17)
            {
                Console.WriteLine(" Você é considerado um Adolescente!");
            }
            else if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine(" Você é considerado um Adulto!");
            }
            else
            {
                Console.WriteLine(" Você é considerado um Idoso!");
            }


            Console.ReadLine();
        }
    }
}
