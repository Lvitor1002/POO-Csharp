

//if == Círculo:
//            Cor[preto, azul, vermelho]:,
//            Raio:

using System;
using TREINO.Entities.Enums;

namespace TREINO.Entities
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cores cor, Formas forma) : base(cor, forma)
        {
            Raio = raio;
        }

        //Sobreposição | [override] -> Sobrescrevendo o método
        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

       
    }
}
