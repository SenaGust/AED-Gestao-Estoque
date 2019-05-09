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
        public int ID_Produto { get; set; }
        public int Quantidade { get; set; }
        #endregion

        #region Construtor
        public Vendas(int Id_Venda, int Id_Produto, int Quantidade)
        {
            this.ID_Vendas = Id_Venda;
            this.ID_Produto = Id_Produto;
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
            return ("ID Produto: " + this.ID_Vendas + "; Nome: " + this.ID_Produto + "; Quantidade: " + Quantidade +".");
        }
        #endregion
    }
}
