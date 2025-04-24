
/*
Gerar os registros de parcelas a serem pagas:
                                            data,
                                            valor.
Mostrar os dados das parcelas na tela ao final.
 */
using System;


namespace TREINO.Entities
{
    class Parcelamento
    {
        public DateTime DataVencimento { get; set; }
        public double ValorParcela { get; set; }


        public Parcelamento(DateTime dataVencimento, double valorParcela)
        {
            DataVencimento = dataVencimento;
            ValorParcela = valorParcela;
        }


        public override string ToString()
        {
            return $">Data de vencimento: {DataVencimento.ToString("dd/MM/yyyy")}\n" +
                   $">Valor da parcela: {ValorParcela:F2}\n";
        }
    }
}
