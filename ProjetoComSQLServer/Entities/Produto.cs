using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComSQLServer.Entities {
    public class Produto {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto(int produtoID, string nome, int quantidade, double preco) {
            ProdutoID = produtoID;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;

        }
        public Produto(string nome, int quantidade, double preco) {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;

        }

    }
}
