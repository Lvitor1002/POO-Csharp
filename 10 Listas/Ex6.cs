

/*
Crie um programa onde o usuário possa digitar sete valores numéricos e
cadastre-os em uma lista única e que mantenha também nesta lista separados os valores pares e ímpares. 
No final, mostre os valores pares e ímpares em ordem crescente.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Server;

class Treino
{
    static void Main()
    {
        var numeros = Leitura();
        var listas = Listas_Par_Impar(numeros);
        Exibir(numeros, listas);
    }
    static int[] Leitura()
    {
        var numeros = new int[7];
        int numero;

        Console.Clear();
        Console.WriteLine(">Digite 7 números abaixo: ");
        for (int i = 0; i < 7; i++) {
            while (true)
            {
                Console.Write($"{i + 1}ª: ");
                string n = Console.ReadLine();
                if (int.TryParse(n, out numero) && numero >= 0)
                {
                    numeros[i] = numero;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' positivo.");
                }
            }
        }
        return numeros;
    }
    
    static List<List<int>> Listas_Par_Impar(int[] numeros)
    {
        var listas = new List<List<int>> { new List<int>(), new List<int>() };
        
        var lista_par = listas[0];
        var lista_impar = listas[1];

        foreach(var n in numeros)
        {
            if(n % 2 == 0)
            {
                lista_par.Add(n);
            }
            else if(n % 2 != 0)
            {
                lista_impar.Add(n);
            }
        }
        return listas;
    }

    static void Exibir(int[] numeros,List<List<int>> listas)
    {
        Console.Clear();    
        Console.WriteLine($"\n>Valores Ordenados: {string.Join(", ",numeros.OrderBy(x => x))}.\n"
            );

        if (listas[0].Count > 0)
        {
            Console.WriteLine($">Valores Pares Ordenados: {string.Join(", ", listas[0].OrderBy(x => x))}.\n");
        }
        if (listas[1].Count > 0)
        {
            Console.WriteLine($">Valores Ímpares Ordenados: {string.Join(", ", listas[1].OrderBy(x => x))}.\n\n");
        }
    }

}
