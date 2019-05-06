using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class Fila : IEstruturaDados
    {
        #region Atributos
        public Elemento Primeiro { get; private set; } //controle
        public Elemento Ultimo { get; private set; } //controle
        #endregion

        #region Construtor
        public Fila()
        {
            this.Primeiro = new Elemento(null); //sentinela
            this.Ultimo = this.Primeiro; //no começo a primeira posição é igual a ultima
        }

        #endregion

        #region Métodos
        public void Inserir(IDado dado)
        {
            Elemento novo = new Elemento(dado);

            this.Ultimo.Prox = novo;
            this.Ultimo = novo;
        }

        public IDado Retirar()
        {
            if (this.Vazia()) return null;

            Elemento aux = this.Primeiro.Prox;

            if (aux.Prox != null)
            {
                this.Primeiro.Prox = aux.Prox; //aux.prox = primeiro.prox.prox
                aux.Prox = null;
            }
            else
            {
                this.Primeiro.Prox = aux.Prox;
                aux.Prox = null;
                this.Ultimo = this.Primeiro;
            }

            return aux.MeuDado;
        }

        public override string ToString()
        {
            StringBuilder auxImpressao = new StringBuilder();
            Elemento atual = Primeiro;
            int contador = 0;

            while (atual.Prox != null)
            {
                contador++;
                auxImpressao.AppendLine("Produto: " + contador + " " + atual.Prox.MeuDado.ToString() + "\n");
                atual = atual.Prox;
            }

            return auxImpressao.ToString();
        }

        public bool Vazia()
        {
            return (this.Primeiro == this.Ultimo);
        }
        #endregion
    }
}
