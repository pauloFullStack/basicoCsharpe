using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsultas2
{
    internal class Produtos
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public string? Categoria { get; set; }


        public static List<Produtos> GetProdutos()
        {
            List<Produtos> produtos = new List<Produtos>()
            {
                new Produtos { Id = 1, Nome = "Camiseta", Preco = 29.99, Estoque = 50, Categoria = "Roupas" },
                new Produtos { Id = 2, Nome = "Meia Soc.", Preco = 89.90, Estoque = 20, Categoria = "Roupas" },
                new Produtos { Id = 3, Nome = "Calça jeans", Preco = 89.90, Estoque = 20, Categoria = "Roupas" },
                new Produtos { Id = 4, Nome = "Tênis Nike", Preco = 199.99, Estoque = 10, Categoria = "Calçados" },
                new Produtos { Id = 5, Nome = "Celular NK", Preco = 1499.99, Estoque = 9, Categoria = "Eletrônicos" },
                new Produtos { Id = 6, Nome = "Notebook", Preco = 4599.99, Estoque = 6, Categoria = "Eletrônicos" },
                new Produtos { Id = 7, Nome = "Mochila", Preco = 139.90, Estoque = 30, Categoria = "Acessórios" },
                new Produtos { Id = 8, Nome = "Relógio", Preco = 399.90, Estoque = 15, Categoria = "Acessórios" },
                new Produtos { Id = 9, Nome = "Cadeira", Preco = 799.99, Estoque = 8, Categoria = "Móveis" },
                new Produtos { Id = 10, Nome = "Mesa Sala", Preco = 2499.99, Estoque = 7, Categoria = "Móveis" },
                new Produtos { Id = 11, Nome = "Smart TV", Preco = 3999.99, Estoque = 4, Categoria = "Eletrônicos" },
                new Produtos { Id = 12, Nome = "Cadeira", Preco = 699.99, Estoque = 8, Categoria = "Móveis" },
            };

            return produtos;
        }
    }
}
