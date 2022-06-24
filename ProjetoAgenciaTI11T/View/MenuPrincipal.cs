using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenciaTI11T.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrar Cadastrar = new TelaCadastrar();
            Cadastrar.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaFuncionario Funcionario = new TelaFuncionario();
            Funcionario.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Pacote Pacote = new Pacote();
            Pacote.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisaCliente telaPesquisaCliente = new TelaPesquisaCliente();
            telaPesquisaCliente.ShowDialog();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaPesquisaFuncionario telaPesquisaFuncionario = new TelaPesquisaFuncionario();
            telaPesquisaFuncionario.ShowDialog();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaPrincipalPacotes telaPrincipalPacotes = new TelaPrincipalPacotes();
            telaPrincipalPacotes.ShowDialog();
        }
    }
}
