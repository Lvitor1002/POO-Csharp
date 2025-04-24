

/*
Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais. 
Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. 
Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.
 */

using System;

class ConversorDeMoeda
{
    public static double Cambio(double cotacao, double dolar)
    {
        double IOF = 0.06;
        double reais = dolar * cotacao;
        return reais + (reais * IOF);
    }
}

class Treino
{
    static void Main()
    {
        var (cotacao, dolar) = Leitura();
        Exibir(cotacao, dolar);
    }
    static (double cotacao, double dolar) Leitura()
    {
        double cotacao=0, dolar = 0;

        
        Console.Write(">Digite a cotação atual do Dolar: ");
        while (true)
        {
            string cot = Console.ReadLine();
            if(double.TryParse(cot, out cotacao) && cotacao > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' ou 'real', maior que zero!");
            }
        }

        
        Console.Write(">Digite agora quantos dolares deseja comprar,  $");
        while (true)
        {
            string dol = Console.ReadLine();
            if (double.TryParse(dol, out dolar) && dolar > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' ou 'real', maior que zero!");
            }
        }
        return (cotacao, dolar);
    }

    static void Exibir(double cotacao, double dolar) {
        Console.Clear();
        Console.WriteLine($"\n>Para comprar ${dolar:F2} dolares, a pessoa pagará R${ConversorDeMoeda.Cambio(cotacao, dolar):F2} reais!\n");
    }
}




