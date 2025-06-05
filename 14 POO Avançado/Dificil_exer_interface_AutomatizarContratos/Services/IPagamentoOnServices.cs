
/*
 Por enquanto, o serviço contratado pela empresa é o do Paypal, que aplica;
                                                                    juros simples de 1% a cada parcela,
                                                                    taxa de pagamento de 2%.
 */



namespace TREINO.Services
{
    interface IPagamentoOnServices
    {
        //Classe [IPagamentoOnServices] será usada por ContratoServices ->>
        //[Métodos]  que serão usados no PayPalServices ->>

        double TaxaPagamento(double valor);
        
        double JurosSimples(double valor, int mes);
    }
}
