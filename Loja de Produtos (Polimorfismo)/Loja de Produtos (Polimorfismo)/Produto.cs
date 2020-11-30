using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_de_Produtos__Polimorfismo_
{
    class Produto
    {

        string nome;
        double preco;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public double Preco
        {
            get => preco;
            set => preco = value;
        }

        public Produto() { }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string precoTag()
        {
            return Nome + " - R$ " + Preco;
        }
    }
}
