

/*
 O mesmo professor do desafio 019 quer sortear a ordem de apresentação de trabalhos dos alunos. 
Faça um programa que leia o nome dos quatro alunos e mostre a ordem sorteada.
*/

using System;
using System.Globalization;
using System.Linq;


class Treino
{
    static Random sorteio = new Random(); 
    static void Main()
    {
        var alunos = Leitura();
        Exibir_Sorteio(alunos);
    }
    static string[] Leitura()
    {
        var alunos = new string[4];
        string nome;

        Console.Write(">Digite abaixo 4 nomes -=-=-=-=\n");
        for (int i = 0; i < 4; i++)
        {
            while (true)
            {
                Console.Write($"{i+1}ª Nome: ");
                nome = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nome) && nome.All(c => char.IsLetter(c) || c == ' '))
                {
                    alunos[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
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
    static void Embaralhar(string[] alunos)
    {
        for(int i = alunos.Length - 1;  i > 0; i--)
        {
            int x = sorteio.Next(i + 1);
            (alunos[i], alunos[x]) = (alunos[x], alunos[i]);
        }
    }
    static void Exibir_Sorteio(string[] alunos)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==========================================\n" +
                              "          Alunos Cadastrados");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{aluno}");
            }

            string[] ordem_sorteio = alunos.ToArray();

            // chamando - embaralhar a lista
            Embaralhar(ordem_sorteio);

            Console.WriteLine("==========================================\n" +
                              "         Ordem de apresentação");
            for (int i = 0; i < ordem_sorteio.Length; i++) {
                Console.WriteLine($"{i+1}ª - {ordem_sorteio[i]}");
            }
            Console.WriteLine("==========================================\n");
            while (true)
            {
                Console.Write("\n>Deseja uma nova ordem do sorteio? [s/n]: ");
                string op = Console.ReadLine().ToLower().Trim();
                if(op == "s")
                {
                    Console.Clear();
                    break;
                }
                else if(op == "n")
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


