using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    abstract class Produtos : IDado
    {
        #region Atributos
        public string ID { get; private set; }
        public string NomeProduto { get; private set; }
        public double PrecoCusto { get; set; }
        public double MargemLucroMIN { get; set; }
        public double MargemLucroMAX { get; set; }
        public double Imposto { get; set; }
        #endregion

        #region Construtor
        public Produtos(string ID, string NomeProduto, double PrecoCusto, double MargemLucroMIN, double MargemLucroMAX)
        {
            this.ID = ID;
            this.NomeProduto = NomeProduto;
            this.PrecoCusto = PrecoCusto;
            this.MargemLucroMIN = MargemLucroMIN;
            this.MargemLucroMAX = MargemLucroMAX;
        }
        #endregion

        #region Métodos
        public double CalcImposto()
        {
            return (PrecoCusto + (PrecoCusto * MargemLucroMIN)) * Imposto;
        }

        public double CalcPrecoVenda()
        {
            return PrecoCusto + (PrecoCusto * MargemLucroMIN) + CalcImposto();
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
            //feito nas classes filhas
            return null;
        }
        #endregion
    }
}
