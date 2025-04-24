
//Crie um programa que leia um número inteiro e mostre na tela se ele é PAR ou ÍMPAR.



using System;



class Treino
{
    static void Main()
    {
        int numero;
        while (true)
        {
            Console.Write(">Digite um número: ");
            string n = Console.ReadLine();
            if (int.TryParse(n, out numero)) 
            {
                if (numero % 2 == 0)
                {
                    Console.Clear();
                    Console.Write($">{numero} é Par!\n");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write($">{numero} é Ímpar!\n");
                    break;
                }
                
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida! Esperava um número 'inteiro'\n");
            }
        }

    }
}