using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    //cód_produto; nome; categoria; margem de lucro; preço de custo; estoque inicial; minimo estoque
    class Produtos : IDado
    {
        #region Atributos
        public string ID { get; private set; }
        public string NomeProduto { get; private set; }
        public double PrecoCusto { get; set; }
        public double MargemLucro { get; set; }
        public double estoque_inicial { get; set; }
        public double estoque_minimo { get; set; }
        public double Imposto { get; set; }
        public Fila Vendas { get; set; }
        #endregion

        #region Construtor
        public Produtos(string ID, string NomeProduto, double Margem_Lucro,double Preco_custo, double Estoque_Inicial, double Estoque_minimo)
        {
            this.ID = ID;
            this.NomeProduto = NomeProduto;
            this.MargemLucro = Margem_Lucro;
            this.PrecoCusto = Preco_custo;
            this.estoque_inicial = Estoque_Inicial;
            this.estoque_minimo = Estoque_minimo;
        }

        public Produtos()
        {

        }
        #endregion



        #region Métodos
        public double CalcImposto()
        {
            return (PrecoCusto + (PrecoCusto * MargemLucro)) * Imposto;
        }

        public double CalcPrecoVenda()
        {
            return PrecoCusto + (PrecoCusto * MargemLucro) + CalcImposto();
        }
        #endregion

        #region Métodos Interface

        public int CompareTo(object obj)
        {
            Pedido item = (Pedido)(obj);


            return 0;
        }
        public override bool Equals(object obj)
        {
            Pedido item = (Pedido)(obj);

            return false;
        }
        #endregion
    }
}
