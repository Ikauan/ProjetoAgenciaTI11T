
namespace ProjetoAgenciaTI11T.View
{
    partial class Pacote
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDataVolta = new System.Windows.Forms.Label();
            this.lblDataIda = new System.Windows.Forms.Label();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.lblImagem = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.dateIda = new System.Windows.Forms.DateTimePicker();
            this.dateVolta = new System.Windows.Forms.DateTimePicker();
            this.rcbDescrição = new System.Windows.Forms.RichTextBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigem = new System.Windows.Forms.ComboBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar os Pacotes de Viagens";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(91, 149);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(47, 15);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(91, 107);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(47, 15);
            this.lblOrigem.TabIndex = 2;
            this.lblOrigem.Text = "Origem";
            this.lblOrigem.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDataVolta
            // 
            this.lblDataVolta.AutoSize = true;
            this.lblDataVolta.Location = new System.Drawing.Point(91, 222);
            this.lblDataVolta.Name = "lblDataVolta";
            this.lblDataVolta.Size = new System.Drawing.Size(76, 15);
            this.lblDataVolta.TabIndex = 3;
            this.lblDataVolta.Text = "Data da Volta";
            // 
            // lblDataIda
            // 
            this.lblDataIda.AutoSize = true;
            this.lblDataIda.Location = new System.Drawing.Point(91, 188);
            this.lblDataIda.Name = "lblDataIda";
            this.lblDataIda.Size = new System.Drawing.Size(66, 15);
            this.lblDataIda.TabIndex = 4;
            this.lblDataIda.Text = "Data da Ida";
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Location = new System.Drawing.Point(91, 253);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(58, 15);
            this.lblDescrição.TabIndex = 5;
            this.lblDescrição.Text = "Descrição";
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(415, 71);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(51, 15);
            this.lblImagem.TabIndex = 7;
            this.lblImagem.Text = "Imagem";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(91, 71);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor";
            // 
            // dateIda
            // 
            this.dateIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIda.Location = new System.Drawing.Point(163, 182);
            this.dateIda.Name = "dateIda";
            this.dateIda.Size = new System.Drawing.Size(102, 23);
            this.dateIda.TabIndex = 13;
            // 
            // dateVolta
            // 
            this.dateVolta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVolta.Location = new System.Drawing.Point(173, 216);
            this.dateVolta.Name = "dateVolta";
            this.dateVolta.Size = new System.Drawing.Size(102, 23);
            this.dateVolta.TabIndex = 14;
            // 
            // rcbDescrição
            // 
            this.rcbDescrição.Location = new System.Drawing.Point(155, 250);
            this.rcbDescrição.Name = "rcbDescrição";
            this.rcbDescrição.Size = new System.Drawing.Size(208, 86);
            this.rcbDescrição.TabIndex = 15;
            this.rcbDescrição.Text = "";
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(472, 46);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(133, 103);
            this.picImagem.TabIndex = 16;
            this.picImagem.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(530, 313);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 30);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(144, 146);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 23);
            this.cmbDestino.TabIndex = 18;
            // 
            // cmbOrigem
            // 
            this.cmbOrigem.FormattingEnabled = true;
            this.cmbOrigem.Location = new System.Drawing.Point(144, 104);
            this.cmbOrigem.Name = "cmbOrigem";
            this.cmbOrigem.Size = new System.Drawing.Size(121, 23);
            this.cmbOrigem.TabIndex = 19;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(130, 68);
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(100, 23);
            this.mtbValor.TabIndex = 20;
            // 
            // Pacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.cmbOrigem);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.rcbDescrição);
            this.Controls.Add(this.dateVolta);
            this.Controls.Add(this.dateIda);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.lblDescrição);
            this.Controls.Add(this.lblDataIda);
            this.Controls.Add(this.lblDataVolta);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Pacote";
            this.Text = "Pacote";
            this.Load += new System.EventHandler(this.Pacote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDataVolta;
        private System.Windows.Forms.Label lblDataIda;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DateTimePicker dateIda;
        private System.Windows.Forms.DateTimePicker dateVolta;
        private System.Windows.Forms.RichTextBox rcbDescrição;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigem;
        private System.Windows.Forms.MaskedTextBox mtbValor;
    }
}