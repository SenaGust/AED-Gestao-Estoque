﻿using System;
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
        public int ID_Produto { get; private set; }
        public string NomeProduto { get; private set; }
        public double PrecoCusto { get; set; }
        public double MargemLucro { get; set; }
        public double estoque_inicial { get; set; }
        public double estoque_minimo { get; set; }
        public double Imposto { get; set; }
        public Fila Todas_as_Vendas { get; set; }
        #endregion

        #region Construtor
        public Produtos(int ID_Produto, string NomeProduto, double Margem_Lucro,double Preco_custo, double Estoque_Inicial, double Estoque_minimo)
        {
            this.ID_Produto = ID_Produto;
            this.NomeProduto = NomeProduto;
            this.MargemLucro = Margem_Lucro;
            this.PrecoCusto = Preco_custo;
            this.estoque_inicial = Estoque_Inicial;
            this.estoque_minimo = Estoque_minimo;
            this.Todas_as_Vendas = new Fila();
        }

        public Produtos()
        {
            ID_Produto = 0;
            NomeProduto = null;
            MargemLucro = 0;
            PrecoCusto = 0;
            estoque_inicial = 0;
            estoque_minimo = 0;
            this.Todas_as_Vendas = null;
        }
        #endregion

        #region Métodos
        public void AdicionarVenda(Vendas venda)
        {
            this.Todas_as_Vendas.Inserir(venda);
        }
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
            Produtos aux = (Produtos)(obj);

            if (ID_Produto < aux.ID_Produto)
                return -1;
            else if (ID_Produto > aux.ID_Produto)
                return 1;
            else
                return 0;
        }
        public override bool Equals(object obj)
        {
            Produtos aux = (Produtos)(obj);

            return ID_Produto == aux.ID_Produto;
        }
        #endregion

        public override string ToString()
        {
            return ("Produto: " + this.NomeProduto + "\tPedidos: " + Todas_as_Vendas.ToString()); //vendas já vai usar o string da fila, portanto não preciso construir o toString dele aqui
        }

        //posso pegar tudo que as classes filhas imprimem que é igual e colocar aqui na classe produtos 
        //Nas classes filhas ficaria algo como "return "Categoria: x + base.tostring()"


    }
}
