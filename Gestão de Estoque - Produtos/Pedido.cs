using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class Pedido:IDado   //não vai ter relação nenhuma com a árvore 
    {
        #region Atributos
        public int Id { get; set; }
        public int QuantidadeProdutos { get; set; }
        #endregion

        #region Construtor
        public Pedido(int Id)
        {
            
        }
        #endregion

        #region Métodos
        
        #endregion

        #region Métodos Interface
        public int CompareTo(object obj)
        {
            Pedido item = (Pedido)(obj);

            //Quando é menor, maior e igual

            return 0;
        }
        public override bool Equals(object obj)
        {
            Pedido item = (Pedido)(obj);

            //Quando é igual?

            return false;
        }
        public override string ToString()
        {
            StringBuilder auxString = new StringBuilder();

            auxString.AppendLine("Pedido nº" + Id);
            auxString.AppendLine(Itens.ToString());

            return auxString.ToString();
        }
        #endregion
    }
}
