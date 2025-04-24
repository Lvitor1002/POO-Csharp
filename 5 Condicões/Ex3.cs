

/*
 Desenvolva um programa que pergunte a distância de uma viagem em Km. 
Calcule o preço da passagem, cobrando R$0,50 por Km para viagens de até 200Km e R$0,45 parta viagens mais longas.
 */

using System;

class Treino
{
    static void Main()
    {
        int distancia;
        while (true)
        {
            Console.Write("\n>Informe a distância da viagem em KM: ");
            string d = Console.ReadLine();
            if (int.TryParse(d, out distancia))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida! Esperava um número 'inteiro'\n");
            }
        }

        if (distancia > 200)
        {
            Console.Clear();
            Console.Write($"\n>{distancia}KM Percorridos!\n>Preco da passagem: R${distancia * 0.45} reais\n\n");
        }
        else
        {
            Console.Clear();
            Console.Write($"\n>{distancia}KM Percorridos!\n>Preco da passagem: R${distancia * 0.50} reais\n\n");
        }

    }
}