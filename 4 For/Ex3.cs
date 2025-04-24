
/*
 Refaça o DESAFIO 009, mostrando a tabuada de um número que o usuário escolher, só que agora utilizando um laço for.
 */

using System;
using System.Linq;


class Treino
{
    static void Main()
    {
        int numero = 0;
     
        while (true)
        {
            Console.Write(">Digite um número para a tabuada: ");
            string n = Console.ReadLine();
            if (int.TryParse(n, out numero))
            {
                for (int i = 0; i <= 10; i += 1)
                {
                    Console.Write($"{numero} x {i}: {numero * i}\n");
                }
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Esperava um 'número'\n");
            }
        }
        
            
        
    }
    
}