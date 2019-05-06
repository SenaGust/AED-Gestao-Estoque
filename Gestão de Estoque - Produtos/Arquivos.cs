using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class Arquivos
    {
        public Estoque EstoqueInicial()
        {
            Estoque estoque = new Estoque();

            //Arquivo
            //cód_produto; nome; categoria; margem de lucro; preço de custo; estoque inicial; minimo estoque
            //Bebidas = 1
            //Comidas = 2
            //Material de escritorio = 3

            //Utensilhos = 4

            return estoque;
        }

        public Fila Pedidos()
        {
            Fila pedidos = new Fila(); //Seria uma fila de Pedido

            //Arquivo
            //Cod_pedido; Qtde_produtos

            return pedidos;
        }

        public Fila Vendas()
        {
            Fila vendas = new Fila(); //seria uma fila de itensPedido

            //Arquivo
            //Cod_pedido; Cod_Produto; Qtd_Vendida

            return vendas;
        }
    }
}
