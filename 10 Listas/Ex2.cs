

/*
Crie um programa que vai ler vários números e colocar em uma lista. Depois disso, mostre:
A) Quantos números foram digitados.
B) A lista de valores, ordenada de forma decrescente.
C) Se o valor 5 foi digitado e está ou não na lista.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Server;

class Treino
{
    static void Main()
    {
        var valores = Leitura();
        Exibir(valores);
    }

    static List<int> Leitura()
    {
        var valores = new List<int>();
        int valor; 

        Console.WriteLine(">Digite abaixo alguns valores 'inteiros'.\n>Para interromper digite 'sair'.");
        while (true)
        {
            Console.Write(">Valor: ");
            string v = Console.ReadLine().Trim().ToLower();
            if(v == "sair")
            {
                break;
            }else if(int.TryParse(v,out valor) && valor >= 0)
            {
                valores.Add(valor);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' positivo ou 'sair'!");
            }
        }
        return valores;
    }
    static void Exibir(List<int> valores)
    {
        Console.Clear();
        Console.WriteLine("-=-=-=-=-=-= Valores -=-=-=-=-=-=\n");
        
        //Quantos números foram digitados.
        Console.WriteLine($">Foram digitados {valores.Count} números.\n");

        //A lista de valores, ordenada de forma decrescente.
        Console.WriteLine($">Valores ordenados em ordem decrescente: {string.Join(", ",valores.OrderByDescending(x => x))}.\n");

        //Se o valor 5 foi digitado e está ou não na lista
        if (valores.Contains(5))
        {
            Console.WriteLine(">5 foi adicionado!\n");
        }
        else
        {
            Console.WriteLine(">5 não foi adicionado!\n");
        }

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
    }
}
