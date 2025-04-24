


/*
Crie um programa que leia nome, ano de nascimento e carteira de trabalho e
cadastre-o (com idade) em um dicionário.
Se por acaso a pessoa não possuir carteira, o dicionário retornará apenas valores iniciais,
caso contrário o dicionário receberá também o ano de admissão e o salário. 
Calcule e acrescente, além da idade, com quantos anos a pessoa vai se aposentar.
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
        var pessoas = Leitura_Completa();
        Exibir(pessoas);
    }

    static (string nome, int ano, int idade) Leitura_Parcial()
    {
        string nome;
        int ano, idade;

        Console.Clear();
        while (true)
        {
            Console.Write("Digite o seu nome: ");
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
            Console.Write($">{nome}, agora, digite o seu ano de nascimento: ");
            string a = Console.ReadLine().Trim();
            if (int.TryParse(a,out ano) && ano > 1900 && ano < DateTime.Now.Year)
            {
                idade = DateTime.Now.Year - ano;
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um ano 'inteiro' válido!");
            }
        }

        
        return (nome, ano, idade);
    }

    static List<Dictionary<string, object>> Leitura_Completa()
    {
        var pessoas = new List<Dictionary<string, object>>();

        while (true)
        {
            var pessoa = new Dictionary<string, object>();

            var (nome, ano, idade) = Leitura_Parcial();
            int ano_admissao = 0, carteira = 0;
            double salario = 0;

            pessoa["Nome"] = nome;
            pessoa["Ano de Nascimento"] = ano;
            pessoa["Idade"] = idade;
            


            while (true)
            {
                Console.Write($">{pessoa["Nome"]}, você possui carteira de trabalho? [S/N]: ");
                string op = Console.ReadLine().Trim().ToLower();
                if (op == "s")
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.Write($">{pessoa["Nome"]}, agora, digite os 5 números corridos da sua carteira de trabalho: ");
                        string car = Console.ReadLine().Trim();
                        if (int.TryParse(car, out carteira) && car.Length == 5)
                        {
                            pessoa["Carteira de Trabalho"] = carteira;
                            
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(">Entrada inválida. É necessário 5 digitos 'inteiros' válidos!");
                        }
                    }
                    break;
                }
                else if (op == "n")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite apenas 's' ou 'n'!");
                }
            }
            if (carteira > 0)
            {
                //ano de admissão e o salário
                Console.Clear();
                while (true)
                {
                    Console.Write($">{pessoa["Nome"]}, agora, digite o seu ano de admissão: ");
                    string an = Console.ReadLine().Trim();
                    if (int.TryParse(an, out ano_admissao) && ano_admissao > ano && ano_admissao < DateTime.Now.Year)
                    {
                        pessoa["Ano de Admissão"] = ano_admissao;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um ano 'inteiro' válido!");
                    }
                }
                Console.Clear();
                while (true)
                {
                    Console.Write($">{pessoa["Nome"]}, agora, digite o seu salário atual, R$: ");
                    string sa = Console.ReadLine().Trim();
                    if (double.TryParse(sa, out salario) && salario > 0)
                    {
                        pessoa["Salário"] = salario;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real' válido!");
                    }
                }
                int tempo_servico = DateTime.Now.Year - ano_admissao;
                int idade_aposentadoria = idade + (35 - tempo_servico);

                pessoa["Idade de Aposentadoria"] = idade_aposentadoria;
                pessoa["Ano de Aposentadoria"] = DateTime.Now.Year + (idade_aposentadoria - idade);
            }
            

            pessoas.Add(pessoa);

            while (true)
            {
                Console.Write(">Deseja adicionar mais pessoas? [S/N]: ");
                string op = Console.ReadLine().ToLower().Trim();
                if (op == "s")
                {
                    Console.Clear();
                    break;
                }
                else if (op == "n")
                {
                    Console.Clear();
                    return pessoas;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite apenas 's' ou 'n'!");
                }
            }
        }
    }
    static void Exibir(List<Dictionary<string, object>> pessoas)
    {
        Console.Clear();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("            Dicionário de Dados Pessoais\n");

        Console.WriteLine($"{"Campo",-25} | {"Valor"}");
        Console.WriteLine(new string('-', 55));
        foreach (var pessoa in pessoas)
        {
            
            foreach (var dado in pessoa)
            {
                Console.WriteLine($"{dado.Key,-25} | {dado.Value}\n");
            }
            Console.WriteLine(new string('*', 35));
        }
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
    }
}



