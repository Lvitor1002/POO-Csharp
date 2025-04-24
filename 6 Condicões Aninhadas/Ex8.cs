

/*
Elabore um programa que calcule o valor a ser pago por um produto, considerando o seu preço normal e condição de pagamento:
- à vista dinheiro/cheque: 10% de desconto
- à vista no cartão: 5% de desconto
- em até 2x no cartão: preço formal
- 3x ou mais no cartão: 20% de juros
 */

using System;
using System.Globalization;
using System.Linq;

class Treino
{
    static void Main()
    {
        var (nome, valor) = Dados();
        int op;
        Console.Clear();
        Console.Write("\n-=-=-=-=-=-= Formas de pagamento -=-=-=-=-=-=\n");
        
        while (true)
        {
            Console.Write(">Escolha uma das opções abaixo: ");
            Console.Write("\n[1] - à vista dinheiro/cheque: 10% de desconto\n" +
                "[2] - à vista no cartão: 5% de desconto\n" +
                "[3] - em até 2x no cartão: preço formal\n" +
                "[4] - 3x ou mais no cartão: 20% de juros\n");

            string OP = Console.ReadLine();
            if (int.TryParse(OP, out op) && op >= 1 && op <= 4)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida. Esperava um número 'inteiro ou real'\n");
            }
        }
        Console.Clear();
        switch (op)
        {
            case 1:
                Console.WriteLine($">Valor de R${valor:F2} reais do produto '{nome}' com 10% de desconto: R${valor*0.90:F2} reais\n");
                break;
            case 2:
                Console.WriteLine($">Valor de R${valor:F2} reais do produto '{nome}' com 5% de desconto: R${valor * 0.95:F2} reais\n");
                break;

            case 3:
                int parcela2;
                while (true)
                {
                    Console.Write("\n>Parcelamento até 2x sem juros. [3x ou mais no cartão: 20% de juros]\n" +
                    "Digite a quantidade de vezes que deseja parcelar: ");
                    string parc = Console.ReadLine();
                    if (int.TryParse(parc, out parcela2) && parcela2 >= 1 && parcela2 <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write(">Entrada inválida. Esperava um número 'inteiro ou real'\n");
                    }

                }
                if (parcela2 < 3)
                {
                    Console.Clear();
                    Console.WriteLine($">Valor da parcela em {parcela2}x vezes do produto '{nome}' sem juros: R${(valor / parcela2):F2} reais\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($">Valor original:{valor:F2}\n>Valor da parcela em {parcela2}x vezes do produto '{nome}' com 20% de juros: R${(valor * 1.20) / parcela2:F2} reais\n>Valor final: {valor * 1.20:F2} reais.\n");
                }

                break;
            case 4:
                int parcela;
                while (true)
                {
                    Console.Write("\n>Parcelamento até 10x. [3x ou mais no cartão: 20% de juros]\n" +
                    "Digite a quantidade de vezes que deseja parcelar: ");
                    string parc = Console.ReadLine();
                    if (int.TryParse(parc, out parcela) && parcela >= 1 && parcela <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write(">Entrada inválida. Esperava um número 'inteiro ou real'\n");
                    }
                     
                }
                if (parcela < 3)
                {
                    Console.Clear();
                    Console.WriteLine($">Valor da parcela em {parcela}x vezes do produto '{nome}' sem juros: R${(valor / parcela):F2} reais\n");
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine($">Valor original:{valor:F2}\n>Valor da parcela em {parcela}x vezes do produto '{nome}' com 20% de juros: R${(valor * 1.20) / parcela:F2} reais\n>Valor final: {valor * 1.20:F2} reais.\n");
                }
                
                break;

            default:
                Console.Clear();
                break;

        }

    }
    
    static (string nome, double valor) Dados()
    {
        string nome;
        double valor;
        while (true)
        {
            Console.Write("\n>Digite o nome do produto: ");
            nome = Console.ReadLine().Trim();
            if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit))
            {
                nome = Capitalize(nome);
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Esperava uma 'string'\n");
            }
        }
        

        while (true)
        {
            Console.Write("\n>Digite o valor do produto R$: ");
            string va = Console.ReadLine();
            if (double.TryParse(va, out valor))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida. Esperava um número 'inteiro ou real'\n");
            }
        }
        return (nome, valor);
    }

    static string Capitalize(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            return nome;
        }
        else
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
        }
    }
}