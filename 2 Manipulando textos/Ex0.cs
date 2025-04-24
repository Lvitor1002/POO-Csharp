/*
 '''
Crie um programa que leia o nome completo de uma pessoa e mostre: 
- O nome com todas as letras maiúsculas e minúsculas.
- Quantas letras ao todo (sem considerar espaços).
- Quantas letras tem o primeiro nome.
'''
 */
using System;
using System.Linq;
class Treino
{
    static void Main()
    {
        string nome = Leitura();
        var (nome_maiusculo, nome_minusculo, qtd_letras, qtd_letras_primeiro_nome) = ManipulandoString(nome);

        Console.Clear();
        Console.WriteLine(new string('~',50));
        Console.WriteLine($"> Nome original: {nome }\n" +
            $"> Nome com todas as letras maiúsculas: {nome_maiusculo}\n" +
            $"> Nome com todas as letras minúsculas: {nome_minusculo}\n" +
            $"> Quantidade de letras ao todo (sem considerar espaços): {qtd_letras}\n" +
            $"> Quantidade de letras do primeiro nome: {qtd_letras_primeiro_nome}");
        Console.WriteLine(new string('~', 50));
    }

    static string Leitura()
    {
        while (true) {
            Console.Write(">Digite o seu nome completo: ");
            string nome = Console.ReadLine()?.Trim(); //para garantir que espaços acidentais não afetem o cálculo de caracteres.


            if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit))
            {
                nome = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                return nome;
               
            }
            Console.Clear();
            Console.WriteLine("Entrada inválida. Por favor, digite um nome válido.");

        }
    }
    static (string nome_maiusculo, string nome_minusculo,int quantidade_letras, int qtd_letras_primeiro_nome) ManipulandoString(string nome)
    {

        string nome_maiusculo = nome.ToUpper();
        string nome_minusculo = nome.ToLower();

        string sem_espaco = nome.Replace(" ", "").Trim(); //para garantir que espaços acidentais não afetem o cálculo de caracteres.
        int quantidade_letras = sem_espaco.Length;

        string[] nome_separado = nome.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //Split divide uma string em partes
        int qtd_letras_primeiro_nome = nome_separado.Length > 0 ? nome_separado[0].Length : 0; // Verifica se o array não está vazio antes de tentar acessar o primeiro nome

        /*
        > Sem RemoveEmptyEntries, o array seria: ["", "João", "", "", "da", "Silva", ""].

        > Com RemoveEmptyEntries, o resultado será: ["João", "da", "Silva"].
        */

        return (nome_maiusculo, nome_minusculo, quantidade_letras, qtd_letras_primeiro_nome);
    }

}