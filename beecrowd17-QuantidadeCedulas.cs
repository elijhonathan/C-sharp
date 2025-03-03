using System; 

class URI {

    static void Main(string[] args) { 

    int valorTotal = int.Parse(Console.ReadLine());
    
    int[] valorNotas = {100, 50, 20, 10, 5, 2, 1};
    
    Console.WriteLine(valorTotal);
    
    for(int i = 0; i < valorNotas.Length; i++)
    {
        int quantidadeNotas = valorTotal / valorNotas[i];
        
        Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {valorNotas[i]},00");
        
        valorTotal %= valorNotas[i];
        

    }

    }

}
