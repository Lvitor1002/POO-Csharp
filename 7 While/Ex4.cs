

/*
Escreva um programa que leia um número N inteiro qualquer e mostre na tela 
os N primeiros elementos de uma Sequência de Fibonacci. 

Ex: 0 - 1 - 1 - 2 - 3 - 5 - 8
 */

using System;
using System.Collections.Generic;

class Treino
{
    static void Main()
    {
        int numero;

        // Inicializa uma lista com os dois primeiros números da sequência de Fibonacci (0 e 1)
        List<int> lista_fibo = new List<int> { 0, 1 };

        while (true)
        {
            Console.Write("\n>Digite um número 'inteiro' qualquer: ");
            string n = Console.ReadLine(); 

            if (int.TryParse(n, out numero) && numero > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava um número 'inteiro'!");
            }
        }

        // Gera os números de Fibonacci até que a lista contenha a quantidade desejada de elementos
        while (lista_fibo.Count < numero)
        {
            // Calcula o próximo número como a soma dos dois últimos números na lista
            int proximo = lista_fibo[lista_fibo.Count - 1] + lista_fibo[lista_fibo.Count - 2];
            // Adiciona o próximo número à lista
            lista_fibo.Add(proximo);
        }

        // Exibe os primeiros 'numero' elementos da sequência de Fibonacci
        Console.WriteLine($"\n>Os {numero} primeiros elementos da sequência:");

        // Variável auxiliar para controlar o formato da saída (evitar o traço inicial)
        bool primeiros = true;

        // Itera sobre os números da lista de Fibonacci
        foreach (int i in lista_fibo)
        {
            // Se não for o primeiro número, insere um traço antes de imprimir o próximo número
            if (!primeiros)
            {
                Console.Write("-");
            }
            // Imprime o número atual da lista
            Console.Write(i);
            // Marca que o primeiro número já foi processado
            primeiros = false;
        }

        Console.WriteLine();
    }
}
