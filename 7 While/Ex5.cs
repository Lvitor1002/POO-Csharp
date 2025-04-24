
/*
Crie um programa que leia vários números inteiros pelo teclado. 
O programa só vai parar quando o usuário digitar o valor 999, que é a condição de parada. 
No final, mostre quantos números foram digitados e qual foi a soma entre eles (desconsiderando o flag).
 */

using System;

class Treino
{
    static void Main()
    {
        int numeros, quantidade = 0, soma = 0;
        while (true)
        {
            while (true)
            {
            Console.Write("\n>Digite alguns números 'inteiros': ");
            string n = Console.ReadLine();
            if (int.TryParse(n, out numeros) && numeros > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava um número 'inteiro'!");
            }
            }
        
            if (numeros != 999)
            {
                Console.Clear();
                Console.Write("\n>Para finalizar digite [999]\n");
                soma += numeros;
                quantidade += 1;
                continue;
            }
            else
            {
                Console.Clear();
                break;
            }
        }
        Console.WriteLine($"\n>Soma dos {quantidade} números digitados: {soma}");
    }
}
