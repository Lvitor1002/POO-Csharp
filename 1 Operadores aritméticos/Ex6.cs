

// Faça um algoritmo que leia o preço de um produto e mostre seu novo preço, com 5% de desconto.

using System;

class Treino
{
    static void Main()
    {
        while (true)
        {
            double valor;

            Console.Write("Valor do produto: R$ ");
            string v = Console.ReadLine();
            if (double.TryParse(v, out valor) && valor >= 0){
                Console.Clear();
                Console.Write($"\n>Parabéns!! Você recebeu um desconto de 5%...\n\n>Valor com desconto: R${valor * 0.95:F2}\n\n");
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