
/*
Escreva um programa que pergunte a quantidade de Km percorridos por um carro alugado e a quantidade de dias 
pelos quais ele foi alugado. 
Calcule o preço a pagar, sabendo que o carro custa R$60 por dia e R$0,15 por Km rodado.
*/
using System;

class Treino
{
    static void Main()
    {
        double cobranca = calculo();
        Console.Clear();
        Console.WriteLine($"O valor total a pagar pelo aluguel é: R${cobranca:F2}\n\n");
    }
    static double calculo()
    {
        int qtd_dias;
        int qtd_km;

        while (true)
        {
            Console.Write(">Digite a quantidade quilometros rodados: ");
            string km = Console.ReadLine();
            if (int.TryParse(km, out qtd_km))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida. Esperava um número 'inteiro'!\n");
            }
        }
        while (true)
        {
            Console.Write(">Digite a quantidade de dias de aluguel ao todo: ");
            string dias = Console.ReadLine();
            if (int.TryParse(dias, out qtd_dias))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida. Esperava um número 'inteiro'!\n");
            }
        }
        
        double cobranca = ((60 * qtd_dias) + (0.15 * qtd_km));
        return cobranca;
    }

}