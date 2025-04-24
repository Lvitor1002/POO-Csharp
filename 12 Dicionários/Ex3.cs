

/*
Crie um programa que gerencie o aproveitamento de um jogador de futebol. 
O programa vai ler o nome do jogador e quantas partidas ele jogou. 
Depois vai ler a quantidade de gols feitos em cada partida. 
No final, tudo isso será guardado em um dicionário, incluindo o total de gols feitos durante o campeonato.

Aprimore para que ele funcione com vários jogadores, 
incluindo um sistema de visualização de detalhes do aproveitamento de cada jogador.
*/

using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

class Treino
{
    static void Main()
    {
        var jogadores = Adicionando_Pessoas();
        Exibir(jogadores);
    }
    static Dictionary<string, object> Leitura()
    {
        string nome;
        int partidas, gol;

        var unico_jogador = new Dictionary<string, object>();
        var gols = new List<int>();

        Console.Clear();
        while (true)
        {
            Console.Write(">Digite o seu nome: ");
            nome = Console.ReadLine().Trim().ToLower();
            if(!string.IsNullOrWhiteSpace(nome) && nome.All(c=>char.IsLetter(c) || c == ' '))
            {
                nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um nome válido!");
            }
        }

        Console.Clear();
        while (true)
        {
            Console.Write($">{nome}, agora, digite quantas partidas tiveram ao todo: ");
            string part = Console.ReadLine().Trim();
            if (int.TryParse(part, out partidas) && partidas >= 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' válido e positivo!");
            }
        }
        Console.Clear();
        Console.WriteLine(">Digite os gols feitos em cada partida: ");
        for(int i = 0; i < partidas; i++)
        {
            while (true)
            {
                Console.Write($"{i+1}ª Partida: ");
                string g = Console.ReadLine().Trim();
                if(int.TryParse(g,out gol) && gol >= 0)
                {
                    gols.Add(gol);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' válido e positivo!");
                }
            }
        }

        //Adiciona os dados solicitados do jogador ao dicionário 

        unico_jogador["Nome"] = nome;
        unico_jogador["Gols"] = gols;
        unico_jogador["Total de Gols"] = gols.Sum(); 

        return unico_jogador;
    }

    static List<Dictionary<string,object>> Adicionando_Pessoas()
    {
        var jogadores = new List<Dictionary<string, object>>();

        while (true)
        {
            //Adiciona os jogadores que foram cadastrados na função anterior [Leitura]

            var unico_jogador = Leitura();
            if (unico_jogador.Count > 0)
            {
                jogadores.Add(unico_jogador);
            }

            while (true)
            {
                Console.Write(">Deseja adicionar mais pessoas? [s/n]: ");
                string op = Console.ReadLine().Trim().ToLower();
                if (op == "s")
                {
                    Console.Clear();
                    break;
                }
                else if (op == "n")
                {
                    return jogadores;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite apenas 's' ou 'n'!");
                }
            }
        }
    }
    static void Exibir(List<Dictionary<string, object>> jogadores)
    {
        Console.Clear();
        int escolha = 0;

        while (true)
        {

            //Exibi os jogadores que foram cadastrados

            for (int i = 0; i < jogadores.Count; i++)
            {
                Console.WriteLine($"{i + 1}ª Jogador:\n");
                Console.WriteLine($"Nome: {jogadores[i]["Nome"]}");
                Console.WriteLine("-------------");
            }
            while (true)
            {
                Console.Write($"\n>Escolha um jogador digitando o seu índice para visualizar os gols: ");
                string entrada = Console.ReadLine().Trim();
                if (int.TryParse(entrada, out escolha) && escolha >= 1 && escolha <= jogadores.Count)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' válido e positivo!");
                }

            }
            var jogador_escolhido = jogadores[escolha - 1];



            //Exibi os gols do jogador escolhido

            Console.Clear();
            Console.Write($">Gols de {jogador_escolhido["Nome"]}: {string.Join(", ", (List<int>)jogador_escolhido["Gols"])}.\n");
            Console.WriteLine($">Total de Gols: {jogador_escolhido["Total de Gols"]}");

            while (true)
            {
                Console.Write("\n>Deseja continuar? [Sim][Não]: ");
                string op = Console.ReadLine().Trim().ToLower();
                if (op == "sim")
                {
                    Console.Clear();
                    break;
                }
                else if (op == "não")
                {
                    Console.Clear();
                    Console.WriteLine("Saindo....\n\n\n");
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida! Digite 'Sim' ou 'Não'!");
                }
            }
        }
    }
}



