
/*
    Classe Calculo contendo uma função de soma que recebe uma quantia variável de valores como prâmetro
*/

using System;
using System.Linq;

class Calculo
{
    public static int SomaValores(params int[] numeros)
    {
        int soma = 0;
        for(int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }
        return soma;
    }

}

class Treino
{
    static void Main()
    {
        Console.WriteLine($"Soma dos valores [1,5,4]: {Calculo.SomaValores(1,5,4)}");
    }

}




