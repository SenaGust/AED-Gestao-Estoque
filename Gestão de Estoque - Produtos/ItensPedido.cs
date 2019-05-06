﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class ItensPedido : IDado
    {
        #region Atributos
        public int ID { get; set; }
        public Produtos Produto { get; set; }
        public int Quantidade { get; set; }
        #endregion

        #region Construtor
        public ItensPedido(int ID, Produtos Produto, int Quantidade)
        {
            this.ID = ID;
            this.Produto = Produto;
            this.Quantidade = Quantidade;
        }
        #endregion

        #region Métodos Interface
        public int CompareTo(object obj)
        {
            ItensPedido item = (ItensPedido)(obj);

            //Quando é menor, maior e igual

            return 0;
        }
        public override bool Equals(object obj)
        {
            ItensPedido item = (ItensPedido)(obj);

            //Quando é igual?

            return false;
        }
        public override string ToString()
        {
            return ("ID Produto: " + Produto.ID + "; Nome: " + Produto.NomeProduto + "; Quantidade: " + Quantidade + "; Preço: " + ValorTotal + ".");
        }
        #endregion
    }
}
