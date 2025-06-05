

//O processamento de um contrato consiste em gerar as parcelas a serem pagas para aquele contrato, com base no número de meses desejado.

using System;
using TREINO.Entities;

namespace TREINO.Services
{
    class ContratoServices
    {
        /*
        [IPagamentoOnlineServices] <- é uma interface, o que sugere que a classe depende de um serviço que implemente essa interface para lidar com pagamentos online. 
        Essa prática facilita a aplicação de Inversão de Dependência (DIP) e injeção de dependências, permitindo maior flexibilidade e testabilidade. ->> 
        */
        //Atributo
        private IPagamentoOnServices _pagamento;


        //Construtor
        public ContratoServices(IPagamentoOnServices pagamento)
        {
            _pagamento = pagamento;
        }


        //Métodos
        public void ProcessandoContrato(Contrato contrato, int mes)
        {
            double cotacao = contrato.ValorTotalContrato / mes;

            //Para cada parcela ->>
            for(int i = 1; i<=mes; i++)
            {
                DateTime data = contrato.DataContrato.AddMonths(i);

                double atualizaCotacao = cotacao + _pagamento.JurosSimples(cotacao, i);

                double cotacaoTotal = atualizaCotacao + _pagamento.TaxaPagamento(atualizaCotacao);

                contrato.AdicionaParcela(new Parcelamento(data,cotacaoTotal));
            }
        }

    }
}
