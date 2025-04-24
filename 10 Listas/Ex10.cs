

/*
Crie um programa que leia nome e duas notas de vários alunos e guarde tudo em uma lista composta. 
No final, mostre um boletim contendo a média de cada um
e permita que o usuário possa mostrar as notas de cada aluno individualmente.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Treino
{
    static void Main()
    {
        var (alunos, media) = Leitura();
        Exibir(alunos, media);

    }
    static (List<Aluno>, double media) Leitura()
    {
        var alunos = new List<Aluno>();
        string nome;
        double nota, media;

        while (true)
        {
            var notas = new double[2];

            Console.Clear();
            Console.Write(">Digite o seu nome: ");
            while (true)
            {
                nome = Console.ReadLine().Trim().ToLower();
                if(!string.IsNullOrWhiteSpace(nome) && nome.All(c=>char.IsLetter(c) || c == ' ')){
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um nome válido!");
                }
            }
            Console.Clear();
            Console.Write($">{nome}, agora, digite duas notas abaixo:\n");
            for (int i = 0; i < 2; i++)
            {
                while (true)
                {
                    Console.Write($"{i + 1}ª: ");
                    string n = Console.ReadLine();
                    if (double.TryParse(n,out nota) && nota >= 0)
                    {
                        notas[i] = nota;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real', válido!");
                    }
                }
            }
            media = notas.Average();
            alunos.Add(new Aluno { Nome = nome, Notas = notas.ToArray(), Media = media });

            Console.Clear();
            Console.Write(">Deseja adicionar mais alunos? [s/n]: ");
            while (true)
            {
                string op = Console.ReadLine().Trim().ToLower();
                if (op=="s")
                {
                    
                    break;
                }
                else if(op == "n")
                {
                    Console.Clear();
                    return (alunos, media);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite apenas 's' ou 'n'!");
                }
            }
        }
    }
    class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas { get; set; }
        public double Media { get; set; }
    }
    static void Exibir(List<Aluno> alunos, double media)
    {
        int escolha;

        while (true)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n" +
                              "                Boletim dos alunos");
            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine($"{i + 1}ª - {alunos[i].Nome}\n" +
                                  $"Media: {alunos[i].Media:F2}");
                Console.WriteLine("----------------------------------------------------");
            }
            

            while (true)
            {
                Console.Write(">Escolha um aluno digitando o índice de sua posição para vizualizar as notas: ");
                string op = Console.ReadLine();
                if (int.TryParse(op, out escolha) && escolha > 0 && escolha <= alunos.Count)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($">Entrada inválida. Digite um número 'inteiro', válido de 1 à {alunos.Count}!\n");
                    for (int i = 0; i < alunos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}ª - {alunos[i].Nome}\n" +
                                          $"Media: {alunos[i].Media:F2}");
                        Console.WriteLine("------------------------------------------------");
                    }
                }
            }

            var aluno_escolhido = alunos[escolha - 1];

            Console.Clear();
            Console.WriteLine($"Aluno escolhido: {aluno_escolhido.Nome}");
            for (int i = 0; i < aluno_escolhido.Notas.Length; i++)
            {
                Console.WriteLine($"{i+1}ª Nota: {aluno_escolhido.Notas[i]:F2}");
            }

            Console.Write("\n>Deseja vizualizar outros alunos? [s/n]: ");
            while (true)
            {
                string op = Console.ReadLine().Trim().ToLower();
                if (op == "s")
                {
                    Console.Clear();
                    break;
                }
                else if (op == "n")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite apenas 's' ou 'n'!");
                }
            }
        }
    }
}


