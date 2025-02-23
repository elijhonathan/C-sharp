using System; 

class URI {

    static void Main(string[] args) { 

        int tempo = int.Parse(Console.ReadLine());
        int duracao = int.Parse(Console.ReadLine());
        
        float distancia = tempo * duracao;
        
        float gasto = distancia / 12;
        
        Console.WriteLine($"{gasto:F3}");

    }

}
