
namespace ProjetoAgenciaTI11T.View
{
    partial class TelaPrincipalPacotes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImagem = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscaCodPac = new System.Windows.Forms.Button();
            this.cmbOrigem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.tbxCodPac = new System.Windows.Forms.TextBox();
            this.rcbDescricao = new System.Windows.Forms.RichTextBox();
            this.dateVolta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateIda = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDataIda = new System.Windows.Forms.Label();
            this.lblDataVolta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 357);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar pacotes por nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Origem,
            this.Destino,
            this.Data1,
            this.Data2,
            this.Descricao,
            this.Imagem,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(9, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 186);
            this.dataGridView1.TabIndex = 23;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Origem
            // 
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // Data1
            // 
            this.Data1.HeaderText = "Data Ida";
            this.Data1.Name = "Data1";
            // 
            // Data2
            // 
            this.Data2.HeaderText = "Data Volta";
            this.Data2.Name = "Data2";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.Name = "Imagem";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Buscar Pacotes por nome";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(226, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(260, 23);
            this.textBox4.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(492, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnImagem);
            this.tabPage2.Controls.Add(this.picImagem);
            this.tabPage2.Controls.Add(this.mtbValor);
            this.tabPage2.Controls.Add(this.btnBuscaCodPac);
            this.tabPage2.Controls.Add(this.cmbOrigem);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbDestino);
            this.tabPage2.Controls.Add(this.tbxCodPac);
            this.tabPage2.Controls.Add(this.rcbDescricao);
            this.tabPage2.Controls.Add(this.dateVolta);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dateIda);
            this.tabPage2.Controls.Add(this.btnCadastrar);
            this.tabPage2.Controls.Add(this.lblValor);
            this.tabPage2.Controls.Add(this.lblDestino);
            this.tabPage2.Controls.Add(this.lblDescrição);
            this.tabPage2.Controls.Add(this.lblOrigem);
            this.tabPage2.Controls.Add(this.lblDataIda);
            this.tabPage2.Controls.Add(this.lblDataVolta);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquiar pacotes por codigo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(514, 182);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(102, 23);
            this.btnImagem.TabIndex = 34;
            this.btnImagem.Text = "Buscar Imgaem";
            this.btnImagem.UseVisualStyleBackColor = true;
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picImagem.Location = new System.Drawing.Point(499, 73);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(133, 103);
            this.picImagem.TabIndex = 33;
            this.picImagem.TabStop = false;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(63, 55);
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(100, 23);
            this.mtbValor.TabIndex = 32;
            // 
            // btnBuscaCodPac
            // 
            this.btnBuscaCodPac.Location = new System.Drawing.Point(499, 22);
            this.btnBuscaCodPac.Name = "btnBuscaCodPac";
            this.btnBuscaCodPac.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaCodPac.TabIndex = 22;
            this.btnBuscaCodPac.Text = "Pesquisar";
            this.btnBuscaCodPac.UseVisualStyleBackColor = true;
            this.btnBuscaCodPac.Click += new System.EventHandler(this.btnBuscaCodPac_Click);
            // 
            // cmbOrigem
            // 
            this.cmbOrigem.FormattingEnabled = true;
            this.cmbOrigem.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Belo Horizonte"});
            this.cmbOrigem.Location = new System.Drawing.Point(77, 91);
            this.cmbOrigem.Name = "cmbOrigem";
            this.cmbOrigem.Size = new System.Drawing.Size(121, 23);
            this.cmbOrigem.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Buscar Pacotes por código";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "EUA, Nova Iorque",
            "Canadá, Vancouver",
            "Inglaterra, Londres"});
            this.cmbDestino.Location = new System.Drawing.Point(77, 133);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 23);
            this.cmbDestino.TabIndex = 30;
            // 
            // tbxCodPac
            // 
            this.tbxCodPac.Location = new System.Drawing.Point(206, 22);
            this.tbxCodPac.Name = "tbxCodPac";
            this.tbxCodPac.Size = new System.Drawing.Size(287, 23);
            this.tbxCodPac.TabIndex = 20;
            // 
            // rcbDescricao
            // 
            this.rcbDescricao.Location = new System.Drawing.Point(88, 237);
            this.rcbDescricao.Name = "rcbDescricao";
            this.rcbDescricao.Size = new System.Drawing.Size(208, 86);
            this.rcbDescricao.TabIndex = 29;
            this.rcbDescricao.Text = "";
            // 
            // dateVolta
            // 
            this.dateVolta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVolta.Location = new System.Drawing.Point(106, 203);
            this.dateVolta.Name = "dateVolta";
            this.dateVolta.Size = new System.Drawing.Size(102, 23);
            this.dateVolta.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateIda
            // 
            this.dateIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIda.Location = new System.Drawing.Point(96, 169);
            this.dateIda.Name = "dateIda";
            this.dateIda.Size = new System.Drawing.Size(102, 23);
            this.dateIda.TabIndex = 27;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(329, 266);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 30);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Alterar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(24, 58);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 26;
            this.lblValor.Text = "Valor";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(24, 136);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(47, 15);
            this.lblDestino.TabIndex = 21;
            this.lblDestino.Text = "Destino";
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Location = new System.Drawing.Point(24, 240);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(58, 15);
            this.lblDescrição.TabIndex = 25;
            this.lblDescrição.Text = "Descrição";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(24, 94);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(47, 15);
            this.lblOrigem.TabIndex = 22;
            this.lblOrigem.Text = "Origem";
            // 
            // lblDataIda
            // 
            this.lblDataIda.AutoSize = true;
            this.lblDataIda.Location = new System.Drawing.Point(24, 175);
            this.lblDataIda.Name = "lblDataIda";
            this.lblDataIda.Size = new System.Drawing.Size(66, 15);
            this.lblDataIda.TabIndex = 24;
            this.lblDataIda.Text = "Data da Ida";
            // 
            // lblDataVolta
            // 
            this.lblDataVolta.AutoSize = true;
            this.lblDataVolta.Location = new System.Drawing.Point(24, 209);
            this.lblDataVolta.Name = "lblDataVolta";
            this.lblDataVolta.Size = new System.Drawing.Size(76, 15);
            this.lblDataVolta.TabIndex = 23;
            this.lblDataVolta.Text = "Data da Volta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar Pacotes";
            // 
            // TelaPrincipalPacotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPrincipalPacotes";
            this.Text = "TelaPrincipalPacotes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscaCodPac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCodPac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.ComboBox cmbOrigem;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.RichTextBox rcbDescricao;
        private System.Windows.Forms.DateTimePicker dateVolta;
        private System.Windows.Forms.DateTimePicker dateIda;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDataIda;
        private System.Windows.Forms.Label lblDataVolta;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.PictureBox picImagem;
    }
}