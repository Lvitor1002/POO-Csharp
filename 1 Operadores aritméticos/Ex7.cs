

//# Faça um algoritmo que leia o salário de uma pessoa e mostre seu novo salário com 15% de aumento.

using System;

class Treino
{
    static void Main()
    {
        while (true)
        {
            double valor;

            Console.Write("Salário atual: R$ ");
            string v = Console.ReadLine();
            if (double.TryParse(v, out valor) && valor >= 0){
                Console.Clear();
                Console.Write($"\n>Parabéns!! Você recebeu um aumento de 15% em seu salário...\n\n>Aumento: R${valor * 1.15:F2}\n\n");
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