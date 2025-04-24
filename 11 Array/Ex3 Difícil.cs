

/* 
Um professor quer sortear um dos seus quatro alunos para apagar o quadro. Faça um programa que ajude ele, 
lendo o nome dos alunos e escrevendo na tela o nome do escolhido, 
por fim, pergunte se deseja um novo sorteio com os mesmos nomes para mudar o nome sorteado.
*/

using System;
using System.Globalization;
using System.Linq;


class Treino
{
    static Random sorteio = new Random(); // Evita reinicialização desnecessária

    static void Main()
    {
        var alunos = Leitura();
        Exibir_Sorteio(alunos);
    }
    static string[] Leitura()
    {
        var alunos = new string[4];
        string nome;
        
        for(int i = 0; i < 4; i++)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine($"{i+1}ª - Aluno:\n");
                Console.Write(">Digite o seu nome: ");
                nome = Console.ReadLine().Trim().ToLower();
                if(!string.IsNullOrWhiteSpace(nome) && nome.All(c=>char.IsLetter(c) || c == ' '))
                {
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    alunos[i] = nome;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um nome válido!\n");
                }
            }
        }
        return alunos;
    }
    static void Exibir_Sorteio(string[] alunos)
    {

        Console.Clear();
        while (true)
        {
            Console.WriteLine("==========================================\n" +
                              "          Alunos Cadastrados");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{aluno}");
            }

            var aluno_sorteado = sorteio.Next(0, alunos.Length);
            Console.WriteLine("------------------------------------------\n" +
                              "           Aluno Sorteado\n" +
                              $"{alunos[aluno_sorteado]}");
            Console.WriteLine("\n==========================================\n");

            while (true)
            {
                Console.Write(">Deseja um novo sorteio? [s/n]: ");
                string op = Console.ReadLine().Trim().ToLower();
                if(op == "s")
                {
                    Console.Clear();
                    break;
                } else if (op == "n")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite apenas 's' ou 'n'!\n");
                }
            }
        }
    }
}


