

/*
Os serviços de pagamento online tipicamente cobram um juro mensal, bem como uma taxa por pagamento. 
 */



namespace TREINO.Services
{
    class PayPalServices : IPagamentoOnServices //Realização de [interface]. Não é herança!
    {

        //Atributos

        private const double JurosMensais = 0.01;
        private const double Taxa = 0.02;


        //Usando os métodos porque não é abstrto, se fosse, eles seriam apenas declarados herdados de IFigura.
        public double JurosSimples(double valor, int mes)
        {
            return valor * JurosMensais * mes;
        }
        public double TaxaPagamento(double valor)
        {
            return valor * Taxa;
        }
    }
}
