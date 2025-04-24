

//Escreva um programa que converta uma temperatura digitando em graus Celsius e converta para graus Fahrenheit.
using System;

class Treino
{
    static void Main()
    {
        while (true)
        {
            double valor;

            Console.Write("Temperatura atual em graus 'Celsius': ");
            string t = Console.ReadLine();
            if (double.TryParse(t, out valor) && valor >= 0){
                Console.Clear();
                Console.Write($"\n>Temperatura convertida em {((valor * 9) / 5) + 32:F1} Fahrenheit.\n\n");
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Erro, entrada inválida.. Esperava um 'inteiro ou real..\n");
            }
        }
    }
}