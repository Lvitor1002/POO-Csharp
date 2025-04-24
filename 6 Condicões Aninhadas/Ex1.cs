

/*
Escreva um programa em c# que leia um número inteiro qualquer e peça para o usuário escolher qual será a base de conversão: 
1 para binário, 2 para octal e 3 para hexadecimal.
 */

using System;

class Treino
{

    static string Conversao(int valor)
    {
        int escolha;
        while (true)
        {
            Console.Write("\n>Escolha uma das opções a seguir:\n[1] - Binário\n[2] - Octal\n[3] - Hexadecimal\n");
            string esc = Console.ReadLine();
            if (int.TryParse(esc, out escolha) && escolha >= 1 && escolha <= 3)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Esperava um número 'inteiro' de 1 à 3!\n");
            }
        }

        Console.Clear() ;
        switch (escolha)
        {
            case 1:
                return $"\n> Valor {valor} em [Binário]: {Convert.ToString(valor, 2)} \n";
            case 2:
                return $"\n> Valor {valor} em [Octal]: {Convert.ToString(valor, 8)}\n";
            case 3:
                return $"\n> Valor {valor} em [Hexadecimal]: {Convert.ToString(valor, 16)}\n";
            default:
                return "\n> Opção inválida."; // Isso nunca será alcançado, mas é uma boa prática.
        }
    }

    static void Main()
    {
        int valor;
        while (true)
        {
            
            Console.Write("\n>Digite um valor: ");
            string v = Console.ReadLine();
            if (int.TryParse(v, out valor) && valor > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Esperava um número 'inteiro'\n");
            }
        }
        Console.Write(Conversao(valor));
    }
}