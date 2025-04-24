
//Para cada funcionário, deseja-se registrar;
//                                   nome, 
//                                   horas trabalhadas,
//                                   valor por dia.
//O pagamento dos funcionários corresponde ao (valor da hora trabalhadas multiplicado pelas dias trabalhados)
using TREINO.Entities.Enums;
using System.Collections.Generic;
using System.Text;


namespace TREINO.Entities
{
    class Funcionarios
    {

        public string Nome{ get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorPorDia{ get; set; }
        public Tipo Tipo { get; set; }

        public Funcionarios()
        {
        }
        public Funcionarios(string nome, int horasTrabalhadas, double valorPorDia, Tipo tipo)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorDia = valorPorDia;
            Tipo = tipo;
        }


        // [Virtual] - Para que este método Pagamento seja sobrescrito lá na subclasse [FuncionarioTerceirizado]
        //pode ser sobrescrito (override) em uma classe derivada.
        public virtual double Pagamento()  
        {
            return ValorPorDia * 30;
        }


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
