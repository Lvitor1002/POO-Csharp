

/* 
Crie um programa que vai gerar cinco números aleatórios de 1 à 10 e colocar em uma tupla. 
Depois disso, mostre a listagem de números gerados e também indique o menor e o maior valor que estão na tupla, 
por fim, a tupla ordenada:.
*/

using System;
using System.Linq;
using System.Globalization;


class Treino
{
    static void Main()
    {
        var numeros_sorteados = Gerador();

        Console.Clear();
        Console.Write("\n-==--==--==--==--==--==--==--==--==--==--==\n");
        Console.Write(">Sequência de 5 números sorteados: ");
        Console.Write($"{string.Join(", ",numeros_sorteados)}." +
            $"\n>Maior valor: {numeros_sorteados.Max()}\n" +
            $">Menor valor: {numeros_sorteados.Min()}\n" +
            $">Tupla Ordenada: {string.Join(", ", numeros_sorteados.OrderBy(x => x))}");
        Console.Write("\n-==--==--==--==--==--==--==--==--==--==--==\n");
    }
    static int[] Gerador()
    {
        int[] numeros = new int[5];
        Random gerar = new Random();


        for (int i = 0; i < 5; i++)
        {
            int numero_sorteado = gerar.Next(0,11);
            numeros[i] = numero_sorteado;
        }
        //ou assim: int[] tupla = Enumerable.Range(1,10).OrderBy(x => sorteio.Next()).Take(5).ToArray(); // Take = Escolher, pegar, usar


        return numeros;
    }
}
