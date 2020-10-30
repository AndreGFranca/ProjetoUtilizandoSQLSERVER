using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ProjetoComSQLServer.Model;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoComSQLServer.Entities;

namespace ProjetoComSQLServer {
    public partial class Login_Area : Form {
        
        public Login_Area() {
            
        InitializeComponent();
        }
        private void Btn_Sair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e) {

            this.Hide();
            
            Cadastro cadastro = new Cadastro(this);
            cadastro.ShowDialog();
        }

        private void Btn_Login_Click(object sender, EventArgs e) {
            Login login = new Login(Txt_Usuario.Text, Txt_Senha.Text);
            Usuario user = login.Logar();
            if (user != null && user.Nome != null && user.Nome != null ) {
                this.Hide();
                Produtos produto = new Produtos(user);
                produto.ShowDialog();
            }

            

        }
    }
}
