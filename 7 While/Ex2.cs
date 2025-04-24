

/*
Crie um programa que leia dois valores e mostre um menu na tela:
[ 1 ] somar
[ 2 ] multiplicar
[ 3 ] maior
[ 4 ] novos números
[ 5 ] sair do programa
Seu programa deverá realizar a operação solicitada em cada caso.
 */

using System;
using System.Collections.Generic;


class Treino
{
    static void Main()
    {
        var (n1, n2) = leitura();
        List<double> novos_numeros = new List<double> { n1, n2 };

        double novos;
        int opcoes;

        Console.Clear();
        while (true)
        {
            
            Console.WriteLine("Menu -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n\n" +
                    ">Escolha uma das opções abaixo:\n" +
                    "[ 1 ] somar\n" +
                    "[ 2 ] multiplicar\n" +
                    "[ 3 ] maior\n" +
                    "[ 4 ] novos números\n" +
                    "[ 5 ] sair do programa\n");

            
            string op = Console.ReadLine();

            if (int.TryParse(op, out opcoes) && opcoes > 0 && opcoes <= 5)
            {
                switch (opcoes)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($">Soma de {n1} + {n2} = {n1 + n2}\n");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($">Multiplicação de {n1} * {n2} = {n1 * n2}\n");
                        break;
                    case 3:
                        Console.Clear();
                        if (n1 < n2)
                        {
                            Console.WriteLine($">Maior número digitado: {n2}\n");
                        }
                        else if (n1 > n2)
                        {
                            Console.WriteLine($">Maior número digitado: {n1}\n");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(">Digite novos números para ser adicionados na sequência: ");
                        while (true)
                        {
                            string n = Console.ReadLine();
                            if (double.TryParse(n, out novos))
                            {
                                novos_numeros.Add(novos);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(">Número inválido. Esperava um número 'inteiro ou real'!\n");
                            }
                        }
                        // Atualizar n1 e n2 com os dois primeiros números da lista
                        n1 = novos_numeros[0];
                        n2 = novos_numeros[1];

                        Console.Clear();
                        Console.WriteLine("Números adicionados: ");
                        foreach (var i in novos_numeros)
                        {
                            Console.Write($"{i} | ");
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine(">Saindo..\n");
                        return;
                    default:
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Número inválido. Esperava um número 'inteiro ou real'!\n");
            }
        }
    }


    static (double numero1, double numero2) leitura()
    {
        double numero1, numero2;
        Console.WriteLine(">Digite dois números: ");
        while (true)
        {
            Console.Write(">1ª: ");
            string n1 = Console.ReadLine();
            if (double.TryParse(n1, out numero1) && numero1 > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Número inválido. Esperava um número 'inteiro ou real'!\n");
            }
        }
        while (true)
        {
            Console.Write(">2ª: ");
            string n2 = Console.ReadLine();
            if (double.TryParse(n2, out numero2) && numero2 > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Número inválido. Esperava um número 'inteiro ou real'!\n");
            }
        }
        return (numero1, numero2);
    }
}

