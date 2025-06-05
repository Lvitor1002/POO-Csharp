
/*
Além do valor da locação, é acrescido no preço o valor do imposto conforme regras do país que,
no caso do Brasil, é;
                     20 % para valores até 100.00,
                                    ou
                     15% para valores acima de 100.00. 
*/
namespace TREINO.Services
{
    class ImpostoBrasil : I_ImpostoServices //Realização de [interface]. Não é herança!
    {
        public double Imposto(double valor)
        {
            if(valor < 100)
            {
                return valor * 0.20;
            }
            else
            {
                return valor * 0.15;
            }
        }
    }
}
