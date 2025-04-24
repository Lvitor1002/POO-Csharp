
//# Faça um programa que calcule a média entre 4 números usando FOR.
using System;
using System.Net.Http.Headers;

class Treino
{
    static void Main()
    {
        double media = resultado();
        Console.Clear();
        Console.Write($">Média dos números: {media}\n");
    }

    static double resultado()
    {
        double soma = 0;
        int numero;
        int qtd = 4;

        Console.Write(">Digite 4 números abaixo: \n");
        for (int i = 1; i <= qtd; i++)
        {

            while (true)
            {
                Console.Write($"{i}ª: ");
                string n = Console.ReadLine();
                if (int.TryParse(n, out numero))
                {
                    soma += numero;
                    break;
                }
                else
                {
                    Console.WriteLine(">Erro, esperava um 'inteiro'..");
                }
            }


        }

        double media = soma / qtd;
        return media;

    }
}