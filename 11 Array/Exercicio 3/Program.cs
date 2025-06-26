

/*
 Desenvolva um programa que leia o nome, idade e sexo de 4 pessoas. 
No final do programa, mostre: a média de idade do grupo, 
qual é o nome do homem mais velho e quantas mulheres têm menos de 20 anos.
 */


using System;
using System.Globalization;
using System.Linq;
using TREINO.Entities;



namespace TREINO
{
    class Program
    {
        static void Main()
        {
            Exibir();
        }
        public static Pessoa[] Leitura()
        {
            var pessoas = new Pessoa[4];
            string nome; 
            int idade; 
            char sexo;

            for(int i = 0; i < pessoas.Length; i++)
            {
                Console.Clear();
                Console.Write($"\t\t    {i + 1}ª\n\n");
                while (true)
                {
                    Console.Write("Digite o nome da pessoa: ");
                    nome = Console.ReadLine().ToLower().Trim();
                    if(string.IsNullOrWhiteSpace(nome) || !nome.All(c=>char.IsLetter(c) || c==' '))
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite um nome válido!");
                        continue;
                    }
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    break;
                }
                while (true)
                {
                    Console.Write($"Digite a idade de {nome}: ");
                    string idad = Console.ReadLine().Trim();
                    if (!int.TryParse(idad,out idade)||idade<=0)
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite um número 'inteiro' maior que zero e válido!");
                        continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.Write($"Digite o sexo de {nome}, [M/F]: ");
                    string sx = Console.ReadLine().ToLower().Trim();
                    if (string.IsNullOrWhiteSpace(sx) || (sx != "m" && sx != "f"))
                    {
                        Console.Clear();
                        Console.WriteLine("Entrada inválida. Digite um nome válido!");
                        continue;
                    }
                    sexo = sx[0];
                    break;
                }
                Pessoa pessoa = new Pessoa(nome,idade, sexo);
                pessoas[i] = pessoa;
            }
            return pessoas;
        }
        public static void Exibir()
        {
            var array = Leitura();

            
            Console.Clear();
            Console.WriteLine("\t   Info. das Pessoas\n\n");
            foreach (var p in array)
            {
                Console.WriteLine(p.ToString());
            }
            double media = array.Average(p => p.Idade);
            

            //  [OrderByDescending]: Ordenação decrescente
            //  [FirstOrDefault]: Pega o primeiro da lista (mais velho
            var homens = array.Where(h=>char.ToLower(h.Sexo) == 'm').ToList();

            var homemMaisVelho = homens.Any() 
                ? homens.OrderByDescending(p => p.Idade).Select(p => new { p.Nome, p.Idade }).FirstOrDefault() 
                : null;

            var mulheres = array.Where(p => char.ToLower(p.Sexo) == 'f').ToList();
            var qtdMulherMenorVinte = mulheres.Any()
                ? mulheres.Count(m=>m.Idade < 20)
                : 0 ;

            Console.WriteLine($"Media das Idade: {media:F2}\n");
            

            // AValidações homens
            if (homens.Any())
            {
                Console.WriteLine($"Homem mais velho: {homemMaisVelho.Nome} | Idade: {homemMaisVelho.Idade}");
            }
            else
            {
                Console.WriteLine("Não há homens na lista\n");
            }

            if (mulheres.Any())
            {
                Console.WriteLine($"Quantidade de mulheres menores de 20 anos: {qtdMulherMenorVinte} mulheres\n");
            }
            else
            {
                Console.WriteLine("Não há mulheres na lista\n");
            }


        }
    }
}

