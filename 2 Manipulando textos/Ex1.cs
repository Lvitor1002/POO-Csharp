

//Faça um programa que leia um número de 0 a 9999 e mostre na tela cada um dos dígitos separados: unidade, centena, dezena, milhar.

using System;
using System.Linq;
class Treino
{
    static void Main()
    {
        var (numero, unidade, dezena, centena, milhar) = leitura();
        Console.Clear();
        Console.WriteLine($"Unidade: {unidade}");
        Console.WriteLine($"Dezena: {dezena}");
        Console.WriteLine($"Centena: {centena}");
        Console.WriteLine($"Milhar: {milhar}");
        
    }
    static (int numero, int unidade, int dezena, int centena, int milhar) leitura()
    {
        int numero;
        
        while (true)
        {
            Console.Write(">Digite um número: ");
            string n = Console.ReadLine();
            if (int.TryParse(n, out numero) && numero >= 0)
            {
                if (numero <= 9999)
                {
                    int unidade = numero % 10;
                    int dezena = (numero / 10) % 10;
                    int centena = (numero / 100) % 10;
                    int milhar = (numero / 1000) % 10;
                    return (numero, unidade, dezena, centena, milhar);
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Erro! Entrada inválida..\n>Fora do intervalo de 0 à 9999.\n");
                }
            }
            else
            {
                Console.Clear();    
                Console.Write(">Erro! Entrada inválida..\n>Esperava um número 'inteiro positivo'.\n");
            }
        }

    }
    

}