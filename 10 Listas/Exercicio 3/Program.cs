
/*
Crie um programa que gerencie o aproveitamento de um jogador de futebol. 
O programa vai ler o nome do jogador e quantas partidas ele jogou. 
Depois vai ler a quantidade de gols feitos em cada partida. 
No final, tudo isso será guardado em uma lista, incluindo o total de gols feitos durante o campeonato.

Aprimore para que ele funcione com vários jogadores, 
incluindo um sistema de visualização de detalhes do aproveitamento de cada jogador.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using TREINO.Entities;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;


namespace TREINO
{
    class Program
    {
        static void Main()
        {
            Exibir();
        }

        public static (List<Jogador> listaJogadores, int totalGols, int totalPartidas) Leitura()
        {
            string nome;
            int quantidadeJogadores = 0, quantidadeGols = 0, quantidadePartidas = 0, totalGols = 0, totalPartidas =0;
            var listaJogadores = new List<Jogador>();
            var listaPartidas = new List<Partidas>();

            while (true)
            {
                Console.Write($"Digite o número de jogadores ao todo? ");
                string qtdJo = Console.ReadLine().Trim();
                if (!int.TryParse(qtdJo, out quantidadeJogadores) || quantidadeJogadores < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Entrada inválida. Digite um número 'inteiro' positivo e maior que zero!");
                    continue;
                }
                break;
            }
            for (int i = 0; i < quantidadeJogadores; i++)
            {
                Console.Clear();
                Console.Write($"\t\t    {i + 1}ª Jogador\n");
                while (true)
                {
                    Console.Write("Digite nome do jogador: ");
                    nome = Console.ReadLine().Trim().ToLower();
                    if (string.IsNullOrWhiteSpace(nome) || !nome.All(c=>char.IsLetter(c) || c == ' '))
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite um nome válido!");
                        continue;
                    }
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    break;
                }
                Console.Clear();
                Jogador jogador = new Jogador(nome);

                while (true)
                {
                    Console.Write($"Quantas partidas {nome} jogou ao todo? ");
                    string qtdP = Console.ReadLine().Trim();
                    if (!int.TryParse(qtdP, out quantidadePartidas) || quantidadePartidas < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite um número 'inteiro' positivo e maior que zero!");
                        continue;
                    }
                    break;
                }
                for(int p = 0;p< quantidadePartidas; p++)
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.Write($"Quantas gols foram feito na {p + 1}ª Partida? ");
                        string qtdG = Console.ReadLine().Trim();
                        if (!int.TryParse(qtdG, out quantidadeGols) || quantidadeGols < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Entrada inválida. Digite um número 'inteiro' positivo e maior que zero!");
                            continue;
                        }
                        totalGols += quantidadeGols;
                        break;
                    }
                    Partidas partidas = new Partidas(quantidadeGols);
                    listaPartidas.Add(partidas);
                    jogador.AddPartida(partidas);
                }

                totalPartidas = listaPartidas.Count;
                listaJogadores.Add(jogador);
            }
            
            return (listaJogadores, totalGols, totalPartidas);
        }
        public static void Exibir()
        {
            var (jogadores, totalGols, totalPartidas) = Leitura();

            Console.Clear();
            Console.WriteLine("\t\t Lista de Jogadores\n");
            foreach(var j in jogadores)
            {
                Console.Write(j.ToString());
            }
            Console.WriteLine($"\nTotal de Jogadores: {jogadores.Count} jogadores\n" +
                $"Total de gols: {totalGols} gols\n" +
                $"Total de partidas: {totalPartidas} partidas\n\n");
        }
    }
}

