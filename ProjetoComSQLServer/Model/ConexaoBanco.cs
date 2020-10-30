using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoComSQLServer.Model {
    class ConexaoBanco {
        private string conexaoString = "server=DESKTOP-2SI095J;Database=Bd_ProjetoComSqlServer;Integrated Security=SSPI;";
        SqlConnection con;

        public ConexaoBanco(){
            con = new SqlConnection(conexaoString);
        }
        public bool Conectar() {            
            con.Open();
            return true;
        }
        public void Desconectar() {
            con.Close();
        }
        public bool InserirDados(string comando) {
            Desconectar();
            if (Conectar()) {
                SqlCommand sqlCommand = new SqlCommand(comando);
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Dados cadastrados com sucesso!", "Sucesso!");
                Desconectar();
                return true;
            }
            
            return false;
        }

        public SqlDataReader SelecionarDados(string comando) {
            Desconectar();
            if (Conectar()) {
                SqlCommand sqlCommand = new SqlCommand(comando,con);
                
                //sqlCommand.ExecuteNonQuery();
                
                SqlDataReader reader = sqlCommand.ExecuteReader();                
                return reader;
            }
            MessageBox.Show("Não conseguiu se conectar ao banco");
            throw new Exception();
        }

        public bool Atualizar(string comando) {
            Desconectar();
            if (Conectar()) {
                SqlCommand sqlCommand = new SqlCommand(comando);
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Dados atualizados com sucesso!", "Sucesso!");
                Desconectar();
                return true;
            }

            return false;
        }
        public bool Deletar(string comando) {
            Desconectar();
            if (Conectar()) {
                SqlCommand sqlCommand = new SqlCommand(comando);
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Dados deletado com sucesso!", "Sucesso!");
                Desconectar();
                return true;
            }

            return false;
        }

    }
}
