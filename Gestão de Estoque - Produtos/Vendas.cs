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
        public int ID_Vendas { get; set; }
        public Produtos Produto { get; set; }
        public int Quantidade { get; set; }
        #endregion

        #region Construtor
        public Vendas(int ID_Pedido, Produtos Produto, int Quantidade)
        {
            this.ID_Vendas = ID_Pedido;
            this.Produto = Produto;
            this.Quantidade = Quantidade;
        }
        #endregion

        #region Métodos Interface
        public int CompareTo(object obj)
        {
            Vendas aux = (Vendas)(obj);

            if (ID_Vendas < aux.ID_Vendas)
                return -1;
            else if (ID_Vendas > aux.ID_Vendas)
                return 1;
            else
                return 0;            
        }
        public override bool Equals(object obj)
        {
            Vendas aux = (Vendas)(obj);

            return ID_Vendas == aux.ID_Vendas;
        }
        public override string ToString()
        {
            return ("ID Produto: " + Produto.ID_Produto + "; Nome: " + Produto.NomeProduto + "; Quantidade: " + Quantidade +".");
        }
        #endregion
    }
}
