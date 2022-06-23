using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;
using ProjetoAgenciaTI11T.Controller;
using System.IO;

namespace ProjetoAgenciaTI11T.View
{
    public partial class Pacote : Form
    {
        private object pcbImagem;

        public Pacote()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pacote_Load(object sender, EventArgs e)
        {

        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            opfImagem.Filter = "Escolha uma imagem (*.jpg*.png*.jpeg*)" + "|*.jpg;*.png;*.jpeg;";
            if (opfImagem.ShowDialog() == DialogResult.OK)
            {
                picImagem.Image = Image.FromFile(opfImagem.FileName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (mtbValor.Text == "" | cmbOrigem.Text == "" | cmbDestino.Text == "" | dateIda.Value > dateVolta.Value | rcbDescrição.Text == "" | picImagem.Image == null)
            {
                MessageBox.Show("Preencha todas as informações corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pacotes.ValorPac = Convert.ToDecimal(mtbValor.Text);
                Pacotes.OrigemPac = cmbOrigem.Text;
                Pacotes.DestinoPac = cmbDestino.Text;
                Pacotes.DataPacIda = dateIda.Value;
                Pacotes.DataPacVolta = dateVolta.Value;
                Pacotes.DescPac = rcbDescrição.Text;
                if (picImagem.Image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();

                    picImagem.Image.Save(memoryStream, picImagem.Image.RawFormat);
                    Pacotes.ImgPac = memoryStream.ToArray();
                }

                ManipulaPacotes manipulaPacotes = new ManipulaPacotes();
                manipulaPacotes.cadastrarPacotes();
            }
            LimparTela();
        }

        public void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = String.Empty;
                }
                if (ctl is PictureBox)
                {
                    picImagem.Image = null;
                }
            }
        }

    }
}
