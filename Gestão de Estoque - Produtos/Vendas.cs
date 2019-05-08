using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class Vendas : IDado
    {
        #region Atributos
        public int ID_Pedido { get; set; }
        public Produtos Produto { get; set; }
        public int Quantidade { get; set; }
        #endregion

        #region Construtor
        public Vendas(int ID_Pedido, Produtos Produto, int Quantidade)
        {
            this.ID_Pedido = ID_Pedido;
            this.Produto = Produto;
            this.Quantidade = Quantidade;
        }
        #endregion

        #region Métodos Interface
        public int CompareTo(object obj)
        {
            Vendas aux = (Vendas)(obj);

            if (ID_Pedido < aux.ID_Pedido)
                return -1;
            else if (ID_Pedido > aux.ID_Pedido)
                return 1;
            else
                return 0;            
        }
        public override bool Equals(object obj)
        {
            Vendas aux = (Vendas)(obj);

            return ID_Pedido == aux.ID_Pedido;
        }
        public override string ToString()
        {
            return ("ID Produto: " + Produto.ID + "; Nome: " + Produto.NomeProduto + "; Quantidade: " + Quantidade +".");
        }
        #endregion
    }
}
