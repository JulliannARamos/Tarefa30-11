using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_de_Produtos__Polimorfismo_
{
    class ProdutoUsado : Produto
    {

        DateTime fabricacao;

        public DateTime Fabricacao
        {
            get => fabricacao;
            set => fabricacao = value;
        }

        public ProdutoUsado() { }

        public ProdutoUsado(string nome, double preco) : base(nome, preco) { }

        public override string precoTag()
        {
            return Nome + " (Usado) - R$ " + Preco + "(Fabricação: " + fabricacao + ")";
        }
    }
}