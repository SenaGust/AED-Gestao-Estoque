using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class Comidas : Produtos
    {
        #region Construtor
        public Comidas(int id, string nome, double margem_lucro, double preco, double estoque_inicial, double min_estoque) : base(id, nome, margem_lucro, preco, estoque_inicial, min_estoque)
        {
            Imposto = 0.1;
        }
        #endregion

        

        #region Métodos Interface
        public override string ToString()
        {
            return String.Format("Id: {0}; Categoria: Comidas; Nome do produto: {1}; Custo: {2}; Margem de lucro: {3}",
                ID_Produto, NomeProduto, PrecoCusto, MargemLucro);
        }
        #endregion
    }
}
