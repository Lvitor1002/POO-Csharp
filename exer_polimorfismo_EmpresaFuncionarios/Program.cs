
/*
Uma empresa possui funcionários próprios e terceirizados.
Para cada funcionário, deseja-se registrar; 
                                           nome, 
                                           horas trabalhadas,
                                           valor por dia, considerando que os mesmos trabalham 30 dias.. 
                

Funcionários terceirizados possuem ainda uma despesa adicional.
O pagamento dos funcionários corresponde ao (valor da hora trabalhadas multiplicado pelas dias trabalhados), 
sendo que os funcionários terceirizados ainda recebem um bônus correspondente a 110% de sua despesa adicional.

Faça um programa para ler os dados de N funcionários (N fornecido pelo usuário) e armazená-los em uma lista. 

Depois de ler todos os dados, 
                            mostrar nome,
                            pagamento mensal de cada funcionário,

na mesma ordem em que foram digitados.
 
 */


using System;
using System.Linq;
using System.Globalization;

using TREINO.Entities;
using TREINO.Entities.Enums;
using System.Collections.Generic;


namespace TREINO
{
    class Program
    {
        static void Main(string[] args)
        {
            Exibir();
        
        }
        static List<Funcionarios> Leitura()
        {
            string nome;
            int horasTrabalhadas, quantidadeFunc;
            double valorPorHora, despesaAdicional = 0; 
            Tipo tipo;

            var listaFuncionarios = new List<Funcionarios>();




            while (true)
            {
                Console.Write($">Qual a quantidade de funcionários ao todo? ");
                string qtd = Console.ReadLine().Trim();
                if (int.TryParse(qtd, out quantidadeFunc) && quantidadeFunc >= 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' válido!");
                }
            }


            Console.Clear();
            for (int i = 0; i < quantidadeFunc; i++)
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write(">O funcionário é normal ou terceiro? [normal / terceiro]: ");
                    string t = Console.ReadLine().Trim();
                    if (Enum.TryParse<Tipo>(t, true, out tipo))      //Parsing -> Convertendo a entrada para Enum = [Tipo] || [true] permite ignorar maiúsculas e minúsculas
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite apenas um dos tipos de funcionário: [normal / terceiro]!");
                    }
                }
                Console.Clear();
                Console.WriteLine($"\t\t{i+1}ª - {tipo}\n");

                while (true)
                {
                    Console.Write(">Digite o nome do funcionário: ");
                    nome = Console.ReadLine().Trim().ToLower();
                    if (!string.IsNullOrWhiteSpace(nome) && nome.All(c => char.IsLetter(c) || c == ' '))
                    {
                        nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um nome válido!");
                    }
                }
                while (true)
                {
                    Console.Write(">Quantas horas foram ao todo trabalhadas: ");
                    string horast = Console.ReadLine().Trim();
                    if (int.TryParse(horast, out horasTrabalhadas) && horasTrabalhadas >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' válido!");
                    }
                }

                while (true)
                {
                    Console.Write($">Quanto está recebendo por {horasTrabalhadas} horas trabalhadas? R$");
                    string valorph = Console.ReadLine().Trim();
                    if (double.TryParse(valorph, out valorPorHora) && valorPorHora >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real', válido!");
                    }
                }

                if (tipo == Tipo.Normal)
                {
                    Funcionarios funcionarios = new Funcionarios(nome, horasTrabalhadas, valorPorHora, tipo);
                    listaFuncionarios.Add(funcionarios);

                    
                }

                if (tipo == Tipo.Terceiro)
                {
                    while (true)
                    {
                        Console.Write($">Qual a despesa gasta pelo Funcionário {Tipo.Terceiro}? R$");
                        string desp = Console.ReadLine().Trim();
                        if (double.TryParse(desp, out despesaAdicional) && despesaAdicional >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real', válido!");
                        }
                    }
                    FuncionariosTerceirizados funcionariosTerceirizados = new FuncionariosTerceirizados(despesaAdicional,nome, horasTrabalhadas, valorPorHora, tipo);
                    listaFuncionarios.Add(funcionariosTerceirizados);
                }

            }
            return listaFuncionarios;
        }

        static void Exibir()
        {
            var listaFuncionarios = Leitura();

            Console.Clear();

            Console.WriteLine("\tPagamento mensal para cada funcionário.\n");
            foreach (var f in listaFuncionarios)
            {
                Console.WriteLine(f.ToString());
            }

        }
    }
}
