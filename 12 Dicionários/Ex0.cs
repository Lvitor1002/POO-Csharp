


/*
Faça um programa que leia nome, 2 notas de um aluno, guardando também a média e situação em um dicionário. 
No final, mostre o conteúdo da estrutura na tela.

Fácil -> PARA APENAS 1 ALUNO
*/

using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

class Treino
{
    static void Main()
    {
        var aluno = Dados();
        var situacao = Situacao(aluno);
        Exibir(aluno);
    }
    static Dictionary<string, object> Dados()
    {
        var aluno = new Dictionary<string, object>();
        var notas = new double[2];
        
        double nota;
        string nome;

        Console.Clear();
        while (true)
        {
            Console.Write(">Digite o seu nome: ");
            nome = Console.ReadLine().Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(nome) && nome.All(c => char.IsLetter(c) || c == ' '))
            {
                aluno["Nome"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um nome válido!");
            }
        }
        Console.Clear();
        Console.WriteLine($">{aluno["Nome"]}, digite agora 2 notas abaixo: ");
        for (int i = 0; i< 2; i++)
        {
            while (true)
            {
                Console.Write($"{i+1}ª Nota: ");
                string no = Console.ReadLine().Trim();
                if (double.TryParse(no,out nota) && nota >= 0)
                {
                    notas[i] = nota;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'interio' ou 'real', positivo!");
                }
            }
        }
        aluno["Notas"] = notas;
        aluno["Media"] = notas.Average();
        return aluno;
    }
    static Dictionary <string, object> Situacao(Dictionary<string, object> aluno)
    {
        double media = Convert.ToDouble(aluno["Media"]);
        if (media < 5)
        {
            aluno["Situação"] = "Reprovado";
        }
        else if (media >= 5 && media < 7)
        {
            aluno["Situação"] = "Exame";
        }
        else
        {
            aluno["Situação"] = "Aprovado";
        }
        return aluno;
    }
    
    static void Exibir(Dictionary<string, object> aluno)
    {
        Console.Clear();
        Console.WriteLine($">Nome: {aluno["Nome"]}.");
        Console.WriteLine($">Notas: {string.Join(" & ", (double[])aluno["Notas"]):F2}.");
        Console.WriteLine($">Média: {aluno["Media"]:F2}.");
        Console.WriteLine($">Situação de {aluno["Nome"]}: {aluno["Situação"]}.\n");
    }
}

