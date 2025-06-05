

using System;

class Calculo{


    //Para inibir a necessidade de instanciar a classe Calculo em Treino, basta deixar os métodos [static]

    public static double Pi = 3.14;
    public static double Circunferencia(double raio){
        return 2 * Pi * raio;
    }
    public static double Volume(double raio){ 
        return 4 / 3 * Pi * Math.Pow(raio,3);
    }

}
class Treino
{
    static void Main()
    {
        double raio = double.Parse(Console.ReadLine());

       //Chamando com o nome da classe:
       double circunferencia = Calculo.Circunferencia(raio);
       double volume = Calculo.Volume(raio);
    }
}



