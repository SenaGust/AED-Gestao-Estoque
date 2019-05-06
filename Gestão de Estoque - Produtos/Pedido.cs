using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class Pedido
    {
        #region Atributos
        public int Id { get; set; }
        public Fila Itens { get; private set; }
        #endregion

        #region Construtor
        public Pedido(int Id)
        {
            this.Id = Id;
            this.Itens = new Fila();
        }
        #endregion

        #region Métodos
        public void InserirProduto(Produtos produto)
        {
            //Transformo o produto em um item de pedido


            Itens.Inserir(produto);
        }
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
