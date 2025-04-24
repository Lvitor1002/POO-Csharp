
/*
 Desenvolva um programa que leia seis números inteiros e mostre a soma apenas daqueles que forem pares. 
Se o valor digitado for ímpar, desconsidere-o.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Treino
{
    static void Main()
    {
        var resultado = leitura();

        int[] numeros = resultado.numeros;
        List<int> par = resultado.par;
       

        Console.Clear();

        Console.WriteLine(new string('~', 50));
        Console.Write(">Números: ");
        foreach (var numero in numeros)
        {
            Console.Write($"{numero} | ");
        }
        Console.WriteLine("");

        
        Console.WriteLine(new string('~', 50));
        Console.Write(">Números pares: ");
        foreach(var p in par)
        {
            Console.Write($"{p} | ");
        }
        Console.WriteLine("");

        Console.WriteLine(new string('~', 50));
        Console.Write($">Soma dos números pares: {par.Sum()}\n");
        Console.WriteLine(new string('~', 50));




    }
    static (int[] numeros, List<int> par) leitura()
    {
        int[] numeros = new int[6];
        List<int> par = new List<int>();

        Console.Write(">Digite 6 números abaixo\n\n");
        for (int i = 0; i < 6; i += 1)
        {
            while (true)
            {
                Console.Write($">{i+1}ª: ");
                string n = Console.ReadLine();
                if (int.TryParse(n, out numeros[i]))
                {
                    if (numeros[i] % 2 == 0)
                    {
                        par.Add(numeros[i]);
                    }
                    break;
                    
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida. Esperava um número inteiro!\n");
                }
            }
        }
        return (numeros, par);

    }
    
}