﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Estoque___Produtos
{
    class UtensiliosDomesticos : Produtos
    {
        #region Construtor
        public UtensiliosDomesticos(string id, string nome, double margem_lucro, double preco, double estoque_inicial, double min_estoque) : base(id, nome, margem_lucro, preco, estoque_inicial, min_estoque)
        {
            Imposto = 0.35;
        }
        #endregion

        #region Métodos Interface
        public override string ToString()
        {
            return String.Format("Id: {0}; Categoria: Utensilhos Domesticos; Nome do produto: {1}; Custo: {2}; Margem de lucro: {3}",
                ID, NomeProduto, PrecoCusto, MargemLucro);
        }
        #endregion
    }
}
