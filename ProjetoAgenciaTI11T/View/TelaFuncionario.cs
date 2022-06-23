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
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

       
 
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text == "" | tbxEmail.Text == "" | tbxSenha.Text == "")
            {
                MessageBox.Show("Preencha todas as informações corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _ = Model.Funcionario.NomeFun = tbxNome.Text;
                _ = Model.Funcionario.EmailFun = tbxEmail.Text;
                _ = Model.Funcionario.SenhaFun = tbxSenha.Text;

                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.cadastrarFuncionario();
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
            }
        }
    }
}
