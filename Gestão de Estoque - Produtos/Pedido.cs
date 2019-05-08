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
        public int Id { get; set; }
        public int QuantidadeProdutos { get; set; }
        #endregion

        #region Construtor
        public Pedido(int Id, int QuantidadeProdutos)
        {
            this.Id = Id;
            this.QuantidadeProdutos = QuantidadeProdutos;
        }
        #endregion

        #region Métodos

        #endregion

        #region Métodos Interface
        public int CompareTo(object obj) // Compara os pedidos usando o Id
        {
            Pedido aux = (Pedido)(obj);        

            if (Id < aux.Id)
                return -1;
            else if (Id > aux.Id)
                return 1;
            else
                return 0;            
        }
        public override bool Equals(object obj)
        {
            Pedido aux = (Pedido)(obj);

            return Id == aux.Id;            
        }
        public override string ToString()
        {
            StringBuilder auxString = new StringBuilder();

            auxString.AppendLine("Pedido nº" + Id);
            auxString.AppendLine("Quantidade de itens no pedido: " + QuantidadeProdutos);

            return auxString.ToString();
        }
        #endregion
    }
}
