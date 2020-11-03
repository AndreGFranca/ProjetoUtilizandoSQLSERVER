using System;
using ProjetoComSQLServer.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoComSQLServer {
    public partial class Cadastro : Form {
        public Form Form_Principal { get; set; }

        bool mouseClicked;
        Point clickedAt;

        public Cadastro(Form principal) {
        Form_Principal = principal;
        InitializeComponent();
        
        }
   

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Btn_voltar_Click(object sender, EventArgs e) {
            Form_Principal.Show();
            this.Close();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e) {
            CadastroUsuario cadastramentoUsuario = new CadastroUsuario(Txt_nome.Text, Txt_usuario.Text, Txt_senha.Text, Txt_senhaR.Text);
            if (cadastramentoUsuario.Cadastrar()) {
                this.Close();
                Form_Principal.Show();
            }
            
        }

        private void Cadastro_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) {
                return;
            }
            mouseClicked = true;
            clickedAt = e.Location;

        }

        private void Cadastro_MouseMove(object sender, MouseEventArgs e) {
            if (mouseClicked) {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void Cadastro_MouseUp(object sender, MouseEventArgs e) {
            mouseClicked = false;
        }
    }
}
