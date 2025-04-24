
/*
Crie um programa que leia a nome, idade e o sexo de várias pessoas. 
A cada pessoa cadastrada, o programa deverá perguntar se o usuário quer ou não continuar. 
No final, mostre:
A) quantas pessoas tem mais de 18 anos.
B) quantos homens foram cadastrados.
C) quantas mulheres tem menos de 20 anos. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Runtime.InteropServices;                   
class Treino
{
    static void Main()
    {
        var (quantidade_pessoas_maiores, quantidade_homem, quantidade_mulheres_menor, lista_pessoas) = Dados();

        Console.Clear();
        Console.WriteLine("\n>Pessoas Adicionadas:\n");
        foreach (var pessoa in lista_pessoas)
        {
            Console.WriteLine($"{pessoa.Nome}:\n" +
                $"     -Sexo: {pessoa.Sexo.ToUpper()}\n" +
                $"     -Idade: {pessoa.Idade}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=");
        }
        Console.Write($"\n>Quantas pessoas têm mais de 18 anos: {quantidade_pessoas_maiores}\n");
        Console.Write($">Quantos homens foram cadastrados: {quantidade_homem}\n");
        Console.Write($">Quantas mulheres têm menos de 20 anos: {quantidade_mulheres_menor}\n");
        Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }
    static (int quantidade_pessoas_menores, int quantidade_homem, int quantidade_mulheres_menor, List<Pessoa>) Dados()
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        
        int idade, quantidade_pessoas_maiores = 0, quantidade_homem = 0, quantidade_mulheres_menor = 0;
        while (true)
        {
            Console.Clear();
            string nome, sexo;
            while (true)
            {
                Console.Write("\nDigite o seu nome: ");
                nome = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit))
                {
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida. Esperava-se um nome em 'string'!\n");
                }
            }
            Console.Clear();
            while (true)
            {
                Console.Write($"\nDigite o seu sexo {nome}, [M] ou [F]: ");
                sexo = Console.ReadLine().Trim().ToLower();
                if (sexo == "m" || sexo == "f")
                {
                    
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida. Esperava-se o sexo em 'string' sendo; 'M' ou 'F'!\n");
                }
            }
            Console.Clear();
            while (true)
            {

                Console.Write($"\nDigite a sua idade, {nome}: ");
                string i = Console.ReadLine();
                if (int.TryParse(i, out idade) && idade > 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida. Esperava-se a idade como número 'inteiro'!\n");
                }
            }
            pessoas.Add(new Pessoa { Nome = nome, Sexo = sexo, Idade = idade });

            if (idade > 18)
            {
                quantidade_pessoas_maiores += 1;
            }
            if (sexo == "m")
            {
                quantidade_homem += 1;
            }
            if (sexo == "f" && idade < 20)
            {
                quantidade_mulheres_menor += 1;
            }

            Console.Clear();
            Console.Write($"\n>Deseja adicionar mais pessoas, {nome}? [Sim][Não]: ");
            string op = Console.ReadLine().Trim().ToLower();
            if (op == "sim")
            {
                continue;
            }
            else if(op == "não")
            {
                break;
            }
        }
        return (quantidade_pessoas_maiores, quantidade_homem, quantidade_mulheres_menor, pessoas);
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
    }
}

