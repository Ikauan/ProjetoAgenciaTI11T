using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAgenciaTI11T.Controller;
using ProjetoAgenciaTI11T.Model;
using System.Windows.Forms;

namespace ProjetoAgenciaTI11T.View
{
    public partial class telaPesquisarVendas : Form
    {
        public telaPesquisarVendas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de vendas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxValor.Text = string.Empty;
                tbxCodCli.Text = string.Empty;
                tbxCodFun.Text = string.Empty;
                tbxCodPac.Text = string.Empty;
            }
            else
            {
                Vendas.CodVen = Convert.ToInt32(tbxCod.Text);
                ManipulaVendas manipulaPacotes = new ManipulaVendas();
                manipulaPacotes.pesquisaCodVen();
            }
            if (Pacotes.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxValor.Text = string.Empty;
                tbxCodCli.Text = string.Empty;
                tbxCodFun.Text = string.Empty;
                tbxCodPac.Text = string.Empty;
                return;
            }
            else
            {
                tbxCod.Text = Vendas.CodVen.ToString();
                tbxValor.Text = Convert.ToString(Vendas.PagoVen);
                tbxCodCli.Text = Clientes.CodCli.ToString();
                tbxCodFun.Text = Funcionario.CodFun.ToString();
                tbxCodPac.Text = Pacotes.CodPac.ToString();
            }
        }
    }
}
