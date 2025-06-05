

namespace TREINO.Entities
{
    class Cobranca 
    {

        //[Atributos]
        public double ValorLocacao { get; set; }
        public double ValorImposto { get; set; }

        public Cobranca(double valorLocacao, double valorImposto)
        {
            ValorLocacao = valorLocacao;
            ValorImposto = valorImposto;
        }
        //[Atributo] | feito depois por conta da declaração anterior do Construtor que recebe os 
        public double ValorTotal { get { return ValorLocacao + ValorImposto; } }


        //[Método] | Exibir nota de pagamento
        public override string ToString()
        {
            return $">Valor da locação: R${ValorLocacao:F2}\n" +
                   $">Valor do Imposto: R${ValorImposto:F2}\n" +
                   $">Valor total do pagamento: R${ValorTotal:F2}\n";
        }
    }
}
