using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos  
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila todasVendas = Arquivos.LeituraArquivoVendas("vendas.txt");
            Console.WriteLine(todasVendas.ToString());

            Fila todosProdutos = Arquivos.LeituraArquivoProdutos("arquivodeprodutos.txt");
            Console.WriteLine(todosProdutos.ToString());

            Arquivos.InserirVendasEmProdutos(todasVendas, todosProdutos);

            Console.WriteLine(todosProdutos.ToString());

            Console.WriteLine();
        }
    }
}
