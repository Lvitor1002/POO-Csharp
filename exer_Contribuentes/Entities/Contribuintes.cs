
/*
nome, 
renda anual,
status.                   
 */


using TREINO.Entities.Enums;

namespace TREINO.Entities
{
    abstract class Contribuintes : IContribuintes
    {
        //Nos atributos da Contribuintes, permane apenas os que são repetidos
        public string Nome { get; set; }
        public double RendaAnual { get; set; }
        public Status Status { get; set; }

        public Contribuintes(string nome, double rendaAnual, Status status)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            Status = status;
        }

        public abstract double CalculoImposto();
    }
}
