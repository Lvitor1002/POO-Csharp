
//if == Retângulo:
//                Cor[preto, azul, vermelho]:,
//                Largura:,
//                Altura:,

using TREINO.Entities.Enums;
namespace TREINO.Entities 
{
    class Retangulo : AbstractFigura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cores cor,Formas forma) :base(cor,forma)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Altura * Largura;
        }


        // (INTERFACE) facilita o uso do toString sem [interface] a exibição seria do program
        public override string ToString()
        {
            return $">{Forma}:\n" +
                $"            Cor do retângulo: {Cor}\n" +
                $"            Largura do retângulo: {Largura:F0}\n" +
                $"            Altura do retângulo: {Altura:F0}\n" +
                $"            Área do retângulo: {Area():F2}\n" +
                $"-------------------------------";
        }
    }
}
