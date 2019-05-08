using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gestão_de_Estoque___Produtos
{
    class Arquivos
    {
        public Fila LeituraArquivoProdutos(string arq1)
        {
            Fila Produtos = new Fila();

            if(!File.Exists(arq1))
            {
                Console.WriteLine("\nArquivo referente aos produtos não pôde ser encontrado. ");
                Console.ReadKey();
            }

            StreamReader arquivo1 = new StreamReader(arq1);
            string linha;
            string[] vetor_aux_arq1;

            while(!arquivo1.EndOfStream)
            {
                linha = arquivo1.ReadLine();
                vetor_aux_arq1 = linha.Split(';');

                if(vetor_aux_arq1.Length==7)
                {
                    IDado dado = null;

                    //cód_produto; nome; categoria; margem de lucro; preço de custo; estoque inicial; minimo estoque

                    switch (int.Parse(vetor_aux_arq1[2])) //terceira posição da linha do arquivo; referente a categoria do produto
                    {
                        case 1:                      //id              nome                margem de lucro                  preço de custo                 estoque inicial                   estoque minimo     
                            dado = new Bebidas(vetor_aux_arq1[0], vetor_aux_arq1[1], double.Parse(vetor_aux_arq1[2]), double.Parse(vetor_aux_arq1[3]), double.Parse(vetor_aux_arq1[4]), double.Parse(vetor_aux_arq1[5]));
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                }
            }

            //Arquivo
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
