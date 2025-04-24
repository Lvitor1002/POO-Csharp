
/*
Fazer um programa para ler os valores da largura e altura de um retângulo. Em
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
como mostrado no projeto ao lado.

Diagonal = raíz de a²+b²
 */

using System;

class Retangulo
{
    public double Largura;
    public double Altura;

    public double Area()
    {
        return Largura * Altura;
        
    }

    public double Perimetro()
    {
        return 2 * (Largura + Altura);

    }

    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        
    }

}

class Treino
{
    static void Main()
    {
        Retangulo retangulo = Leitura();

        Exibir(retangulo);
    }

    static Retangulo Leitura()
    {
        Retangulo retangulo = new Retangulo();

        double largura = 0, altura = 0;

        Console.Write(">Digite a largura de um retângulo: ");
        while (true)
        {
            
            string entrada = Console.ReadLine();
            if(double.TryParse(entrada, out largura) && largura > 0)
            {
                retangulo.Largura = largura;
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' ou 'real', positivo!");
            }
        }
        Console.Write(">Digite a altura de um retângulo: ");
        while (true)
        {
            string entrada2 = Console.ReadLine();
            if (double.TryParse(entrada2, out altura) && altura > 0)
            {
                retangulo.Altura = altura;
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' ou 'real', positivo!");
            }
        }
        return retangulo;
    }

    static void Exibir(Retangulo retangulo)
    {
        Console.Clear();
        Console.WriteLine($"\nÁrea: {retangulo.Area():F2}\n");
        Console.WriteLine($"Perímetro: {retangulo.Perimetro():F2}\n");
        Console.WriteLine($"Diagonal: {retangulo.Diagonal():F2}\n");
    }
}




