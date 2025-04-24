

/* 
Desenvolva um programa que leia quatro valores pelo teclado e guarde-os em uma tupla. No final, mostre:

A) Quantas vezes apareceu o valor 9.
B) Em que posição foi digitado o primeiro valor 3.
C) Quais foram os números pares.
d) Tupla Ordenada
*/

using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography;


class Treino
{
    static void Main()
    {
        var valores = Leitura();

        Console.Clear();

        Apareceu_Nove(valores);
        Posicao_Primeiro_Valor(valores);
        Numeros_Pares(valores);
        Tupla_Ordenada(valores);

    }
    static int[] Leitura()
    {
        int[] valores = new int[4];
        int valor;

        Console.Clear();
        Console.WriteLine(">Digite 4 valores abaixo: ");
        for (int i = 0; i < 4; i++)
        {
            while (true)
            {
                Console.Write($"{i+1}ª: ");
                string v = Console.ReadLine();
                if(int.TryParse(v, out valor) && valor >= 0)
                {
                    valores[i] = valor;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida! Digite um valor 'inteiro' positivo");
                }
            }
        }
        return valores;
    }

    /*Quantas vezes apareceu o valor 9*/
    static void Apareceu_Nove(int[] valores)
    {
        int quantidade_nove = 0;
        for(int i = 0; i < valores.Length; i++)
        {
            if (valores[i] == 9)
            {
                quantidade_nove += 1;
            }
        }
        if( quantidade_nove > 0)
        {
            Console.WriteLine($">Nove apareceu {quantidade_nove} vezes na tupla.");
        }
        // ou assim: int quantidade_nove = valores.Count(x => x == 9);

    }

    /*Em que posição foi digitado o primeiro valor 3.*/
    static void Posicao_Primeiro_Valor(int[] valores)
    {
        if (Array.Exists(valores, valor => valor == 3)){
            int posicao = Array.IndexOf(valores, 3) + 1;
            Console.WriteLine($">Posição do valor '3' -> {posicao}ª Posição.");
        }
        
    }

    /*Quais foram os números pares.*/
    static void Numeros_Pares(int[] valores)
    {
        var pares = new List<int>();

        foreach(var valor in valores)
        {
            if (valor % 2 == 0 )
            {
                pares.Add(valor);
            }
        }
        if (pares.Count > 0)
        {
            Console.WriteLine($">Valores pares: {string.Join(", ", pares)}");
        }

        // ou assim: Quais foram os números pares: int[] pares = valores.Where(x => x % 2 == 0).ToArray();

    }

    /*Tupla Ordenada*/
    static void Tupla_Ordenada(int[] valores)
    {
        Console.WriteLine($">Valores Ordenados: {string.Join(", ", valores.OrderBy(x => x))}");
    }

}
