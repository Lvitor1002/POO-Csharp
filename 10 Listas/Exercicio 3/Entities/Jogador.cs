/*
Crie um programa que gerencie o aproveitamento de um jogador de futebol. 
O programa vai ler o nome do jogador e quantas partidas ele jogou. 
Depois vai ler a quantidade de gols feitos em cada partida. 
No final, tudo isso será guardado em uma lista, incluindo o total de gols feitos durante o campeonato.

Aprimore para que ele funcione com vários jogadores, 
incluindo um sistema de visualização de detalhes do aproveitamento de cada jogador.
*/
using System.Collections.Generic;
using System.Text;
namespace TREINO.Entities
{
    internal class Jogador
    {
        public string Nome { get; set; }
        public List<Partidas> listaPartidas { get; set; } = new List<Partidas>();

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public void AddPartida(Partidas partida)
        {
            listaPartidas.Add(partida);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0, totalGols = 0;
            sb.Append($"\n>Nome do Jogador(a): {Nome}\n");
            
            sb.AppendLine("\n\t     Partidas\n");
            foreach (var p in listaPartidas)
            {
                sb.AppendLine($"{i+=1}ª Partida - {p.QuantidadeGols} gols");
                totalGols += p.QuantidadeGols;
            }
            sb.Append($"Total de partidas de {Nome}: {listaPartidas.Count} partidas\n" +
                $"Total de gols de {Nome}: {totalGols} gols\n\n" +
                $"------------------------------------------------------------\n");
            return sb.ToString();
        }
    }
}
