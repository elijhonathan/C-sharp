using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundaGuerraMundial = 1942;
            string corFavorita = "Vermelho";
            float velocidadeF1 = 294.35f;
            bool segundaGuerraMundialAconteceu = true;


            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 394.55f;
            corFavorita = "Preto";

            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);



            Console.ReadLine();


        }
    }
}
