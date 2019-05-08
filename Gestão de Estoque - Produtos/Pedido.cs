using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class Pedido : IDado   //não vai ter relação nenhuma com a árvore 
    {
        #region Atributos
        public int ID_Pedido { get; set; }
        public int QuantidadeProdutos { get; set; }
        #endregion

        #region Construtor
        public Pedido(int ID_Pedido, int QuantidadeProdutos)
        {
            this.ID_Pedido = ID_Pedido;
            this.QuantidadeProdutos = QuantidadeProdutos;
        }
        #endregion

        #region Métodos

        #endregion

        #region Métodos Interface
        public int CompareTo(object obj) // Compara os pedidos usando o Id
        {
            Pedido aux = (Pedido)(obj);        

            if (ID_Pedido < aux.ID_Pedido)
                return -1;
            else if (ID_Pedido > aux.ID_Pedido)
                return 1;
            else
                return 0;            
        }
        public override bool Equals(object obj)
        {
            Pedido aux = (Pedido)(obj);

            return ID_Pedido == aux.ID_Pedido;            
        }
        public override string ToString()
        {
            StringBuilder auxString = new StringBuilder();

            auxString.AppendLine("Pedido nº" + ID_Pedido);
            auxString.AppendLine("Quantidade de itens no pedido: " + QuantidadeProdutos);

            return auxString.ToString();
        }
        #endregion
    }
}
