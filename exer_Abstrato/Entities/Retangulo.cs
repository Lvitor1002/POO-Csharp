
//if == Retângulo:
//                Cor[preto, azul, vermelho]:,
//                Largura:,
//                Altura:,

using System;
using TREINO.Entities.Enums;


namespace TREINO.Entities 
{
    class Retangulo : Figura
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura, Cores cor, Formas forma) : base(cor,forma)
        {
            Altura = altura;
            Largura = largura;
        }

        //Sobreposição | [override] -> Sobrescrevendo o método
        public override double Area()
        {
            return Altura * Largura;
        }
        
    }
}
