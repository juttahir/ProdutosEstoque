using System;
using System.Globalization;

namespace ProdutosEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int id = random.Next(100, 999);
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Valor: R$:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int estoque = int.Parse(Console.ReadLine());

            Produto p = new Produto(id, nome, preco, estoque);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}
