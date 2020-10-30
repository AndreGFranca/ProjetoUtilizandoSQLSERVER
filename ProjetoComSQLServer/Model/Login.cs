using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoComSQLServer.Entities;

namespace ProjetoComSQLServer.Model {
    class Login {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Login(string usuario, string senha) {
            Usuario = usuario;
            Senha = senha;
        }

        ConexaoBanco conexao = new ConexaoBanco();
        public Usuario Logar() {
                string comando = $"SELECT id_user, user_nickname, user_fullname, user_password " +
                                 $"FROM tb_usuarios " +
                                $"WHERE user_nickname = '{Usuario}' AND user_password = '{Senha}'";
                SqlDataReader dados = conexao.SelecionarDados(comando);
                
                
                if (dados.Read()) {
                Usuario user = new Usuario(dados[1].ToString(), dados[2].ToString());
                dados.Close();
                
                    return user;
                }
                else {
                MessageBox.Show("Usuário ou senha invalido(s)");
                    return null;
                }
            
            
            

            
            

        }

    }
}
