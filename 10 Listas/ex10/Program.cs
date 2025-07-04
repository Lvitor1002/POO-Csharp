

/*
    Crie um programa que leia nome e duas notas de vários alunos e guarde tudo em uma lista composta. 
    No final, mostre um boletim contendo a média de cada um
    e permita que o usuário possa mostrar as notas de cada aluno individualmente.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TREINO.Entities;

namespace TREINO
{
    class Program
    {
        static void Main()
        {
            Exibir();
        }
        static public List<Aluno> Leitura()
        {

            var alunos = new List<Aluno>();

            while (true)
            {
                string nome;
                var notas = new Notas[2];
                double notaAluno;

                while (true)
                {
                    Console.Write("Entre com o nome do aluno: ");
                    nome = Console.ReadLine().Trim().ToLower();
                    if (string.IsNullOrWhiteSpace(nome) || !nome.All(c => char.IsLetter(c) || c == ' '))
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite um nome válido!");
                        continue;
                    }
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    break;
                }

                Console.Clear();
                Console.WriteLine($"Entre com 2 notas para o aluno {nome}: \n");
                for (int i = 0; i < notas.Length; i++)
                {
                    Console.Write($"\t\t{i + 1}ª Nota: ");
                    while (true)
                    {
                        string n = Console.ReadLine().Trim();
                        if (!double.TryParse(n, out notaAluno) || notaAluno < 0 || notaAluno > 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Entrada inválida. Digite um número 'inteiro' ou 'real' maior que zero menor que 11!");
                            continue;
                        }
                        Notas nota = new Notas(notaAluno);
                        notas[i] = nota;
                        break;
                    }

                }

                Aluno aluno = new Aluno(nome, notas);
                alunos.Add(aluno);

                while (true)
                {
                    Console.Write("Deseja adicionar mais alunos? [S/N] ");
                    string op = Console.ReadLine().Trim().ToLower();
                    if (op == "s")
                    {
                        Console.Clear();
                        break;
                    }
                    if (op == "n")
                    {
                        Console.Clear();
                        return alunos;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite apenas 's' ou 'n'");
                        continue;
                    }
                }
            }
        }
        public static void Exibir()
        {
            var alunos = Leitura();
            Console.Clear();
            int soma = 0;
            Console.WriteLine("\t   Alunos\n");
            foreach (var aluno in alunos)
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=\n" +
                    $"{soma += 1}ª índice('Posição')");
                Console.WriteLine(aluno.ToString());
            }

            int indice = 0;
            Console.WriteLine(">Escolha pelo índice('Posição') um aluno para exibir as notas separadamente:\n");
            while (true)
            {
                string indc = Console.ReadLine().Trim();
                if (!int.TryParse(indc, out indice) || indice < 1 || indice > alunos.Count)
                {
                    Console.Clear();
                    Console.WriteLine($"Entrada inválida ou fora do intervalo. Digite um número 'inteiro' maior que zero e menor que {alunos.Count}!");
                    continue;
                }
                break;
            }
            var escolha = alunos[indice - 1];

            Console.Clear();
            Console.WriteLine($"\tAluno escolhido - {escolha.Nome}\n");
            Console.WriteLine($"\tNotas: {string.Join(" & ", escolha.Notas.Select(n=>n.Nota.ToString("F1")))}\n\n");
        }
    }
}

