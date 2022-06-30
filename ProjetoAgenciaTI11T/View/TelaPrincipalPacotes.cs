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
                rcbDescricao.Text = string.Empty;
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
                rcbDescricao.Text = Pacotes.DescPac;

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
                    rcbDescricao.Text = string.Empty;
                    picImagem.Image = null;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbxNomePac.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }
            Pacotes.OrigemPac = tbxNomePac.Text;

            dataGridView1.DataSource = ManipulaPacotes.pesquisarNomePacote();

            dataGridView1.Columns[5].HeaderCell.Value = "Código";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite um código de Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                mtbValor.Text = string.Empty;
                cmbOrigem.Text = string.Empty;
                cmbDestino.Text = string.Empty;
                rcbDescricao.Text = string.Empty;
                picImagem.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do Pacote" + tbxCodPac.Text + "?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Pacotes.CodPac = Convert.ToInt32(tbxCodPac.Text);
                    Pacotes.DescPac = rcbDescricao.Text;
                    Pacotes.DataPacIda = Convert.ToDateTime(dateIda.Value);
                    Pacotes.DataPacVolta = Convert.ToDateTime(dateVolta.Value);
                    Pacotes.DescPac = cmbDestino.Text;
                    Pacotes.OrigemPac = cmbOrigem.Text;
                    Pacotes.ValorPac = Convert.ToDecimal(mtbValor.Text);

                    MemoryStream ms = new MemoryStream();
                    picImagem.Image.Save(ms, picImagem.Image.RawFormat);
                    Pacotes.ImgPac = ms.ToArray();

                    ManipulaPacotes manipulaPacotes = new ManipulaPacotes();
                    manipulaPacotes.alterarPacote();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite um código de Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                mtbValor.Text = string.Empty;
                cmbOrigem.Text = string.Empty;
                cmbDestino.Text = string.Empty;
                rcbDescricao.Text = string.Empty;
                picImagem.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir o pacote" + tbxCodPac.Text + "?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    ManipulaPacotes manipulaPacotes = new ManipulaPacotes();
                    manipulaPacotes.deletarPacote();

                    Pacotes.CodPac = Convert.ToInt32(tbxCodPac.Text);
                    Pacotes.DescPac = rcbDescricao.Text;
                    Pacotes.DescPac = cmbDestino.Text;
                    Pacotes.OrigemPac = cmbOrigem.Text;
                    Pacotes.ValorPac = Convert.ToDecimal(mtbValor.Text);

                    MemoryStream ms = new MemoryStream();
                    picImagem.Image.Save(ms, picImagem.Image.RawFormat);
                    Pacotes.ImgPac = ms.ToArray();

                }
            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Escolha uma imagem (*.jpg*.png*.jpeg*)" + "|*.jpg;*.png;*.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picImagem.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
