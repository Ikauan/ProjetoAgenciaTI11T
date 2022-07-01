using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Controller;
using ProjetoAgenciaTI11T.Model;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaCadastarVendas : Form
    {
        public TelaCadastarVendas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbxValor.Text == "" | tbxCodCliente.Text == "" | tbxCodFuncionario.Text == "" | tbxCodPacote.Text == "")
            {
                MessageBox.Show("Preencha todas as informações corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                Vendas.PagoVen = Convert.ToInt32(tbxValor.Text);
                Clientes.CodCli = Convert.ToInt32(tbxCodCliente.Text);
                Funcionario.CodFun = Convert.ToInt32(tbxCodFuncionario.Text);
                Pacotes.CodPac = Convert.ToInt32(tbxCodPacote.Text);

                ManipulaVendas manipulaVendas = new ManipulaVendas();
                manipulaVendas.cadastrarVenda();
            }
            if (Vendas.Retorno == "Sim")
            {
                LimparTela();
                return;
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            if (tbxCodCliente.Text == "")
            {
                MessageBox.Show("Digite um código de cliente","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCodCliente.Text = string.Empty;
                tbxCodCliente.Focus();
                tbxCodCliente.SelectAll();
            }
            else
            {
                Clientes.CodCli = Convert.ToInt32(tbxCodCliente.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();
                tbxCodCliente.Text = Clientes.CodCli.ToString();
                tbxNomeCliente.Text = Clientes.NomeCli;
            }
            if (Clientes.Retorno == "Não")
            {
                tbxCodCliente.Text = string.Empty;
                tbxCodCliente.Focus();
                tbxCodCliente.SelectAll();
                tbxNomeCliente.Text = string.Empty;
                return;
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if(tbxCodFuncionario.Text == "")
            {
                MessageBox.Show("Digite um código de funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodFuncionario.Text = string.Empty;
                tbxCodFuncionario.Focus();
                tbxCodFuncionario.SelectAll();
            }
            else
            {
                Funcionario.CodFun = Convert.ToInt32(tbxCodFuncionario.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pequisarCodigoFuncionario();
                tbxCodFuncionario.Text = Funcionario.CodFun.ToString();
                tbxNomeFuncionario.Text = Funcionario.NomeFun;
            }
            if (Funcionario.Retono == "")
            {
                tbxCodFuncionario.Text = string.Empty;
                tbxCodFuncionario.Focus();
                tbxCodFuncionario.SelectAll();
                tbxNomeFuncionario.Text = string.Empty;
                return;
            }
        }

        private void btnPacote_Click(object sender, EventArgs e)
        {
            if (tbxCodPacote.Text == "")
            {
                MessageBox.Show("Digite um código de pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodPacote.Text = string.Empty;
                tbxCodPacote.Focus();
                tbxCodPacote.SelectAll();
                tbxOrigemPacote.Text = string.Empty;
                
            }
            else
            {
                Pacotes.CodPac = Convert.ToInt32(tbxCodPacote.Text);
                ManipulaPacotes manipulaPacote = new ManipulaPacotes();
                manipulaPacote.pesquisarCodigoPacotes();

                tbxCodPacote.Text = Pacotes.CodPac.ToString();
                tbxOrigemPacote.Text = Pacotes.OrigemPac;
                

            }
            if (Pacotes.Retorno == "Não")
            {
                tbxCodPacote.Text = string.Empty;
                tbxCodPacote.Focus();
                tbxCodPacote.SelectAll();
                tbxOrigemPacote.Text = string.Empty;

                return;
            }           
        }

        public void fecharCadastro()
        {
            this.Close();
        }
        public void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }
    }
}
