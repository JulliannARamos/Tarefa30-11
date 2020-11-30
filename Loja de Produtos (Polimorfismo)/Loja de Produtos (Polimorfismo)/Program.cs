using System;
using System.Collections.Generic;
using System.Globalization;

namespace Loja_de_Produtos__Polimorfismo_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            
            List<Produto> produtos = new List<Produto>();
           
            Console.WriteLine("Informe a quantidade de produtos:");
            count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Produto produto = new Produto();

                Console.WriteLine("Informe o nome do produto:");
                produto.Nome = Console.ReadLine();

                Console.WriteLine("Informe o valor do produto:");
                produto.Preco = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe se o produto é: Usado, Comum, Importado:");
                string tipo = Console.ReadLine();

                switch (tipo)
                {
                    case "Usado":
                        ProdutoUsado produtoUsado = new ProdutoUsado(produto.Nome, produto.Preco);
                        Console.WriteLine("Informe a data de fabricação (dd/mm/aaaa): ");
                        produtoUsado.Fabricacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        produtos.Add(produtoUsado);
                        break;

                    case "Comum":
                        produtos.Add(produto);
                        break;

                    case "Importado":
                        ProdutosImportados produtoImportado = new ProdutosImportados(produto.Nome, produto.Preco);
                        Console.WriteLine("Informe a Taxa: ");
                        produtoImportado.Taxa = double.Parse(Console.ReadLine());
                        produtos.Add(produtoImportado);
                        break;
                }

            }

            foreach (Produto obj in produtos)
            {
                Console.WriteLine(obj.precoTag());
            }

        }
    }
}
