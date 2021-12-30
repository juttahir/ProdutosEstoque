using System;
using System.Globalization;

namespace ProdutosEstoque
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(int id, string nome, double preco, int estoque)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Estoque;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Estoque += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Estoque -= quantidade;
        }

        public override string ToString()
        {
            return "Seu produto é " 
                + Nome 
                + " código 0"
                + Id
                + ", no valor de R$:" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + " cada, e " 
                + Estoque 
                + " unidades, ficando no total: R$:" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + "." +
                "";
        }
    }
}
