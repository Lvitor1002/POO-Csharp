
/*
Uma empresa deseja automatizar o processamento de seus contratos. 

O processamento de um contrato consiste em gerar as parcelas a serem pagas para aquele contrato, com base no número de meses desejado.

A empresa utiliza um serviço de pagamento online para realizar o pagamento das parcelas.

Os serviços de pagamento online tipicamente cobram um juro mensal, bem como uma taxa por pagamento. 

Por enquanto, o serviço contratado pela empresa é o do Paypal, que aplica;
                                                                    juros simples de 1% a cada parcela,
                                                                    taxa de pagamento de 2%.

Fazer um programa para ler os dados de um contrato; 
                                                  número do contrato, 
                                                  data do contrato,
                                                  valor total do contrato. 

Em seguida, o programa deve ler; 
                                número de meses para parcelamento do contrato

e gerar os registros de parcelas a serem pagas (data e valor), 
sendo; 
     a primeira parcela a ser paga um mês após a data do contrato, 
     a segunda parcela dois meses após o contrato 
e assim por diante. 

Mostrar os dados das parcelas na tela ao final.
 */

using System;
using System.Collections.Generic;
using System.Linq;

using TREINO.Entities;
using TREINO.Services;

namespace TREINO
{
    class Program
    {
        static void Main(string[] args)
        {
            Exibir();
        }
        static (int id, int mes, DateTime dataContrato, double valorTotal) Leitura()
        {
            int id, mes;
            DateTime dataContrato;
            double valorTotal;

            while (true)
            {
                Console.Write(">Digite o Número do Contrato: ");
                string entrada = Console.ReadLine().Trim();
                
                if(int.TryParse(entrada, out id) && id.ToString().Length > 0){
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite números 'inteiros' e maior que zero!");
                }
            }
            while (true)
            {
                Console.Write(">Digite a data atual do contrato [dd/mm/yyyy]: ");
                string data = Console.ReadLine().Trim();

                if (DateTime.TryParse(data, out dataContrato))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite uma data válida: [dd/mm/yyyy]!");
                }
            }
            while (true)
            {
                Console.Write(">Digite o Valor Total do contrato: R$");
                string vt = Console.ReadLine().Trim();

                if (double.TryParse(vt, out valorTotal) && valorTotal > 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real', maior que zero!");
                }
            }
            while (true)
            {
                Console.Write($">Em quantos meses deseja parcelar o valor de R${valorTotal:F2} reais do contrato? ");
                string m = Console.ReadLine().Trim();

                if (int.TryParse(m, out mes) && mes > 0 && mes <= 10)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' de 1 à 10!");
                }
            }
            return (id, mes, dataContrato, valorTotal);
            
        }
        static void Exibir()
        {
            var (id, mes, dataContrato, valorTotal) = Leitura();

            Contrato contrato = new Contrato(id, dataContrato, valorTotal);

            ContratoServices contratoServices = new ContratoServices(new PayPalServices());
            contratoServices.ProcessandoContrato(contrato,mes);

            Console.Clear();
            Console.WriteLine(">Parcelamentos: \n");
            foreach (Parcelamento parcelas in contrato.ListaParcelas)
            {   
                Console.WriteLine(parcelas);
                Console.WriteLine("----------------------------------------");
            }

        }
    }
}
