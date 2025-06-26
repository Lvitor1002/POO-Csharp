

/*
Crie um programa que leia nome, sexo e idade de várias pessoas, 
guardando os dados de cada pessoa em um dicionário e todos os dicionários em uma lista. No final, mostre: 
A) Quantas pessoas foram cadastradas
B) A média de idade
C) Uma lista com as mulheres
D) Uma lista de pessoas com idade acima da média
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
        var (pessoas, lista_mulheres, lista_idade_acima_media, qtd_pessoas, media) = Manipulando_Dados();
        Exibir(pessoas, lista_mulheres, lista_idade_acima_media, qtd_pessoas, media);
    }
    static Dictionary<string,object> Leitura()
    {
        var pessoa = new Dictionary<string, object>();

        string nome, sexo;
        int idade;

        Console.Clear();
        while (true)
        {
            Console.Write(">Digite o seu nome: ");
            nome = Console.ReadLine().Trim().ToLower();
            if(!string.IsNullOrWhiteSpace(nome) && nome.All(c=>char.IsLetter(c) || c == ' '))
            {
                pessoa["Nome"] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
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
            Console.Write($">{pessoa["Nome"]}, agora, digite o seu sexo: ");
            sexo = Console.ReadLine().Trim().ToLower();
            if (sexo == "m" || sexo == "f")
            {
                pessoa["Sexo"] = sexo;
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite apenas 'm' ou 'f'!");
            }
        }
        Console.Clear();
        while (true)
        {
            Console.Write($">{pessoa["Nome"]}, agora, digite a sua idade: ");
            string ida = Console.ReadLine();
            if (int.TryParse(ida,out idade) && idade > 0)
            {
                pessoa["Idade"] = idade;
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um número 'interio' e positivo!");
            }
        }
        return pessoa;
    }
    static (List<Dictionary<string,object>> pessoas,
        List<Dictionary<string, object>> lista_mulheres,
        List<Dictionary<string, object>> lista_idade_acima_media, int qtd_pessoas, double media) Manipulando_Dados()
    {
         /* - `Count`: Retorna a quantidade de elementos em uma coleção
            - `Length`: Retorna o tamanho de arrays e strings 
            - `Sum`: Retorna a soma dos elementos numéricos de uma coleção */

        var pessoas = new List<Dictionary<string, object>>(); // Lista que suporta um dicionário interno
        var lista_mulheres = new List<Dictionary<string, object>>(); // Lista que suporta um dicionário interno
        var lista_idade_acima_media = new List<Dictionary<string, object>>(); // Lista que suporta um dicionário interno

        int qtd_pessoas = 0;
        double media = 0;

        while (true)
        {
            var pessoa = Leitura();
            pessoas.Add(pessoa);

            //  Quantas pessoas foram cadastradas
            qtd_pessoas = pessoas.Count;

            // Uma lista com as mulheres
            lista_mulheres = pessoas.Where(x => x["Sexo"].ToString().ToLower() == "f").ToList();

            //Uma lista de pessoas com idade acima da média
            lista_idade_acima_media = pessoas.Where(x => Convert.ToDouble(x["Idade"]) > media).ToList();
             

            Console.Clear();
            while (true)
            {
                Console.Write(">Deseja adicionar mais pessoas? [s/n]: ");
                string op = Console.ReadLine().Trim().ToLower();
                if (op == "s")
                {
                    break;
                } else if(op == "n")
                {
                    // A média de idade
                    media = pessoas.Average(x => Convert.ToDouble(x["Idade"]));

                    return (pessoas, lista_mulheres, lista_idade_acima_media, qtd_pessoas, media);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite apenas 's' ou 'n'!");
                }
            }
        }
    }
    static void Exibir(List<Dictionary<string, object>> pessoas,
        List<Dictionary<string, object>> lista_mulheres,
        List<Dictionary<string, object>> lista_idade_acima_media, int qtd_pessoas, double media)
    {

        Console.Clear();

        Console.WriteLine("||||||||||||||||| Todas as pessoas cadastradas |||||||||||||||||\n");
        
        Console.WriteLine(qtd_pessoas > 0 ? $">{qtd_pessoas} pessoa(s) cadastrada(s).\n" : ">Não há pessoas cadastradas\n");
        for (int i = 0; i < pessoas.Count; i++)
        {
            Console.WriteLine($">{pessoas[i]["Nome"]}:\n" +
                              $"      Sexo: {pessoas[i]["Sexo"]}\n" +
                              $"      Idade: {pessoas[i]["Idade"]}");
            Console.WriteLine("-=-=-=-=-=-=-=");
        }
        
        if (lista_mulheres.Count > 0)
        {
            Console.WriteLine("\n||||||||||||||||| Todas as mulheres cadastradas |||||||||||||||||\n");
            for (int i = 0; i < lista_mulheres.Count; i++)
            {
                Console.WriteLine($">{lista_mulheres[i]["Nome"]}:\n" +
                                  $"     Sexo: {lista_mulheres[i]["Sexo"]}\n" +
                                  $"     Idade: {lista_mulheres[i]["Idade"]}");
                Console.WriteLine("-=-=-=-=-=-=-=");
            }
        }

        Console.WriteLine($"\n>Média das idades: {media:F2}\n");
        
        Console.WriteLine("||||||||||| Todas as pessoas com idade acima da média |||||||||||\n");
        for (int i = 0; i < lista_idade_acima_media.Count; i++)
        {
            Console.WriteLine($">{lista_idade_acima_media[i]["Nome"]}:\n" +
                              $"     Sexo: {lista_idade_acima_media[i]["Sexo"]}\n" +
                              $"     Idade: {lista_idade_acima_media[i]["Idade"]}");
            Console.WriteLine("-=-=-=-=-=-=-=");
        }
        Console.WriteLine($"\n||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\n\n");
    }
}



