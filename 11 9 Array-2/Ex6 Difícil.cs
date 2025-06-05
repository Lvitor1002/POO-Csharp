


/*
Crie um programa que leia vários números inteiros pelo teclado. 
No final da execução, mostre a média entre todos os valores e qual foi o maior e o menor valores lidos. 
O programa deve perguntar ao usuário se ele quer ou não continuar a digitar valores.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Treino
{
    static void Main()
    {
        var (numeros, maior_valor, menor_valor) = Leitura();
        Exibir(numeros, maior_valor, menor_valor);
    }

    static (List<int> numeros, int maior_valor, int menor_valor) Leitura()
    {
        var numeros = new List<int>();
        int numero;
        int maior_valor = int.MinValue;
        int menor_valor = int.MaxValue;
       ;

        while (true)
        {
            Console.WriteLine(">Digite alguns números pelo teclado.\n>Para interromper digite 'sair'.");
            while (true)
            {
                string n = Console.ReadLine().Trim().ToLower();
                if (n == "sair")
                {
                    break;
                }
                else if(int.TryParse(n, out numero) && numero >= 0)
                {
                    numeros.Add(numero);

                    if(numero > maior_valor)
                    {
                        maior_valor = numero;
                    }
                    if(numero < menor_valor)
                    {
                        menor_valor = numero;
                    }
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida! Digite um valor 'inteiro' e positivo ou 'sair'!");
                }
            }

            Console.Clear();
            Console.Write(">Deseja continuar? [s/n]: ");
            while (true)
            {
                string op = Console.ReadLine().Trim().ToLower();
                if (op == "s")
                {
                    Console.Clear();
                    break;
                }
                else if (op == "n")
                {
                    
                    return (numeros, maior_valor, menor_valor);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida! Digite apenas 's' ou 'n'!");
                }
            }
        }
    }

    static void Exibir(List<int> numeros , int maior_valor, int menor_valor)
    {
        Console.Clear();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
        Console.WriteLine(numeros.Count > 0 ? $">Todos os valores adicionados: {string.Join(", ", numeros.OrderBy(x => x))}\n" : ">Zero valores!\n");
        Console.WriteLine(numeros.Count > 0 ? $">Maior valor: {maior_valor}\n" : ">Zero valores!\n");
        Console.WriteLine(numeros.Count > 0 ? $">Menor valor: {menor_valor}\n" : ">Zero valores!\n");
        Console.WriteLine(numeros.Count > 0 ? $">Media dos valores: {(numeros.Average()):F2}\n" : ">Zero valores!\n");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n\n");
    }
}


