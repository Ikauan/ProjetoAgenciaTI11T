using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;
using ProjetoAgenciaTI11T.Controller;

namespace ProjetoAgenciaTI11T.View
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text == "" | tbxEmail.Text == "" | tbxSenha.Text == "" | pcbImagem.Image == null)
            {
                MessageBox.Show("Prencha todas as informações corretamentes", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Clientes.NomeCli = tbxNome.Text;
                Clientes.EmailCli = tbxEmail.Text;
                Clientes.SenhaCli = tbxSenha.Text;
                if (pcbImagem.Image != null)
                {

                    MemoryStream memoryStream = new MemoryStream();

                    pcbImagem.Image.Save(memoryStream, pcbImagem.Image.RawFormat);
                    Clientes.ImgCli = memoryStream.ToArray();
                }

                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.cadastrarCliente();
            }
            LimparTela();

        }

        private void btnBuscarImagem_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma imagem (*.jpg*.png*.jpeg*)" + "|*.jpg;*.png;*.jpeg;";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pcbImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
            }
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            
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
                            pcbImagem.Image = null;
                        }
                        }
                }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
