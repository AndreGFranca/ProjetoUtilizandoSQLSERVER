using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoComSQLServer.Model {
    class CadastroUsuario {
        ConexaoBanco conexao = new ConexaoBanco();
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string SenhaR { get; set; }

        public CadastroUsuario(string nome, string usuario,string senha, string senhaR) {
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
            SenhaR = senhaR;
        }

        public bool Cadastrar() {
            string inserirDados = $"INSERT INTO tb_usuarios(user_nickname,user_fullname,user_password) values('{Usuario}','{Nome}','{Senha}')";
            if (Senha == SenhaR) {
                conexao.InserirDados(inserirDados);
                return true;
            }
            else {
                MessageBox.Show("Senhas não conferem", "Senha");
                return false;
            }

        }

    }
}
