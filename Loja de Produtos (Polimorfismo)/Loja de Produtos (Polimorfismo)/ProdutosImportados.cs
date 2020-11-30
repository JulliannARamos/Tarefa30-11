using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_de_Produtos__Polimorfismo_
{
    class ProdutosImportados : Produto
    {

        double taxa;

        public double Taxa
        {
            get => taxa;
            set => taxa = value;
        }

        public ProdutosImportados() { }

        public ProdutosImportados(string nome, double preco) : base(nome, preco)
        {

        }

        public override string precoTag()
        {
            return Nome + " - R$ " + Preco + "(Taxa: " + taxa + ")";
        }

        public double precoTotal(double precoTotal)
        {
            return precoTotal = Preco + Taxa;
        }
    }
}
