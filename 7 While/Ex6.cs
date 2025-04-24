
/*
Crie um programa que leia vários números inteiros pelo teclado. 
No final da execução, mostre a média entre todos os valores e qual foi o maior e o menor valores lidos. 
O programa deve perguntar ao usuário se ele quer ou não continuar a digitar valores.
 */

using System;
using System.Collections.Generic;
class Treino
{
    static void Main()
    {
        var (qtd_numeros, media, maior, menor, numeros) = Leitura();

        Console.Clear();
        Console.Write("\n>Todos os números: "); 
        foreach (var i in numeros)
        {
            Console.Write($"{i} | ");
        }
        Console.WriteLine($"\n>Quantidade de números digitados: {qtd_numeros}\n" +
            $">Média dos números: {media:F2}\n" +
            $">Maior número: {maior}\n" +
            $">Menor número: {menor}\n");
    }

    static (int qtd_numeros, double media, int maior, int menor ,List<int> numeros) Leitura()
    {
        int numero, soma = 0, qtd_numeros = 0;
        int maior = int.MinValue, menor = int.MaxValue;
        double media;

        List<int> numeros = new List<int>();

        Console.WriteLine(">Digite um número!\n>Para Finalizar e exibir resultdos digite[sair]");
        
        while (true)
        {
            string n = Console.ReadLine().Trim().ToLower();
            
                
            if (n == "sair")
            {
                if (qtd_numeros == 0)
                {
                    Console.WriteLine("\n>Nenhum número foi digitado!");
                    return (0, 0, 0, 0, numeros);
                }
                media = (double)soma / qtd_numeros;
                break;
            }

            if (int.TryParse(n, out numero) && numero > 0)
            {
                numeros.Add(numero);
                soma += numero;
                qtd_numeros += 1;

                if (numero > maior)
                {
                    maior = numero;
                }
                if (numero < menor)
                {
                    menor = numero;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava um número 'inteiro' ou 'Sair'!");
                Console.WriteLine(">Digite um número: ");

            }
        }
        return (qtd_numeros, media, maior, menor, numeros);
    }
}
