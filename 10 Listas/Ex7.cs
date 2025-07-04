using System;
using System.Linq;


/*
Crie um programa que declare uma matriz de dimensão 3x3 e preencha com valores lidos pelo teclado. 
No final, mostre a matriz na tela, com a formatação correta. mostrando no final: 
    A) A soma de todos os valores pares digitados.
    B) A soma dos valores da terceira coluna.
    C) O maior valor da segunda linha.
*/

namespace TREINO
{
    class Program
    {
        static void Main()
        {
            Exibir();
        }
        public static int[,] Leitura()
        {
            var matriz = new int[3, 3];
            int valor;

            Console.Write("Digite 9 números abaixo: \n");
            for(int l = 0; l < 3; l++)
            {
                for(int c = 0; c < 3; c++)
                {
                    while (true)
                    {
                        Console.Write($"[{l + 1},{c + 1}]ª: ");
                        string v = Console.ReadLine().Trim();
                        if(!int.TryParse(v, out valor) || valor < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Entrada inválida. Digite um valor 'inteiro' maior ou igual a zero!");
                            continue;
                        }
                        matriz[l,c] = valor;
                        break;
                    }
                }
            }
            return matriz;
        }
        public static void Calculos(int[,] matriz)
        {
            var todosElementos = matriz.Cast<int>();

            //A) A soma de todos os valores pares digitados.
            var somaTodos = todosElementos.Where(x => x % 2 == 0).Sum();

            //B) A soma dos valores da terceira coluna.
            var somaValoresTerceiraC = Enumerable.Range(0, matriz.GetLength(0))
                .Select(l => matriz[l, 2])
                .Sum();

            //C) O maior valor da segunda linha.
            var maiorValorSegundaL = Enumerable.Range(0, matriz.GetLength(1))
                .Select(c => matriz[1, c])
                .Max();

            Console.WriteLine($"A soma de todos os valores pares digitados: {somaTodos:F0}\n\n" +
                $"A soma dos valores da terceira coluna: {somaValoresTerceiraC:F0}\n\n" +
                $"O maior valor da segunda linha: {maiorValorSegundaL:F0}\n\n");

        }
        public static void Exibir()
        {
            var matriz = Leitura();
            Console.Clear();
            Console.WriteLine("\n-=-=-=-=-=-=- Matriz -=-=-=-=-=-=-\n");

            for (int l = 0; l < 3; l++)
            {
                Console.Write("|");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"{matriz[l,c],3}  |");
                }
                Console.WriteLine("\n");
            }
            Calculos(matriz);
        }
    }
}