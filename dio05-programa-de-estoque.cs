using C_.Models;

int a = 0;
int estoque = 7;

Console.Write("Digite a quantidade que deseja comprar: ");
a = int.Parse(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("Venda inválida");
}

else if (a <= estoque)
{
    Console.WriteLine("Compra realizada com sucesso!");
}

else
{
    Console.WriteLine("Desculpe, no momento não temos a quantidade necessaria do produto.");
}
