namespace ProjetoComSQLServer.Model {
    partial class Produtos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txt_IDProduto = new System.Windows.Forms.TextBox();
            this.db_Grid = new System.Windows.Forms.DataGridView();
            this.db_ID_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_Nome_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_Qtd_Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_Preco_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nome_Produto = new System.Windows.Forms.TextBox();
            this.txt_Qtd = new System.Windows.Forms.TextBox();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_AtualizarDados = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IDProduto
            // 
            this.txt_IDProduto.Location = new System.Drawing.Point(15, 370);
            this.txt_IDProduto.Name = "txt_IDProduto";
            this.txt_IDProduto.Size = new System.Drawing.Size(61, 20);
            this.txt_IDProduto.TabIndex = 0;
            this.txt_IDProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDProduto_KeyPress);
            // 
            // db_Grid
            // 
            this.db_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.db_ID_Produto,
            this.db_Nome_Produto,
            this.db_Qtd_Estoque,
            this.db_Preco_Produto});
            this.db_Grid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.db_Grid.Location = new System.Drawing.Point(12, 12);
            this.db_Grid.Name = "db_Grid";
            this.db_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.db_Grid.Size = new System.Drawing.Size(441, 319);
            this.db_Grid.TabIndex = 1;
            // 
            // db_ID_Produto
            // 
            this.db_ID_Produto.HeaderText = "ID Produto";
            this.db_ID_Produto.Name = "db_ID_Produto";
            this.db_ID_Produto.ReadOnly = true;
            // 
            // db_Nome_Produto
            // 
            this.db_Nome_Produto.HeaderText = "Nome Produto";
            this.db_Nome_Produto.Name = "db_Nome_Produto";
            this.db_Nome_Produto.ReadOnly = true;
            // 
            // db_Qtd_Estoque
            // 
            this.db_Qtd_Estoque.HeaderText = "Quantidade";
            this.db_Qtd_Estoque.Name = "db_Qtd_Estoque";
            this.db_Qtd_Estoque.ReadOnly = true;
            // 
            // db_Preco_Produto
            // 
            this.db_Preco_Produto.HeaderText = "Preço";
            this.db_Preco_Produto.Name = "db_Preco_Produto";
            this.db_Preco_Produto.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Preço:";
            // 
            // txt_Nome_Produto
            // 
            this.txt_Nome_Produto.Location = new System.Drawing.Point(117, 370);
            this.txt_Nome_Produto.Name = "txt_Nome_Produto";
            this.txt_Nome_Produto.Size = new System.Drawing.Size(94, 20);
            this.txt_Nome_Produto.TabIndex = 6;
            // 
            // txt_Qtd
            // 
            this.txt_Qtd.Location = new System.Drawing.Point(248, 370);
            this.txt_Qtd.Name = "txt_Qtd";
            this.txt_Qtd.Size = new System.Drawing.Size(62, 20);
            this.txt_Qtd.TabIndex = 7;
            this.txt_Qtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qtd_KeyPress);
            // 
            // txt_Preco
            // 
            this.txt_Preco.Location = new System.Drawing.Point(353, 370);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(100, 20);
            this.txt_Preco.TabIndex = 8;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Sair.FlatAppearance.BorderSize = 2;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(464, 279);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(112, 52);
            this.btn_Sair.TabIndex = 9;
            this.btn_Sair.Text = "Sair da Aplicação";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_AtualizarDados
            // 
            this.btn_AtualizarDados.BackColor = System.Drawing.SystemColors.Info;
            this.btn_AtualizarDados.FlatAppearance.BorderSize = 2;
            this.btn_AtualizarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtualizarDados.Location = new System.Drawing.Point(464, 126);
            this.btn_AtualizarDados.Name = "btn_AtualizarDados";
            this.btn_AtualizarDados.Size = new System.Drawing.Size(113, 52);
            this.btn_AtualizarDados.TabIndex = 10;
            this.btn_AtualizarDados.Text = "Atualizar Dados";
            this.btn_AtualizarDados.UseVisualStyleBackColor = false;
            this.btn_AtualizarDados.Click += new System.EventHandler(this.btn_AtualizarDados_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Adicionar.FlatAppearance.BorderSize = 2;
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.Location = new System.Drawing.Point(464, 69);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(113, 51);
            this.btn_Adicionar.TabIndex = 11;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Procurar.FlatAppearance.BorderSize = 2;
            this.btn_Procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Procurar.Location = new System.Drawing.Point(465, 12);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(112, 51);
            this.btn_Procurar.TabIndex = 12;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = false;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.Brown;
            this.btn_Deletar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Deletar.FlatAppearance.BorderSize = 2;
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Deletar.Location = new System.Drawing.Point(464, 184);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(113, 52);
            this.btn_Deletar.TabIndex = 13;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(593, 407);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Procurar);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_AtualizarDados);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.txt_Qtd);
            this.Controls.Add(this.txt_Nome_Produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.db_Grid);
            this.Controls.Add(this.txt_IDProduto);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Produtos_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Produtos_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Produtos_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.db_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IDProduto;
        private System.Windows.Forms.DataGridView db_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_ID_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_Nome_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_Qtd_Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_Preco_Produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nome_Produto;
        private System.Windows.Forms.TextBox txt_Qtd;
        private System.Windows.Forms.TextBox txt_Preco;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_AtualizarDados;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.Button btn_Deletar;
    }
}