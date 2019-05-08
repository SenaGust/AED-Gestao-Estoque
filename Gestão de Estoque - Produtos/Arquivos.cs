using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class Arquivos
    {
        public Fila LeituraArquivoProdutos()
        {
            Fila Produtos = new Fila();

            //Arquivo
            //cód_produto; nome; categoria; margem de lucro; preço de custo; estoque inicial; minimo estoque
            //Bebidas = 1
            //Comidas = 2
            //Material de escritorio = 3

            //Utensilhos = 4

            return Produtos;
        }

        public void LeituraArquivoPedidos()
        {

            //Arquivo
            //Cod_pedido; Qtde_produtos

        }

        public void LeituraArquivoVendas()
        {

            //Arquivo
            //Cod_pedido; Cod_Produto; Qtd_Vendida

        }
    }
}
