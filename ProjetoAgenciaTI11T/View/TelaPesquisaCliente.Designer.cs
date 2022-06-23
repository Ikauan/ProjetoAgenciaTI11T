
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaPesquisaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisaCliente));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarNomeCli = new System.Windows.Forms.Button();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlterarCli = new System.Windows.Forms.Button();
            this.btnDeletarCli = new System.Windows.Forms.Button();
            this.btnBuscarImagem = new System.Windows.Forms.Button();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxCodCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscaCodCli = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(291, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(232, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pesquisar Cliente";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(97, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 318);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCliente);
            this.tabPage1.Controls.Add(this.btnBuscarNomeCli);
            this.tabPage1.Controls.Add(this.tbxNomeCli);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar por Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nome,
            this.Email,
            this.Foto});
            this.dataGridViewCliente.Location = new System.Drawing.Point(58, 88);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersVisible = false;
            this.dataGridViewCliente.RowTemplate.Height = 25;
            this.dataGridViewCliente.Size = new System.Drawing.Size(474, 181);
            this.dataGridViewCliente.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            // 
            // btnBuscarNomeCli
            // 
            this.btnBuscarNomeCli.Location = new System.Drawing.Point(474, 29);
            this.btnBuscarNomeCli.Name = "btnBuscarNomeCli";
            this.btnBuscarNomeCli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNomeCli.TabIndex = 2;
            this.btnBuscarNomeCli.Text = "Buscar";
            this.btnBuscarNomeCli.UseVisualStyleBackColor = true;
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Location = new System.Drawing.Point(217, 28);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(251, 23);
            this.tbxNomeCli.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o Nome do Cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAlterarCli);
            this.tabPage2.Controls.Add(this.btnDeletarCli);
            this.tabPage2.Controls.Add(this.btnBuscarImagem);
            this.tabPage2.Controls.Add(this.pcbImagem);
            this.tabPage2.Controls.Add(this.tbxSenha);
            this.tabPage2.Controls.Add(this.tbxEmail);
            this.tabPage2.Controls.Add(this.tbxNome);
            this.tabPage2.Controls.Add(this.lblSenha);
            this.tabPage2.Controls.Add(this.lblEmail);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Controls.Add(this.tbxCodCli);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnBuscaCodCli);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisar por Código";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCli
            // 
            this.btnAlterarCli.Location = new System.Drawing.Point(190, 238);
            this.btnAlterarCli.Name = "btnAlterarCli";
            this.btnAlterarCli.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCli.TabIndex = 22;
            this.btnAlterarCli.Text = "Alterar";
            this.btnAlterarCli.UseVisualStyleBackColor = true;
            // 
            // btnDeletarCli
            // 
            this.btnDeletarCli.Location = new System.Drawing.Point(290, 238);
            this.btnDeletarCli.Name = "btnDeletarCli";
            this.btnDeletarCli.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCli.TabIndex = 21;
            this.btnDeletarCli.Text = "Deletar";
            this.btnDeletarCli.UseVisualStyleBackColor = true;
            // 
            // btnBuscarImagem
            // 
            this.btnBuscarImagem.Location = new System.Drawing.Point(428, 191);
            this.btnBuscarImagem.Name = "btnBuscarImagem";
            this.btnBuscarImagem.Size = new System.Drawing.Size(104, 23);
            this.btnBuscarImagem.TabIndex = 20;
            this.btnBuscarImagem.Text = "Buscar Imagem";
            this.btnBuscarImagem.UseVisualStyleBackColor = true;
            // 
            // pcbImagem
            // 
            this.pcbImagem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pcbImagem.Location = new System.Drawing.Point(427, 85);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(105, 100);
            this.pcbImagem.TabIndex = 19;
            this.pcbImagem.TabStop = false;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(71, 162);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(147, 23);
            this.tbxSenha.TabIndex = 18;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(71, 124);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(294, 23);
            this.tbxEmail.TabIndex = 17;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(71, 86);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(294, 23);
            this.tbxNome.TabIndex = 16;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(24, 165);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 15);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(24, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(24, 89);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // tbxCodCli
            // 
            this.tbxCodCli.Location = new System.Drawing.Point(211, 36);
            this.tbxCodCli.Name = "tbxCodCli";
            this.tbxCodCli.Size = new System.Drawing.Size(262, 23);
            this.tbxCodCli.TabIndex = 2;
            this.tbxCodCli.TextChanged += new System.EventHandler(this.tbxCodCli_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar Cliente por Código";
            // 
            // btnBuscaCodCli
            // 
            this.btnBuscaCodCli.Location = new System.Drawing.Point(479, 36);
            this.btnBuscaCodCli.Name = "btnBuscaCodCli";
            this.btnBuscaCodCli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaCodCli.TabIndex = 0;
            this.btnBuscaCodCli.Text = "Buscar";
            this.btnBuscaCodCli.UseVisualStyleBackColor = true;
            this.btnBuscaCodCli.Click += new System.EventHandler(this.btnBuscaCodCli_Click);
            // 
            // TelaPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPesquisaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Viagens";
            this.Load += new System.EventHandler(this.TelaPesquisaCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscarNomeCli;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCodCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscaCodCli;
        private System.Windows.Forms.Button btnAlterarCli;
        private System.Windows.Forms.Button btnDeletarCli;
        private System.Windows.Forms.Button btnBuscarImagem;
        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
    }
}