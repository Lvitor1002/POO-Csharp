
/*
Ler os dados de um [pedido]:
                            InstantePedido,
                            Status,
                            Quantidade de Itens. 

com [N itens] (N fornecido pelo usuário) considerando os seus atributos; nome, 
                                                                         unidades, 
                                                                         preco. 

Depois, mostrar um sumário do pedido; 
                                     instante do pedido, 
                                     Status do Pedido, 
                                     cliente(Nome, email, dt nascimento),
                                     itens do pedido,
                                     preço total.

Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now
*/


using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

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
        static (Pedidos pedido, Cliente cliente) Leitura()
        {

            DateTime dataNascimento;
            int quantidadeItens = 0, unidades = 0;
            string nomeItem, nomeCliente, emailCliente;
            double precoItem;

            while (true)
            {
                Console.Write(">Nome do Cliente: ");
                nomeCliente = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(nomeCliente) && nomeCliente.All(c => char.IsLetter(c) || c == ' '))
                {
                    nomeCliente = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomeCliente.ToLower());
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
                Console.Write(">Email do Cliente: ");
                emailCliente = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(emailCliente) && emailCliente.Contains("@"))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Verifique novamente se o email está correto!");
                }
            }
            while (true)
            {
                Console.Write(">Data de nascimento do cliente [dd/MM/yyyy]: ");
                string dtCli = Console.ReadLine().Trim();
                if (DateTime.TryParse(dtCli, out dataNascimento))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite uma data válida no formato: dd/MM/yyyy");
                }
            }
            
            Cliente cliente = new Cliente(nomeCliente, emailCliente, dataNascimento);

            Console.Clear();

            StatusPedido status;
            while (true)
            {
                Console.Write(">Status do Pedido: [PagamentoPendente | Processando | Enviado | Retirado]: ");
                string st = Console.ReadLine().Trim();
                //Parsing -> Convertendo a entrada para Enum = [StatusPedido]
                if (Enum.TryParse<StatusPedido>(st, true, out status))//[true] permite ignorar maiúsculas e minúsculas
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite uma das opções:  [PagamentoPendente | Processando | Enviado | Retirado]");
                }
            }
            while (true)
            {
                Console.Write(">Quantidade de itens para este pedido: ");
                string qtd = Console.ReadLine().Trim();
                if (int.TryParse(qtd, out quantidadeItens) && quantidadeItens >= 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' positivo");
                }
            }
            Pedidos pedido = new Pedidos(DateTime.Now, status, cliente);

            Console.Clear();
            for (int i = 0; i < quantidadeItens; i++)
            {
                Console.WriteLine($"\n{i+1}ª Item\n");
                while (true)
                {
                    Console.Write(">Nome do item: ");
                    nomeItem = Console.ReadLine().Trim().ToLower();
                    if (!string.IsNullOrWhiteSpace(nomeItem) && nomeItem.All(c=>char.IsLetter(c) || c == ' '))
                    {
                        nomeItem = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomeItem.ToLower());
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
                    Console.Write(">Quantidade de unidades para este item: ");
                    string uni = Console.ReadLine().Trim();
                    if (int.TryParse(uni, out unidades) && unidades >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' positivo");
                    }
                }
                while (true)
                {
                    Console.Write(">Preço do item: R$");
                    string pre = Console.ReadLine().Trim();
                    if (double.TryParse(pre, NumberStyles.Any, CultureInfo.InvariantCulture, out precoItem) && precoItem >= 0) //Necessário, pois sem o CULTURE o input desconsidera o . e virgula
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real' positivo");
                    }
                }
                Itens item = new Itens(nomeItem, unidades, precoItem);

                pedido.AdicionarItem(item);
            }

            return (pedido, cliente);
        }
        static void Exibir()
        {
            var (pedido, cliente) = Leitura();

            Console.Clear();

            Console.WriteLine(cliente);
            Console.WriteLine(pedido);

        }
    }
}
