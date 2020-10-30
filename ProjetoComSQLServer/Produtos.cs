using ProjetoComSQLServer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoComSQLServer.Model {
    public partial class Produtos : Form {
        public Usuario User { get; set; }

        public OperacoesProduto operacoes;

        public Produtos(Usuario user) {
            operacoes = new OperacoesProduto();
            User = user;
            InitializeComponent();
            Mostrar_Tabela(operacoes.Procurar());
        }

        private void txt_IDProduto_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {

                e.Handled = true;
            }
        }

        private void txt_Qtd_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {

                e.Handled = true;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_Procurar_Click(object sender, EventArgs e) {
            
            Mostrar_Tabela( operacoes.Procurar());
        }

        private void btn_Adicionar_Click(object sender, EventArgs e) {
            if (txt_Nome_Produto.Text != "" && txt_Preco.Text != "" && txt_Qtd.Text != "") {
                double preco = Math.Round(float.Parse(txt_Preco.Text, CultureInfo.InvariantCulture), 2);
                operacoes.Adicionar(new Produto(txt_Nome_Produto.Text, int.Parse(txt_Qtd.Text), preco));
                Mostrar_Tabela(operacoes.Procurar());
            }
            
        }

        private void btn_AtualizarDados_Click(object sender, EventArgs e) {
            if (txt_IDProduto.Text != "" && txt_Nome_Produto.Text != "" && txt_Preco.Text != "" && txt_Qtd.Text != "") {
                double preco = Math.Round(float.Parse(txt_Preco.Text,CultureInfo.InvariantCulture), 2);
                operacoes.Atualizar(int.Parse(txt_IDProduto.Text),new Produto(txt_Nome_Produto.Text, int.Parse(txt_Qtd.Text),preco));
                Mostrar_Tabela(operacoes.Procurar());
            }
            
        }

        private void btn_Deletar_Click(object sender, EventArgs e) {
            if(txt_IDProduto.Text != ""){
                operacoes.Deletar(int.Parse(txt_IDProduto.Text));
                Mostrar_Tabela(operacoes.Procurar());
            }
        }

        public void Mostrar_Tabela(List<Produto> lista) {
            if (db_Grid.Rows.Count > 0) {
                db_Grid.Rows.Clear();
            }
            foreach(var a in lista){


                db_Grid.Rows.Add(a.ProdutoID,a.Nome, a.Quantidade, a.Preco);
                    

            }

        }
    }
}
