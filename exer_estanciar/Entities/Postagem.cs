
/*
                       Post:
                            28/07/2018 23:14:19                            
                            Boa noite, pessoal
                            Até amanhã
                            5 curtidas

*/
using System;
using System.Collections.Generic;

namespace TREINO.Entities
{
    class Postagem 
    {
        public DateTime DataAtual { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int QuantidadeCurtidas { get; set; }
        public List<Comentarios> listaComentarios { get; set; } = new List<Comentarios>();

        public Postagem(DateTime dataAtual, string titulo, string conteudo, int quantidadeCurtidas)
        {
            DataAtual = dataAtual;
            Titulo = titulo;
            Conteudo = conteudo;
            QuantidadeCurtidas = quantidadeCurtidas;
        }

        public void addComentario(Comentarios texto)
        {
            listaComentarios.Add(texto);
        }
        public void removeComentario(Comentarios texto)
        {
            listaComentarios.Remove(texto);
        }

        public override string ToString()
        {
            return $"Data Postagem: {DataAtual.ToString("dd/MM/yyyy HH:mm:ss")}\n" +
                   $"Titulo: {Titulo}\n" +
                   $"Objetivo: {Conteudo}\n" +
                   $"Curtidas: {QuantidadeCurtidas}\n\n";
        }
    }
}
