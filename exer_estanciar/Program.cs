

/*
Instancie manualmente os objetos mostrados na imagem e mostre-os na tela do
terminal, conforme exemplo:

                       Post:
                            21/06/2018 13:05:44
                            Viajando para a Nova Zelândia
                            Vou visitar esse país maravilhoso!
                            12 curtidas    
                Comentários:
                            Tenham uma boa viagem
                            Uau, isso é demais!
                            
        ----------------------------------------------------
                       Post:
                            28/07/2018 23:14:19                            
                            Boa noite, pessoal
                            Até amanhã
                            5 curtidas
                Comentários:
                            Boa noite
                            Que a Força esteja com vocês
*/

using System;
using System.Linq;
using System.Globalization;
using TREINO.Entities;

namespace TREINO
{
    class Program
    {
        static void Main(string[] args)
        {
            Exibir();
        }
        static Postagem Leitura()
        {
            DateTime dataAtual = DateTime.UtcNow;
            string titulo, conteudo, texto;
            int qtdCurtidas = 0, qtdComentarios = 0;

            while (true)
            {
                Console.Write(">Digite o titulo do post: ");
                titulo = Console.ReadLine().Trim().ToLower();
                if(!string.IsNullOrEmpty(titulo) && titulo.All(c=>char.IsLetter(c) || c == ' '))
                {
                    titulo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.ToLower());
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um titulo válido!");
                }
            }
            while (true)
            {
                Console.Write(">Digite o objetivo principal do post: ");
                conteudo = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(conteudo))
                {
                    conteudo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(conteudo.ToLower());
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um objetivo válido!");
                }
            }
            while (true)
            {
                Console.Write(">Digite a quantidade de curtidas repercutidas do post: ");
                string qtd = Console.ReadLine().Trim();
                if (int.TryParse(qtd, out qtdCurtidas) && qtdCurtidas >= 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' válido!");
                }
            }
            while (true)
            {
                Console.Write(">Quantos comentários a publicação terá: ");
                string qtdCom = Console.ReadLine().Trim();
                if (int.TryParse(qtdCom, out qtdComentarios) && qtdComentarios >= 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' válido!");
                }
            }
            
            Postagem postagem = new Postagem(dataAtual, titulo, conteudo, qtdCurtidas);

            for (int i = 0; i < qtdComentarios; i++)
            {
                Console.Clear();
                Console.WriteLine($"\t\t{i+1}ª - Comentário\n");

                while (true)
                {
                    texto = Console.ReadLine().Trim().ToLower();
                    if (!string.IsNullOrEmpty(texto))
                    {
                        texto = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto.ToLower());
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um comentário válido!");
                    }
                }
                Comentarios comentario = new Comentarios(texto);
                postagem.addComentario(comentario);
            }
            return postagem;
            
        }
        static void Exibir()
        {
            var postagem = Leitura();

            Console.Clear();
            Console.WriteLine(postagem.ToString());

            Console.WriteLine("\t\t Comentários\n");
            foreach (Comentarios c in postagem.listaComentarios)
            {
                Console.WriteLine(c);
            }
        }
    }
}
