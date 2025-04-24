
//Ler os dados de um trabalhador;
//nome,
//nivel de experiência(junior, pleno, senior),
//salário base

//Depois, use o mês e o ano (MM/YYYY) para calcular a renda total. 

//exiba os Dados do Trabalhador:
//                                       Nome,
//                                       Departamento,
//                                       Nivel,
//                                       Renda para a data (mes/ano)


using System.Collections.Generic;
using System.Text;
using TREINO.Entities.Enums;

namespace TREINO.Entities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public Nivel Nivel { get; set; }
        public double SalarioBase { get; set; }
        public string Departamento{ get; set; }
        public List<Contratos> listaContratos { get; set; } = new List<Contratos>(); //<----- Composição -------> Associação de [Objetos] && Instânciando a lista 


        public Trabalhador(string nome, Nivel nivel, double salarioBase, string departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato(Contratos contratos)
        {
            listaContratos.Add(contratos);
        }
        public double RendaTotal(int ano, int mes)
        {
            foreach (Contratos c in listaContratos)
            {
                if (c.DataContrato.Year == ano && c.DataContrato.Month == mes)
                {
                    SalarioBase += c.RendaSimples();
                }
            }
            return SalarioBase;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Contratos c in listaContratos)
            {
                sb.Append($">Nome: {Nome}\n" +
                   $">Departamento: {Departamento}\n" +
                   $">Nivel de Experiência: {Nivel}");
            }
            return sb.ToString();
        }
    }
}

