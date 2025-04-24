

/*
Faça um programa que ajude um jogador da MEGA SENA a criar palpites.
O programa vai perguntar quantos jogos serão gerados e vai sortear 6 números entre 1 e 60 para cada jogo, 
cadastrando tudo em uma lista composta.
*/

using System;

class Treino
{
    static void Main()
    {
        var matriz = Leitura(); 
        var (soma_par, soma_valores_terceira_coluna, maior_valor_segunda_linha) = Calculos(matriz);
        Exibir(soma_par, soma_valores_terceira_coluna, maior_valor_segunda_linha, matriz);
    }
    static int[,] Leitura()
    {
        var matriz = new int[3,3];
        int valor;

        Console.WriteLine(">Preencha abaixo: ");
        for(int l = 0; l<3; l++)
        {
            for(int c = 0; c < 3; c++)
            {
                while (true)
                {
                    Console.Write($"[{l+1},{c+1}]ª: ");
                    string v = Console.ReadLine();

                    if(int.TryParse(v, out valor) && valor >= 0)
                    {
                        matriz[l, c] = valor;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' e positivo!");
                    }
                }
            }
        }
        return matriz;
    }
    static (int soma_par, int soma_valores_terceira_coluna, int maior_valor_segunda_linha) Calculos(int[,] matriz)
    {
        int soma_par = 0, soma_valores_terceira_coluna = 0;

        int maior_valor_segunda_linha = int.MinValue;

        //A soma de todos os valores pares digitados
        for (int l = 0; l < matriz.GetLength(0); l++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                if (matriz[l,c] % 2 == 0)
                {
                    soma_par += matriz[l, c];
                }
                

                //A soma dos valores da terceira coluna.
                if (c == 2)
                {
                    soma_valores_terceira_coluna += matriz[l, c];
                }

                //O maior valor da segunda linha.
                if(l == 1)
                {
                    if (matriz[l,c] > maior_valor_segunda_linha)
                    {
                        maior_valor_segunda_linha = matriz[l, c];
                    }
                }
            }
        }
        return (soma_par, soma_valores_terceira_coluna, maior_valor_segunda_linha);
    }
    static void Exibir(int soma_par, int soma_valores_terceira_coluna, int maior_valor_segunda_linha, int[,] matriz)
    {
        Console.Clear();
        Console.WriteLine("\n-=-=-=-=-=-=- Matriz -=-=-=-=-=-=-\n");

        for (int l = 0; l < 3; l++)
        {
            Console.Write("|");
            for (int c = 0; c < 3; c++)
            {
                Console.Write($"{matriz[l, c],3} | ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
        Console.WriteLine(soma_par > 0 ? $"> Soma dos números pares: {soma_par}" : "> Sem valores pares!\n");
        Console.WriteLine($"> Soma dos números da terceira coluna: {soma_valores_terceira_coluna}\n");
        Console.WriteLine($"> Maior número da segunda linha: {maior_valor_segunda_linha}");
        Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
    }
}


