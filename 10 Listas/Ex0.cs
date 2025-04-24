

/*
Faça um programa que leia 10 valores numéricos e guarde-os em uma lista. 
No final, mostre a lista ordenada e qual foi o maior e o menor valor digitado e as suas respectivas POSIÇÕES na lista. 
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Treino
{
    static void Main()
    {
        var (valores, menor, maior, pos_menor, pos_maior) = Leitura();
        Exibir(valores, menor, maior, pos_menor, pos_maior);
    }


    static void Exibir(List<int> valores, int menor, int maior, int pos_menor, int pos_maior)
    {
        Console.Clear();
        Console.WriteLine(">Todos os valores: \n");
        for(int i = 0; i < valores.Count; i++)
        {
            Console.WriteLine($"{i+1}ª | {valores[i]}");
        }
        Console.Write($"\n>Maior valor {maior} na posição {pos_maior}ª\n\n" +
                      $">Menor valor {menor} na posição {pos_menor}ª\n\n" +
                      $">Valores Ordenados: {string.Join(", ", valores.OrderBy(x => x))}.\n\n");

    }

    
    static (List<int> valores, int menor, int maior, int pos_menor, int pos_maior) Leitura()
    {
        var valores = new List<int>();
        int valor, pos_menor = 0, pos_maior;

        int maior = int.MinValue;
        int menor = int.MaxValue;

        Console.WriteLine(">Digite abaixo 10 valores numéricos: ");
        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                Console.Write($"{i+1}ª: ");
                string v = Console.ReadLine();
                if(int.TryParse(v, out valor) && valor >= 0)
                {
                    if(valor > maior)
                    {
                        maior = valor;
                        
                    }else if( valor < menor)
                    {
                        menor = valor;
                    }
                    valores.Add(valor);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' positivo!");
                }
            }
        }
        pos_maior = valores.IndexOf(maior) + 1;
        pos_menor = valores.IndexOf(menor) + 1;

        return (valores, menor, maior, pos_menor, pos_maior);
    }
}
