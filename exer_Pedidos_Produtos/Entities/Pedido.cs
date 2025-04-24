
/*
Ler os dados de um [pedido]:
                            InstantePedido,
                            Status,
                            Itens. 
 
Depois, mostrar um sumário do pedido; 
                                     instante do pedido, 
                                     Status do Pedido, 
                                     cliente, 
                                     itens do pedido,
                                     preço total.

Nota: o instante do pedido deve ser o instante do sistema: DateTime.Now
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using TREINO.Entities.Enums;

namespace TREINO.Entities
{
    class Pedidos
    {
        public DateTime InstantePedido { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; } //<----- Composição -------> Associação de [Objetos]
        public List<Itens> listaItens { get; set; } = new List<Itens>();

        public Pedidos()
        {
        }

        public Pedidos(DateTime instantePedido, StatusPedido status, Cliente cliente)
        {
            InstantePedido = instantePedido;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionarItem(Itens item)
        {
            listaItens.Add(item);
        }
        public void RemoverItem(Itens item)
        {
            listaItens.Remove(item);
        }
        public double PrecoTotal()
        {
            double soma = 0;
            foreach(Itens i in listaItens)
            {
                soma += i.SubTotal();
            }
            return soma;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"-=-=-=-= Dados do Pedido: -=-=-=-=\n\n" +
                      $">Instante do Pedido: {InstantePedido.ToString("dd/MM/yyyy HH:mm:ss")}\n" +
                      $">Status do Pedido: {Status}\n\n" +
            $"-=-=-=-= Dados dos Itens: -=-=-=-=\n\n");
            foreach(Itens i in listaItens)
            {
                sb.Append(i.ToString());
            }

            sb.AppendLine($">Preco Total do Pedido: R${PrecoTotal():F2}\n\n");
            return sb.ToString();
        }
    }
}
