
//Os funcionários terceirizados ainda recebem um bônus correspondente a 110% de sua despesa adicional.

using System.Collections.Generic;
using System.Text;
using TREINO.Entities.Enums;

namespace TREINO.Entities
{
    class FuncionariosTerceirizados : Funcionarios
    {
        public double DespesaAdicional { get; set; }

        public FuncionariosTerceirizados()
        {
        }

        public FuncionariosTerceirizados(double despesaAdicional, string nome, int horasTrabalhadas, double valorPorDia, Tipo tipo) :base(nome, horasTrabalhadas, valorPorDia, tipo)
        {
            DespesaAdicional = despesaAdicional;
        }


        //SOBREPOSIÇÃO
        // [override] - Sobrescrevendo o método [Pagamento] nesta atual subclasse FuncionarioTerceirizado | Herânça de método [Pagamento] da super-classe [Funcionario]
        public sealed override double Pagamento() //Sealed | Selando esse método sobrescrito para que o mesmo não seja sobrescrico novamente em outra sub-classe.
        {
            double despesa = DespesaAdicional * 1.1;
            return base.Pagamento() + despesa;
        }
        // POLIMORFISMO realizado acima, pois o mesmo método é modificado com a adição da DespesaAdicional



        public override string ToString()
        {
            return $"\t\tFuncionário {Tipo}\n\n" +
                   $">Nome: {Nome}\n" +
                   $">Horas trabalhadas: {HorasTrabalhadas}\n" +
                   $">Valor por dia: {ValorPorDia:F2}\n" +
                   $">Pagamento: {Pagamento():F2}\n\n";
        }
    }
}
