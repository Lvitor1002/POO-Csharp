
/*
 
Fazer um programa para ler o nome de um aluno e a nota que ele obteve em cada um dos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. 

Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). 

Você deve criar uma classe Aluno para resolver este problema.

 */

using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public double[] Notas { get; set; } = new double[3]; // Um array para armazenar as notas dos três trimestres
    
    public double NotaFinal()
    {
        // Aplicando os pesos corretos
        return Notas[0] * 0.30 + Notas[1] * 0.35 + Notas[2] * 0.35;
    }

}

class Treino
{
    static void Main()
    {
        var aluno = Leitura();
        Exibir(aluno);
    }
    static Aluno Leitura()
    {

        Aluno aluno = new Aluno();

        string nome;

        Console.Clear();
        Console.Write(">Digite o seu nome: ");
        while (true)
        {
            nome = Console.ReadLine().Trim().ToLower();
            if(!string.IsNullOrWhiteSpace(nome) && nome.All(c=>char.IsLetter(c) || c==' '))
            {
                aluno.Nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um nome válido!");
            }
        }
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            while (true)
            {
                Console.Write($">Digite a nota do {i + 1}º trimestre (0 a 100): ");
                string entrada = Console.ReadLine().Trim();
                if (double.TryParse(entrada, out double nota) && nota >= 0 && nota <= 100)
                {
                    aluno.Notas[i] = nota;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("> Entrada inválida. Digite um número válido entre 0 e 100!");
                }
            }
        }
        return aluno;
    }

    static string Situacao(Aluno aluno)
    {
        double notaFinal = aluno.NotaFinal();

        if (notaFinal >= 60)
        {
            return "Aprovado!";
        }
        else
        {
            return $"Reprovado!\n> Faltam {60 - notaFinal:F2} pontos para aprovação!";
        }

    }
    static void Exibir(Aluno aluno)
    {
        Console.Clear();

        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
        Console.WriteLine($">{aluno.Nome}:");
        for(int i = 0; i< aluno.Notas.Length; i++)
        {
            Console.WriteLine($">Notas do {i + 1}ªTrimestre: {string.Join(", ", aluno.Notas[i]):F2}.");
        }
        Console.WriteLine($"\n> Nota final: {aluno.NotaFinal():F2} pontos");
        Console.WriteLine($"> Situação: {Situacao(aluno)}");
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||\n");
    }
}




