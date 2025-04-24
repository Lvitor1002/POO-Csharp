using System;


namespace exer_Contribuentes.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double GastoSaude { get; set; }

        public PessoaFisica()
        {
        }
        public PessoaFisica(double gastoSaude, string pessoa, string nome, double rendaAnual) : base(pessoa, nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double 

/*
Os dados de pessoa física são: 
                               gastos com saúde. 

As regras para cálculo de imposto são as seguintes:

Pessoa física: 
             pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. 
             Pessoas com renda de 20000.00 em diante pagam 25% de imposto. 
             Se a pessoa teve gastos com saúde, 50% destes gastos são abatidos no imposto.
Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto fica: (50000 * 25%) - (2000 * 50%) = 11500.00

Por fim, exibir; 
                valor do imposto pago por cada um, 
 */
using TREINO.Entities.Enums;


namespace TREINO.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(double gastosSaude, string nome, double rendaAnual, Status status) : base(nome, rendaAnual, status)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalculoImposto()
        {
            if (GastosSaude > 0)
            {
                if (RendaAnual < 20000)
                {
                    return (RendaAnual * 0.15) - (GastosSaude * 0.50);
                }
                else
                {
                    return RendaAnual * 0.25 - (GastosSaude * 0.50);
                }
            }
            else
            {
                if (RendaAnual < 20000)
                {
                    return RendaAnual * 0.15;
                }
                else
                {
                    return RendaAnual * 0.25;
                }
            }
            
        }
        public override string ToString()
        {
            return $">{Status}:\n" +
                   $"\t    Nome: {Nome}\n" +
                   $"\t    Valor de imposto a pagar: R${CalculoImposto():F2}\n" +
                   $"----------------------------------------\n\n";
        }
    }
}
Imposto()
        {
            if(GastoSaude > 0)
            {
                if (RendaAnual < 20000)
                {
                    return (RendaAnual * 0.15) - (GastoSaude * 0.50);
                }
                else
                {
                    return (RendaAnual * 0.25) - (GastoSaude * 0.50);
                }
            }
            else
            {
                if (RendaAnual < 20000)
                {
                    return RendaAnual * 0.15;
                }
                else
                {
                    return RendaAnual * 0.25;
                }
            }
        }
    }
}
