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
    }
}
