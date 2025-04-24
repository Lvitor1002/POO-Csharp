/*
Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), 
os quais podem ser pessoa física ou pessoa jurídica,

Os dados de pessoa física são: nome, 
                               renda anual,
                               gastos com saúde. 
Os dados de pessoa jurídica são: 
                               nome, 
                               renda anual, 
                               número de funcionários. 

As regras para cálculo de imposto são as seguintes:

Pessoa física: 
             pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. 
             Pessoas com renda de 20000.00 em diante pagam 25% de imposto. 
             Se a pessoa teve gastos com saúde, 50% destes gastos são abatidos no imposto.
Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto fica: (50000 * 25%) - (2000 * 50%) = 11500.00

Pessoa jurídica: 
                pessoas jurídicas pagam 16% de imposto. 
                Porém, se a empresa possuir mais de 10 funcionários, ela paga 14% de imposto.
Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica: 400000 * 14% = 56000.00

Por fim, exibir; 
                valor do imposto pago por cada um, 
                total de imposto arrecadado.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TREINO.Entities;
using TREINO.Entities.Enums;


namespace TREINO
{
    class Program
    {
        static void Main(string[] args)
        {
            Exibir();
        }
        static List<Contribuintes> Leitura()
        {
            var listaContribuintes = new List<Contribuintes>();
            int quantidadeContribuintes = 0, quantidadeFuncionarios = 0;
            double rendaAnual = 0, gastoSaude = 0;
            string nome;
            Status status;



            while (true)
            {
                Console.Write(">Digite a quantidade de Contribuintes ao total: ");
                string qtd = Console.ReadLine().Trim();
                if(int.TryParse(qtd, out quantidadeContribuintes) && quantidadeContribuintes > 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' maior que zero!");
                }
            }

            
            for (int i = 0; i < quantidadeContribuintes; i++)
            {
                Console.Clear();
                while (true)
                {
                    Console.Write(">É pessoa Jurídica ou Física? [fisica / juridica] ");
                    string escolha = Console.ReadLine().Trim();

                    if (Enum.TryParse<Status>(escolha, true, out status))
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite apenas [fisica ou juridica]!");
                    }
                }

                Console.Clear();
                Console.WriteLine($"------------------------------------------------\n" +
                                  $"\t\t\t{i + 1}ª\n");
                while (true)
                {
                    Console.Write($">Digite o nome da pessoa {status}? ");
                    nome = Console.ReadLine().Trim().ToLower();

                    if (!string.IsNullOrWhiteSpace(nome) && nome.All(c=>char.IsLetter(c) || c == ' '))
                    {
                        nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite apenas [fisica ou juridica]!");
                    }
                }
                while (true)
                {
                    Console.Write($">Qual a renda anual de {nome}? ");
                    string ren = Console.ReadLine().Trim();

                    if (double.TryParse(ren, out rendaAnual) && rendaAnual > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real' maior que zero!");
                    }
                }

                //Número de funcionários - Jurídica.
                if (status == Status.Juridica)
                {
                    while (true)
                    {
                        Console.Write($">Digite a quantidade de funcionários da empresa {nome}: ");
                        string qtdFunc = Console.ReadLine().Trim();
                        if (int.TryParse(qtdFunc, out quantidadeFuncionarios) && quantidadeFuncionarios > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' maior que zero!");
                        }
                    }


                    //Se add fora deste [if] irá duplicar a exibição
                    listaContribuintes.Add(new PessoaJuridica(quantidadeFuncionarios, nome, rendaAnual, status));
                }
                
                

                //Gastos com saúde - Física.
                if (status == Status.Fisica)
                {
                    while (true)
                    {
                        Console.Write($">Informe o valor gasto com saúde pela pessoa {status}?\n>Se não: Digite o número '0'\n>");
                        string gs = Console.ReadLine().Trim();

                        if (double.TryParse(gs, out gastoSaude) && gastoSaude >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real'!");
                        }
                    }


                    //Se add fora deste [if] irá duplicar a exibição
                    listaContribuintes.Add(new PessoaFisica(gastoSaude, nome, rendaAnual, status));
                }
                
            }
            return listaContribuintes;
        }
        static void Exibir()
        {
            var listaContribuintes = Leitura();

            Console.Clear();
            foreach (Contribuintes c in listaContribuintes)
            {
                Console.WriteLine(c);
            }
        }
    }
}
