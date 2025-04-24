
/*
Faça um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas).
Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.

A formula para caluclar a área de um triângulo a partir das medidas de seus lados será raiz(p(p-a)(p-b)(p-c)
 */

using System;

class Triangulo
{

    public int[] Medidas { get; private set; }
                          //get público → Permite que qualquer parte do código leia o valor da propriedade.
                          //set privado → Permite que apenas a própria classe modifique o valor da propriedade

    public Triangulo()
    {
        Medidas = new int[3];
    }

    public void Leitura(string nome)
    {
        int medida = 0;

        Console.WriteLine($">Digite abaixo, 3 medidas para o triângulo {nome}: ");
        while (true)
        {
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"{i + 1}ª medida: ");
                    string entrada = Console.ReadLine();
                    if (int.TryParse(entrada, out medida) && medida > 0)
                    {
                        Medidas[i] = medida;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' positivo!");
                    }
                }
            }
            // Verificando se forma um triângulo (Desigualdade Triangular)
            if (Medidas[0] < Medidas[1] + Medidas[2] && Medidas[1] < Medidas[0] + Medidas[2] && Medidas[2] < Medidas[0] + Medidas[1])
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Não é um triângulo! Tente novamente!");
            }
        }
    }

    public double Area()
    {
        double p = (Medidas[0] + Medidas[1] + Medidas[2]) / 2; // Semiperímetro
        return Math.Sqrt(p * (p - Medidas[0]) * (p - Medidas[1]) * (p - Medidas[2]));
    }
}

class Treino
{
    static void Main()
    {
        Triangulo triangulo1 = new Triangulo();
        Triangulo triangulo2 = new Triangulo();

        triangulo1.Leitura("X");
        triangulo2.Leitura("Y");

        double area_triangulo1 = triangulo1.Area();
        double area_triangulo2 = triangulo2.Area();


        Console.Clear();
        Console.WriteLine($">Área do triângulo X: {area_triangulo1:F2}");
        Console.WriteLine($">Área do triângulo Y: {area_triangulo2:F2}");

        // Comparando as duas áreas dos triângulos
        if (area_triangulo1 > area_triangulo2)
        {
            Console.WriteLine(">O triângulo X possui a maior área!\n");
        }
        else if (area_triangulo2 > area_triangulo1)
        {
            Console.WriteLine(">O triângulo Y possui a maior área!\n");
        }
        else
        {
            Console.WriteLine(">Os dois triângulos possuem áreas iguais!\n");
        }
    }
}



