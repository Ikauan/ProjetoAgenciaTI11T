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
                MessageBox.Show("Digite um Código de Cliente","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);

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
                tbxNome.Text = Clientes.NomeCli;
                tbxEmail.Text = Clientes.EmailCli;
                tbxSenha.Text = Clientes.SenhaCli;

                MemoryStream ms = new MemoryStream((byte[])Clientes.ImgCli);
                pcbImagem.Image = Image.FromStream(ms);

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
            }
        }

        private void TelaPesquisaCliente_Load(object sender, EventArgs e)
        {

        }

        private void tbxCodCli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
