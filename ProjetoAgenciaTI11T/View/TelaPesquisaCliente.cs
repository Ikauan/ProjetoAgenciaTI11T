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
    public partial class TelaPesquisaCliente : Form
    {
        public TelaPesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnBuscaCodCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um Código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxEmail.Text = string.Empty;
                tbxNome.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                tbxNome.Text = string.Empty;
                pcbImagem.Image = null;

            }
            else
            {
                Clientes.CodCli = Convert.ToInt32(tbxCodCli.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();


                if (Clientes.Retorno == "Não")
                {
                    tbxCodCli.Text = string.Empty;
                    tbxCodCli.Focus();
                    tbxCodCli.SelectAll();
                    tbxNome.Text = string.Empty;
                    tbxEmail.Text = string.Empty;
                    tbxSenha.Text = string.Empty;
                    pcbImagem.Image = null;
                    return;
                }
                else
                {
                    tbxNome.Text = Clientes.NomeCli;
                    tbxEmail.Text = Clientes.EmailCli;
                    tbxSenha.Text = Clientes.SenhaCli;

                    MemoryStream ms = new MemoryStream((byte[])Clientes.ImgCli);
                    pcbImagem.Image = Image.FromStream(ms);
                }
            }
        }

        private void TelaPesquisaCliente_Load(object sender, EventArgs e)
        {

        }

        private void tbxCodCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeletarCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um Código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxEmail.Text = string.Empty;
                tbxNome.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                tbxNome.Text = string.Empty;
                pcbImagem.Image = null;

            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir o Cliente" + tbxCodCli.Text + "?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.CodCli = Convert.ToInt32(tbxCodCli.Text);

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.deletarCliente();

                    tbxCodCli.Text = string.Empty;
                    tbxCodCli.Focus();
                    tbxCodCli.SelectAll();
                    tbxEmail.Text = string.Empty;
                    tbxNome.Text = string.Empty;
                    tbxSenha.Text = string.Empty;
                    pcbImagem.Image = null;
                }
            }
        }

        private void btnAlterarCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um Código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxEmail.Text = string.Empty;
                tbxNome.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                pcbImagem.Image = null;

            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do cliente" + tbxCodCli.Text + "?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.CodCli = Convert.ToInt32(tbxCodCli.Text);
                    Clientes.NomeCli = tbxNome.Text;
                    Clientes.EmailCli = tbxEmail.Text;
                    Clientes.SenhaCli = tbxSenha.Text;

                    MemoryStream ms = new MemoryStream();
                    pcbImagem.Image.Save(ms, pcbImagem.Image.RawFormat);
                    Clientes.ImgCli = ms.ToArray();

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.alterarCliente();

                }
            }
        }

        private void btnBuscarImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Escolha uma imagem (*.jpg*.png*.jpeg*)" + "|*.jpg;*.png;*.jpeg;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pcbImagem.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnBuscarNomeCli_Click(object sender, EventArgs e)
        {
            if(tbxNomeCli.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }
            Clientes.NomeCli = tbxNomeCli.Text;

            dataGridViewCliente.DataSource = ManipulaCliente.pesquisarNomeCliente();

            dataGridViewCliente.Columns[5].HeaderCell.Value = "Código";

            dataGridViewCliente.Columns[0].Visible = false;
            dataGridViewCliente.Columns[1].Visible = false;
            dataGridViewCliente.Columns[2].Visible = false;
            dataGridViewCliente.Columns[3].Visible = false;
            dataGridViewCliente.Columns[4].Visible = false;
            dataGridViewCliente.Columns[5].Visible = false;
            dataGridViewCliente.Columns[6].Visible = false;
            dataGridViewCliente.Columns[7].Visible = false;
            dataGridViewCliente.Columns[8].Visible = false;
            dataGridViewCliente.Columns[9].Visible = false;
            dataGridViewCliente.Columns[10].Visible = false;
            dataGridViewCliente.Columns[11].Visible = false;

        }
    }
}
