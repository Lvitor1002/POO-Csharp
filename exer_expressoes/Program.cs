
/*
exer_expressoes
*/

using System;
using System.Linq;
using System.Collections.Generic;
using TREINO.Entities;
using TREINO.Entities.Enums;


namespace TREINO
{
    class Program
    {
        static void Main(string[] args)
        {
            Exibir();
        }
        static List<Produto> Leitura()
        {
            Categoria c1 = new Categoria() { Id = 1, Nome = "Escolar", Nivel = Nivel.Simples};
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computadores", Nivel = Nivel.Medio};
            Categoria c3 = new Categoria() { Id = 3, Nome = "Eletrônicos", Nivel = Nivel.Robusto };

            var listaProdutos = new List<Produto>() {new Produto() { Id = 1, Nome = "Computador", Preco = 4500.00, Categoria = c2 },
                                                    new Produto() { Id = 2, Nome = "Mouse", Preco = 50.00, Categoria = c3 },
                                                    new Produto() { Id = 3, Nome = "Teclado", Preco = 120.00, Categoria = c3 },
                                                    new Produto() { Id = 4, Nome = "Caderno Espiral", Preco = 15.00, Categoria = c1 },
                                                    new Produto() { Id = 5, Nome = "Notebook", Preco = 3800.00, Categoria = c2 },
                                                    new Produto() { Id = 6, Nome = "Impressora", Preco = 750.00, Categoria = c2 },
                                                    new Produto() { Id = 7, Nome = "Fone de Ouvido", Preco = 200.00, Categoria = c3 },
                                                    new Produto() { Id = 8, Nome = "Lápis", Preco = 2.50, Categoria = c1 },
                                                    new Produto() { Id = 9, Nome = "Tablet", Preco = 2500.00, Categoria = c2 },
                                                    new Produto() { Id = 10, Nome = "Smartphone", Preco = 3000.00, Categoria = c3 },
                                                    new Produto() { Id = 11, Nome = "Agenda", Preco = 25.00, Categoria = c1 },
                                                    new Produto() { Id = 12, Nome = "Câmera Digital", Preco = 1200.00, Categoria = c3 },
                                                    new Produto() { Id = 13, Nome = "Monitor", Preco = 950.00, Categoria = c2 },
                                                    new Produto() { Id = 14, Nome = "Pen Drive", Preco = 40.00, Categoria = c3 },
                                                    new Produto() { Id = 15, Nome = "Borracha", Preco = 1.50, Categoria = c1 }
            };
            return listaProdutos;
        }
        static void Exibir()
        {

            var listaProdutos = Leitura();

            Console.Clear();

            //Produtos de categoria [simples] com preço menor que R$900
            var p1 = listaProdutos.Where(p => p.Preco < 900 && p.Categoria.Nivel == Nivel.Simples);
            Console.WriteLine("\n--------------------------------------\n" +
                            "Produtos de categoria [simples] com preço menor que R$900:\n");
            foreach (var p in p1)
            {
                Console.WriteLine(p);
            }

            //Nome dos produtos da categoria Escolar 
            var np = listaProdutos.Where(p => p.Categoria.Nivel == Nivel.Simples).Select(p => p.Nome);
            Console.WriteLine("\n--------------------------------------\n" +
                             "Nome dos produtos da categoria Escolar:\n");
            foreach(var p in np)
            {
                Console.WriteLine(p);
            }

            //Produtos de Categoria 2 ordenados por preço 
            var p2 = listaProdutos.Where(p => p.Categoria.Nivel == Nivel.Medio).OrderBy(p => p.Preco).Select(p => new {p.Nome,p.Preco});
            Console.WriteLine("\n--------------------------------------\n" +
                           "Produtos de Categoria 2 ordenados por preço:\n");
            foreach (var p in p2)
            {
                Console.WriteLine($"{p.Nome} | {p.Preco}");
            }


            //Maior preço da lista
            var menorP = listaProdutos.Max(p => p.Preco);
            Console.WriteLine("\n--------------------------------------\n" +
                           $">Maior preço da lista: ${menorP}\n");


            //Soma dos produtos de id 1
            var soma = listaProdutos.Where(p => p.Categoria.Id == 1).Sum(p => p.Preco);
            Console.Write($"Soma dos produtos de id i: {soma:F2}\n\n\n");
        }
    }
}
