// soma notas de provas e trabalhos e calcula a media, sendo que notas de trabalho são ponderadas a 10%

int numeroDeProvas = 5; // Quantidade das notas que são provas e tem maior peso

int[] notasKira = {90, 86, 87, 98, 100, 94, 90};
int[] notasMia = {92, 89, 81, 96, 90, 89};
int[] notasPiper = {90, 85, 87, 98, 68, 89, 89, 89}; // Lista de alunos com suas notas sendo provas e trabalhos 
int[] notasAnri = {90, 95, 87, 88, 96, 96};
int[] notasTia = {92, 91, 90, 91, 92, 92, 92};
int[] notasLauren = {84, 86, 88, 90, 92, 94, 96, 98};
int[] notasSkyler = {80, 90, 100, 80, 90, 100, 80, 90};
int[] notasNatasha = {91, 91, 91, 91, 91, 91, 91};


int[] notasAluno; // lista para receber nota do aluno da vez no loop
string letraAluno; // Variavel que recebe a letra do aluno com base na media dele
string[] estudantesNomes = {"Kira", "Mia", "Piper", "Anri", "Tia", "Lauren", "Skyler", "Natash"}; // Lista de nomes dos alunos


Console.WriteLine("Estudante\tNota\tLetra\n"); // Titulo da tabela

foreach(string nome in estudantesNomes) // loop principal que vai trocar o aluno a cada rodada
{

    int[] excecaoSwitch = {0}; // lista para tratar a exceção no final do switch

    notasAluno = nome switch // switch para substituir um if else gigante, que compara o nome da vez e já pega a nota relacionada
    {
        "Kira" => notasKira,
        "Mia" => notasMia,
        "Piper" => notasPiper,
        "Anri" => notasAnri,
        "Tia" => notasTia,
        "Lauren" => notasLauren,
        "Skyler" => notasSkyler,
        "Natash" => notasNatasha,
        _ => excecaoSwitch
    };


    int somaDeNotas = 0; // variavel que vai pegar a soma total das notas
    decimal mediaAluno = 0; // variavel para pegar a media
    int numeroDeNotas = 0; // variavel contadora que vai comparar a variavel do inicio de numero de provas com a nota atual, quando passar o valor de provas ele cai no else


    foreach(int nota in notasAluno) // loop que valida se a nota é de prova ou de trabalho sendo que nota de trabalho vale 10% na soma final antes de dividir na media
    {
        numeroDeNotas += 1; // começa com 1 para não dar erro no final e passar valor desejado

        if (numeroDeNotas <= numeroDeProvas)
        {
            somaDeNotas += nota; // notas de prova soma aqui
        }

        else
        {
            somaDeNotas += nota / 10; // notas de trabalho soma aqui sendo ponderada a 10%
        }
    }

    mediaAluno = (decimal)somaDeNotas / numeroDeProvas; // após acrescentar notas de provas e trabalhos dividi tudo pelo numero de provas

    letraAluno = mediaAluno switch // switch para subistituir um if else gigante para letras com base na media
    {
        >= 97 => "A+",
        >= 93 => "A",
        >= 90 => "A-",
        >= 87 => "B+",
        >= 83 => "B",
        >= 80 => "B-",
        >= 77 => "C+",
        >= 73 => "C",
        >= 70 => "C-",
        >= 67 => "D+",
        >= 63 => "D",
        >= 60 => "D-",
        _ => "F" 
    };

    Console.WriteLine($"{nome}:\t\t{mediaAluno}\t{letraAluno}"); // imprimi cada nome de aluno sua media e sua letra até terminar o loop

}

Console.WriteLine("\nPressione Enter para continuar"); // detalhe final que indica que acabou o programa
Console.ReadLine(); // para ficar aguardando dar o enter para encerrar.
