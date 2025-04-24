

//if == Círculo:
//            Cor[preto, azul, vermelho]:,
//            Raio:

using System;
using TREINO.Entities.Enums;


namespace TREINO.Entities 
{
    class Circulo : AbstractFigura
    {
        public double  Raio { get; set; }

        public Circulo(double raio,Cores cor,Formas forma) :base(cor,forma)
        {
            Raio = raio;
        }


        public override double Area()
        {
            return Math.PI * Math.Pow(Raio,2);
        }


        // (INTERFACE) facilita o uso do toString sem [interface] a exibição seria do program
        public override string ToString()
        {
            return $">{Forma}:\n" +
                   $"           Cor do circulo: {Cor}\n" +
                   $"           Raio do circulo: {Raio:F0}\n" +
                   $"           Área do circulo: {Area():F2}\n" +
                   $"-------------------------------";
        }
    }
}
