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
using System.IO;


namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaPesquisaFuncionario : Form
    {
        public TelaPesquisaFuncionario()
        {
            InitializeComponent();
        }

        private void btnBuscaCodFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um Código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxEmail.Text = string.Empty;
                tbxNome.Text = string.Empty;
                tbxSenha.Text = string.Empty;
                tbxNome.Text = string.Empty;

            }
            else
            {
                
                Funcionario.CodFun = Convert.ToInt32(tbxCodFun.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pequisarCodigoFuncionario();
                tbxNome.Text = Funcionario.NomeFun;
                tbxEmail.Text = Funcionario.EmailFun;
                tbxSenha.Text = Funcionario.SenhaFun;

                if (Clientes.Retorno == "Não")
                {
                    tbxCodFun.Text = string.Empty;
                    tbxCodFun.Focus();
                    tbxCodFun.SelectAll();
                    tbxNome.Text = string.Empty;
                    tbxEmail.Text = string.Empty;
                    tbxSenha.Text = string.Empty;
                    return;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um Código de Funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do cliente" + tbxCodFun.Text + "?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.CodFun = Convert.ToInt32(tbxCodFun.Text);
                    Funcionario.NomeFun = tbxNome.Text;
                    Funcionario.EmailFun = tbxEmail.Text;
                    Funcionario.SenhaFun = tbxSenha.Text;

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.alterarFuncionario();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um código de funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxNome.Text = string.Empty;
                tbxEmail.Text = string.Empty;
                tbxSenha.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir o funcionário" + tbxCodFun.Text + "?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.CodFun = Convert.ToInt32(tbxCodFun.Text);

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.deletarFuncionario();

                    tbxCodFun.Text = string.Empty;
                    tbxCodFun.Focus();
                    tbxCodFun.SelectAll();
                    tbxEmail.Text = string.Empty;
                    tbxNome.Text = string.Empty;
                    tbxSenha.Text = string.Empty;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxNomeFun.Text == "")
            {
                MessageBox.Show("Digite um nome para a busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }
            Funcionario.NomeFun = tbxNomeFun.Text;

            dataGridView1.DataSource = ManipulaFuncionario.pesquisarNomeFuncionario();

            dataGridView1.Columns[5].HeaderCell.Value = "Código";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderCell.Value = "Código";
            dataGridView1.Columns[5].HeaderCell.Value = "Nome";
            dataGridView1.Columns[6].HeaderCell.Value = "E-mail";
        }
    }
}
