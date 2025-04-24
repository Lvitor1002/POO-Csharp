
/*
Crie um programa que leia o nome e o preço de vários produtos. 
O programa deverá perguntar se o usuário vai continuar ou não. No final, mostre:
A) qual é o total gasto na compra.
B) quantos produtos custam mais de R$1000.
C) qual é o nome do produto mais barato.
 */


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class Treino
{
    static void Main()
    {
        var (nome_produto_barato, nome_produto, produtos_maiores_1000, preco_produto, total_gasto, produtos) = Dados();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Lista de compra:\n\n");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"{produto.nome}:\n" +
                $"     -Preço: R${produto.preco:F2} Reais\n");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
        Console.Write($"\n>Total gasto na compra: {total_gasto:F2}\n\n" +
            $">{produtos_maiores_1000} produto(s) custa mais que R$1000 reais!\n\n" +
            $">Produto mais barato: {nome_produto_barato}\n\n");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n\n");
    }
    static (string nome_produto_barato, string nome_produto,double produtos_maiores_1000, double preco_produto,double total_gasto , List<Produto>) Dados()
    {
        List<Produto> produtos = new List<Produto>();
        string nome_produto, nome_produto_barato = "";
        double preco_produto, total_gasto = 0, produtos_maiores_1000 = 0;
        double preco_produto_barato = double.MaxValue;

        while (true)
        {
            Console.Clear();
            while (true) 
            {
                Console.Write($"\n>Digite o nome do produto: ");
                nome_produto = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(nome_produto) && !nome_produto.Any(char.IsDigit))
                {
                    nome_produto = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome_produto);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida! Esperava-se um nome em 'string'.");
                }
            }
            Console.Clear();
            while (true)
            {
                Console.Write($"\n>Digite o valor do {nome_produto} R$: ");
                string vp = Console.ReadLine();
                if (double.TryParse(vp, out preco_produto) && preco_produto >= 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida! Esperava-se um número 'inteiro ou real'.");
                }
            }
            total_gasto += preco_produto;
            if (preco_produto > 1000)
            {
                produtos_maiores_1000 += 1;
            }

            if (preco_produto < preco_produto_barato)
            {
                preco_produto_barato = preco_produto;
                nome_produto_barato = nome_produto;

                nome_produto_barato = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome_produto_barato);
            }
            produtos.Add(new Produto { nome = nome_produto, preco = preco_produto });

            Console.Clear();
            Console.Write("\n>Deseja adicionar mais produtos? [S][N]: ");
            string op = Console.ReadLine().Trim().ToLower();
            if (op == "s")
            {
                continue;
            }
            else if (op == "n")
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava-se um número 'inteiro ou real'.");
            }
            
        }
        return (nome_produto_barato, nome_produto, produtos_maiores_1000, preco_produto, total_gasto, produtos);
    }

    class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
    }
}

