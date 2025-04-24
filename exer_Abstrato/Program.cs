
/*
Fazer um programa para ler primeiramente a quantidade de figuras ao todo, 
depois os dados de cada N figuras (N fornecido pelo usuário);
                                                             Retângulo ou Círculo?
                                              if == Retângulo:
                                                             Cor[preto,azul,vermelho]:,
                                                             Largura:,
                                                             Altura:,
                                                if == Círculo:
                                                             Cor[preto,azul,vermelho]:,
                                                             Raio:
e depois mostrar as áreas destas figuras na mesma ordem em que foram digitadas.
 */

using System;
using System.Collections.Generic;
using TREINO.Entities.Enums;
using TREINO.Entities;
using System.Linq;


namespace TREINO
{
    class Program
    {
        static void Main(string[] args)
        {
            Exibir();
        }
        static List<Figura> Leitura()
        {
            double largura, altura, raio;
            int quantidade;
            var listaFiguras = new List<Figura>();

            while (true)
            {
                Console.Write(">Digite a quantidade de figuras ao todo: ");
                string qtd = Console.ReadLine().Trim();
                if(int.TryParse(qtd, out quantidade) && quantidade > 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' maior que zero!");
                }
            }
            

            for(int i = 0; i < quantidade; i++)
            {
                Console.Clear();
                Console.WriteLine($"\t\t{i + 1}ª Figura\n");
                Formas forma;
                while (true)
                {
                    Console.Write(">A figura é retângulo ou circulo? [retangulo/circulo] ");
                    string entradaForma = Console.ReadLine().Trim();
                    if (Enum.TryParse<Formas>(entradaForma, true, out forma))
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite [retangulo ou circulo]!");
                    }
                }
                Cores cor;
                while (true)
                {
                    Console.Write($">Digite a cor do {forma}: [Preto | Azul | Vermelho] ");
                    string entradaCor = Console.ReadLine().Trim().ToLower();
                    if (Enum.TryParse<Cores>(entradaCor, true, out cor))
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite [retangulo ou circulo]!");
                    }
                }

                if(forma == Formas.Retangulo)
                {
                    while (true)
                    {
                        Console.Write(">Largura do Retângulo? ");
                        string lar = Console.ReadLine().Trim();
                        if (double.TryParse(lar, out largura) && largura > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real' maior que zero!");
                        }
                    }
                    while (true)
                    {
                        Console.Write(">Altura do Retângulo? ");
                        string alt = Console.ReadLine().Trim();
                        if (double.TryParse(alt, out altura) && altura> 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real' maior que zero!");
                        }
                    }
                    Retangulo retangulo = new Retangulo(altura, largura, cor, forma);
                    listaFiguras.Add(retangulo);
                }

                if (forma == Formas.Circulo)
                {
                    while (true)
                    {
                        Console.Write(">Raio do Circulo? ");
                        string r = Console.ReadLine().Trim();
                        if (double.TryParse(r, out raio) && raio > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real' maior que zero!");
                        }
                    }
                    Circulo circulo = new Circulo(raio, cor, forma);
                    listaFiguras.Add(circulo);
                }
            }
            return listaFiguras;
        }
        static void Exibir()
        {
            var listaFiguras = Leitura();

            Console.Clear();
            int soma = 0;
            foreach(Figura f in listaFiguras)
            {
                soma += 1;
                Console.WriteLine($"\t  {soma}ª Figura\n\n" +
                                  $">{f.Forma}:\n" +
                                  $"\t Cor: {f.Cor}\n" +
                                  $"\t Area: {f.Area():F2}\n" +
                                  "-------------------------");
            }
        }
    }
}
