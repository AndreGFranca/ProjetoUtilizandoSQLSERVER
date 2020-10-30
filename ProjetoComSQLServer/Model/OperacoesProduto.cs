using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoComSQLServer.Entities;
using ProjetoComSQLServer.Model;

namespace ProjetoComSQLServer.Model {
    public class OperacoesProduto {
        ConexaoBanco conexao = new ConexaoBanco();
        //Procurar
       /* public List<Produto> Procurar(int id) {
            string comando = $"SELECT * " +
                             $"FROM tb_productos " +
                             $"WHERE id_product = {id}";
            SqlDataReader dados = conexao.SelecionarDados(comando);
            
            List<Produto> listaResultado = new List<Produto>();
            while (dados.Read()) {
                listaResultado.Add(new Produto(dados[1].ToString(), int.Parse(dados[2].ToString()), double.Parse(dados[3].ToString())));
            }
            return listaResultado;
        }
        public List<Produto> Procurar(string nome) {
            string comando = $"SELECT * " +
                 $"FROM tb_productos " +
                 $"WHERE product_name = {nome}";
            SqlDataReader dados = conexao.SelecionarDados(comando);

            List<Produto> listaResultado = new List<Produto>();
            while (dados.Read()) {
                listaResultado.Add(new Produto(dados[1].ToString(), int.Parse(dados[2].ToString()), double.Parse(dados[3].ToString())));
            }
            return listaResultado;
        }
        public List<Produto> Procurar(int? qtd) {
            string comando = $"SELECT * " +
                 $"FROM tb_productos " +
                 $"WHERE product_quantity = {qtd}";
            SqlDataReader dados = conexao.SelecionarDados(comando);

            List<Produto> listaResultado = new List<Produto>();
            while (dados.Read()) {
                listaResultado.Add(new Produto(dados[1].ToString(), int.Parse(dados[2].ToString()), double.Parse(dados[3].ToString())));
            }
            return listaResultado;
        }
        public List<Produto> Procurar(double preco) {
            string comando = $"SELECT * " +
                             $"FROM tb_productos " +
                             $"WHERE product_price = {preco}";
            SqlDataReader dados = conexao.SelecionarDados(comando);

            List<Produto> listaResultado = new List<Produto>();
            while (dados.Read()) {
                listaResultado.Add(new Produto(dados[1].ToString(), int.Parse(dados[2].ToString()), double.Parse(dados[3].ToString())));
            }
            return listaResultado;
        }*/
        public List<Produto> Procurar() {
            string comando = $"SELECT * FROM tb_produtos";
            SqlDataReader dados = conexao.SelecionarDados(comando);

            List<Produto> listaResultado = new List<Produto>();
            while (dados.Read()) {
                listaResultado.Add(new Produto(int.Parse(dados[0].ToString()),dados[1].ToString(), int.Parse(dados[2].ToString()), Convert.ToDouble(dados[3].ToString()) ));
               

            }
            dados.Close();

            return listaResultado;
        }

        //Adicionar
        public void Adicionar(Produto produto) {
            string comando = $"INSERT INTO tb_produtos(product_name, product_quantity, product_price)" +
                             $"values('{produto.Nome}',{produto.Quantidade},{produto.Preco.ToString(CultureInfo.InvariantCulture)}) ";
            conexao.InserirDados(comando);
            
        }
        //Modificar
        public void Atualizar(int id, Produto produto) {
            string comando = $"UPDATE tb_produtos " +
                             $"SET product_name = '{produto.Nome}', product_quantity = {produto.Quantidade}, product_price = {produto.Preco.ToString(CultureInfo.InvariantCulture)} " +
                             $"WHERE id_product = {id}";
            conexao.Atualizar(comando);
            

        }
        //Deletar

        public void Deletar(int id) {
            string comando = $"DELETE FROM tb_produtos " +                             
                             $"WHERE id_product = {id}";
            conexao.Deletar(comando);
            
        }

    }
}
