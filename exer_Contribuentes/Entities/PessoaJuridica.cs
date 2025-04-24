

/*
 Os dados de pessoa jurídica são: 
                               número de funcionários. 

As regras para cálculo de imposto são as seguintes:

Pessoa jurídica: 
                pessoas jurídicas pagam 16% de imposto. 
                Porém, se a empresa possuir mais de 10 funcionários, ela paga 14% de imposto.
Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica: 400000 * 14% = 56000.00

Por fim, exibir; 
                valor do imposto pago por cada um, 
                total de imposto arrecadado.
 */
using TREINO.Entities.Enums;


namespace TREINO.Entities
{
    class PessoaJuridica : Contribuintes
    {
        public int QuantidadeFuncionarios { get; set; }

        public PessoaJuridica(int quantidadeFuncionarios, string nome, double rendaAnual, Status status) :base(nome, rendaAnual, status)
        {
            QuantidadeFuncionarios = quantidadeFuncionarios;
        }

        public override double CalculoImposto()
        {
            if(QuantidadeFuncionarios <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }

        public override string ToString()
        {
            return $">{Status}:\n" +
                   $"\t    Nome: {Nome}\n" +
                   $"\t    Total de Imposto Arrecado pela empresa: R${CalculoImposto():F2}\n" +
                   $"----------------------------------------\n\n";
        }
    }
}
