


/*
 Desenvolva um programa que leia o nome, idade e sexo de 4 pessoas. 
No final do programa, mostre: a média de idade do grupo, 
qual é o nome do homem mais velho e quantas mulheres têm menos de 20 anos.
 */

using System;
using System.Linq;
using System.Globalization;

class Treino
{
    static void Main()
    {
        var (pessoas, nome_homem_mais_velho, qtd_mulheres_menores_vinte, media) = Dados();
        Exibir(pessoas, nome_homem_mais_velho, qtd_mulheres_menores_vinte, media);
    }
    static (Pessoa[] pessoas, string nome_homem_mais_velho, int qtd_mulheres_menores_vinte, double media) Dados()
    {
        var pessoas = new Pessoa[4];
        string nome, sexo, nome_homem_mais_velho = "";
        int idade, qtd_mulheres_menores_vinte = 0;
        int homem_mais_velho = int.MinValue;
        double media = 0;

        for (int i = 0; i < 4; i++) {

            
            
            pessoas[i] = new Pessoa();



            Console.Clear();
            Console.Write($"{i+1}ª Pessoa -=-=-=-=\n\n");
            while (true)
            {
                Console.Write(">Digite o seu nome: ");
                nome = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(nome) && nome.All(c => char.IsLetter(c) || c == ' '))
                {

                    pessoas[i].Nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um nome válido!");
                }
            }
            while (true)
            {
                Console.Write($">{pessoas[i].Nome}, digite agora o seu sexo; [m,f]: ");
                sexo = Console.ReadLine().Trim().ToLower();
                if (sexo == "m" || sexo == "f")
                {
                    pessoas[i].Sexo = sexo;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um nome válido!");
                }
            }
            while (true)
            {
                Console.Write($">{pessoas[i].Nome}, digite agora a sua idade: ");
                string ida = Console.ReadLine().Trim();
                if (int.TryParse(ida, out idade) && idade > 0)
                {
                    pessoas[i].Idade = idade;
                        
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um nome válido!");
                }
            }

            // Nome do homem mais velho
            if (pessoas[i].Sexo == "m" && pessoas[i].Idade > homem_mais_velho)
            {
                homem_mais_velho = pessoas[i].Idade;
                nome_homem_mais_velho = pessoas[i].Nome;
            }

            //Quantas mulheres têm menos de 20 anos
            if (pessoas[i].Sexo == "f" && pessoas[i].Idade < 20)
            {
                qtd_mulheres_menores_vinte += 1;
            }
        }

        media = pessoas.Average(pessoa => pessoa.Idade);
        return (pessoas, nome_homem_mais_velho, qtd_mulheres_menores_vinte, media);
    }

    class Pessoa{ 
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
    }

    static void Exibir(Pessoa[] pessoas, string nome_homem_mais_velho, int qtd_mulheres_menores_vinte, double media)
    {
        Console.Clear();

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine($">Pessoas cadastradas:\n");
        for (int i = 0; i < pessoas.Length; i++)
        {
            Console.WriteLine($">{pessoas[i].Nome}\n" +
                              $"Sexo: {pessoas[i].Sexo}\n" +
                              $"Idade: {pessoas[i].Idade}");
            Console.WriteLine("------------------------------");
        }
        Console.WriteLine(string.IsNullOrEmpty(nome_homem_mais_velho) ? ">Nenhum homem cadastrado\n" : $">Nome do Homem mais velho: {nome_homem_mais_velho}\n");
        Console.WriteLine(qtd_mulheres_menores_vinte > 0 ? $">Quantidade de mulheres menores de 20 anos: {qtd_mulheres_menores_vinte} mulheres!\n" : ">Nenhuma mulher menor de 20 anos!\n");
        Console.WriteLine($">Media do grupo: {media:F2}");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n\n");
    }
}

