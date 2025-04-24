
/*                            
com [N itens] (N fornecido pelo usuário) considerando os seus atributos; nome, 
                                                                    quantidade, 
                                                                    preco. 
*/

using System.Globalization;
using System.Text;

namespace TREINO.Entities
{
    class Itens
    {
        public string Nome { get; set; }
        public int Unidades { get; set; }
        public double Preco { get; set; }

        public Itens()
        {
        }
        public Itens(string nome, int unidades, double preco)
        {
            Nome = nome;
            Unidades = unidades;
            Preco = preco;
        }
        public double SubTotal()
        {
            return Preco * Unidades;
        }
   
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($">Nome: {Nome}\n" +
                      $">Unidades: {Unidades}\n" +
                      $">Preço: R${Preco:F2}\n");
            sb.AppendLine($">Sub Total dos pedidos: R${SubTotal():F2}\n" +
                $"-----------------------------");
            return sb.ToString();

        }

    }
}
