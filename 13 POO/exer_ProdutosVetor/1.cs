
/*
Fazer um programa para ler um número inteiro N e os dados (nome e
preço) de N Produtos. Armazene os N produtos em um vetor. Em
seguida, mostrar o preço médio dos produtos.
*/

using System;
using System.Globalization;
using System.Linq;

class ProdutosVetor
{

    //Atributos private & Propriedades autoimplementadas
    private string _nome;
    public double Preco{ get; private set; }


    //Propriedade autoimplementada apenas para NOME 
    public string Nome
    {
        get { return _nome; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _nome = value;
            }
            else
            {
                throw new ArgumentException(">Nome não pode ser vazio!");
            }
        }
    }

    //Construtor
    public ProdutosVetor(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

}

class Treino
{
    static void Main()
    {
        var (produtos,media) = Leitura();
        Exibir(produtos, media);
    }
    static (ProdutosVetor[], double media) Leitura()
    {
        
        string nome;
        double preco = 0, soma = 0;
        int nValor = 0;

        Console.Write(">Digite quantos produtos deseja criar? ");
        while (true)
        {
            string n = Console.ReadLine().Trim();
            if(int.TryParse(n,out nValor) && nValor > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' maior que zero!");
            }
        }

        var produtos = new ProdutosVetor[nValor];

        for (int i = 0; i < nValor; i++)
        {
            Console.Clear();
            Console.Write($">Digite o nome do {i+1}ª produto: ");
            while (true)
            {
                nome = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(nome) && nome.All(c => char.IsLetter(c) || c == ' '))
                {
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um nome válido!");
                }
            }
            Console.Clear();
            Console.Write($">Digite o preço do produto [{nome}], R$");
            while (true)
            {
                string p = Console.ReadLine().Trim();
                if (double.TryParse(p, out preco) && preco > 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' ou 'real', maior que zero!");
                }
            }
            // Criando o objeto e armazenando no vetor
            produtos[i] = new ProdutosVetor (nome,preco);

            soma += preco;
        }

        double media = soma / nValor;
        return (produtos,media);
    }

    static void Exibir(ProdutosVetor[] produtos, double media)
    {
        Console.Clear();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
        Console.WriteLine(produtos.Length > 1 ? $"      Dados dos {produtos.Length} Produtos\n" : $"      Dados do Produto\n");
        foreach (var p in produtos)
        {
            Console.WriteLine($">Nome: {p.Nome}\n" +
                          $">Preço: {p.Preco:F2}\n");
        }
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine($">Preço Medio: {media:F2}\n");
        
    }
}




