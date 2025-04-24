

/*
Faça um programa que leia nome e peso de várias pessoas, guardando tudo em uma lista. 
No final, mostre:
A) Quantas pessoas foram cadastradas.
B) Pessoa mais pesada.
C) Pessoa mais leve.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Microsoft.SqlServer.Server;

class Treino
{
    static void Main()
    {
        var pessoas = Leitura();
        var (pesado, leve, nome_pesado, nome_leve) = Peso_Pesado_Leve(pessoas);
        Exibir(pessoas, pesado, leve, nome_pesado, nome_leve);

    }
    static List<Pessoa> Leitura()
    {
        var pessoas = new List<Pessoa>();
        string nome;
        double peso;
        int i = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($">{i+1}ª Pessoa -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            Console.Write(">Digite o seu nome: ");
            while (true)
            {
                nome = Console.ReadLine().ToLower().Trim();
                if (!string.IsNullOrWhiteSpace(nome) && nome.All(c => char.IsLetter(c) | c == ' '))
                {
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um nome válido sem o uso de caracteres especiais!");
                }
            }

            Console.Clear();
            Console.Write($">{nome}, agora, digite o seu peso em KG: ");
            while (true)
            {
                string pe = Console.ReadLine();
                if (double.TryParse(pe, out peso) && peso > 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número de peso 'inteiro' ou 'real', válido e positivo!");
                }
            }
            pessoas.Add(new Pessoa { Nome = nome, Peso = peso });

            Console.Clear();
            Console.Write($">{nome}, deseja continuar à adicionar mais pessoas? [S/N]: ");
            while (true)
            {
                string op = Console.ReadLine().Trim().ToLower();
                if(op == "s")
                {
                    i += 1;
                    break;
                }
                else if(op == "n")
                {
                    return pessoas;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite apenas 's' para conituar e 'n' para encerrar!");
                }
            }
        }
    }
    class Pessoa
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
    }

    static (double, double, string,string) Peso_Pesado_Leve(List<Pessoa> pessoas)
    {
        double pesado = double.MinValue;
        string nome_pesado = "";

        double leve = double.MaxValue;
        string nome_leve = "";
        
        for(int i = 0; i < pessoas.Count; i++)
        {
            if (pessoas[i].Peso > pesado)
            {
                pesado = pessoas[i].Peso;
                nome_pesado = pessoas[i].Nome;
            }
            if(pessoas[i].Peso < leve)
            {
                leve= pessoas[i].Peso;
                nome_leve = pessoas[i].Nome;

            }
        }
        return (pesado, leve, nome_pesado, nome_leve);
    }

    static void Exibir(List<Pessoa> pessoas, double pesado, double leve,string nome_pesado, string nome_leve)
    {
        Console.Clear();
        Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-= Exibindo Dados =--=-=-=-=-=-=-=-=-=-=-=\n");
        // Todas as pessoas.
        foreach (var p in pessoas)
        {
            Console.WriteLine($"{p.Nome} - Peso Kg:{p.Peso:F2}");
            Console.WriteLine("----------------------------------");
        }
        // Quantas pessoas foram cadastradas.
        Console.WriteLine($"\n>[{pessoas.Count}] pessoas foram cadastras.\n");

        // Pessoa mais pesada.
        Console.WriteLine($">{nome_pesado} é pessoa mais pesada, com {pesado}Kg.\n");

        // Pessoa mais leve.
        Console.WriteLine($">{nome_leve} é pessoa mais leve, com {leve}Kg.\n");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }

}
