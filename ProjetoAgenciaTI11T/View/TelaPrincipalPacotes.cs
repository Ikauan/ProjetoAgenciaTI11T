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
    public partial class TelaPrincipalPacotes : Form
    {
        public TelaPrincipalPacotes()
        {
            InitializeComponent();
        }

        private void btnBuscaCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite um Código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                mtbValor.Text = string.Empty;
                cmbOrigem.Text = string.Empty;
                cmbDestino.Text = string.Empty;
                dateIda.Text = string.Empty;
                dateVolta.Text = string.Empty;
                rcbDescrição.Text = string.Empty;
                picImagem.Image = null;

            }
            else
            {

                Pacotes.CodPac = Convert.ToInt32(tbxCodPac.Text);
                ManipulaPacotes manipulaPacotes = new ManipulaPacotes();
                manipulaPacotes.pesquisarCodigoPacotes();
                mtbValor.Text = Convert.ToString(Pacotes.ValorPac);
                cmbOrigem.Text = Pacotes.OrigemPac;
                cmbDestino.Text = Pacotes.DestinoPac;
                rcbDescrição.Text = Pacotes.DescPac;

                MemoryStream ms = new MemoryStream((byte[])Pacotes.ImgPac);
                picImagem.Image = Image.FromStream(ms);

                if (Pacotes.Retorno == "Não")
                {
                    tbxCodPac.Text = string.Empty;
                    tbxCodPac.Focus();
                    tbxCodPac.SelectAll();
                    mtbValor.Text = string.Empty;
                    cmbOrigem.Text = string.Empty;
                    cmbDestino.Text = string.Empty;
                    dateIda.Text = string.Empty;
                    dateVolta.Text = string.Empty;
                    rcbDescrição.Text = string.Empty;
                    picImagem.Image = null;
                }
            }
        }
    }
}
