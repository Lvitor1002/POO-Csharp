
using System.Linq;
using System.Text;

namespace TREINO.Entities
{
    internal class Aluno
    {
        public string Nome{ get; set; }
        public Notas[] Notas { get; set; } = new Notas[2];
        public double Media { get; set; }

        public Aluno(string nome, Notas[] notas)
        {
            Nome = nome;
            Notas = notas;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine("Notas:");
            for(int i = 0; i < Notas.Length; i++)
            {
                sb.AppendLine($"\t{i+1}ª Nota: {Notas[i].Nota:F1}");
            }
            sb.AppendLine($"\nMedia: {Notas.Average(n=>n.Nota)}");
            return sb.ToString();
        }
    }
}
