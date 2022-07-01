using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;


namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaVendas
    {

        public void cadastrarVenda()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarVendas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@pagoVen", Vendas.PagoVen);
                cmd.Parameters.AddWithValue("@codigoCliFK", Clientes.CodCli);
                cmd.Parameters.AddWithValue("@codigoFunFK", Funcionario.CodFun);
                cmd.Parameters.AddWithValue("@codigoPacFK", Pacotes.CodPac);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoVen", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro do Venda efetuado com sucesso, deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                    );

                if (resposta == DialogResult.Yes)
                {
                    Vendas.Retorno = "Sim";
                    return;
                }
                else
                {
                    Vendas.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }
        }
        public void pesquisaCodVen()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodVendas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoVen", Vendas.CodVen);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Vendas.CodVen = Convert.ToInt32(arrayDados["codigoVen"]);
                    Vendas.PagoVen = Convert.ToInt32(arrayDados["pagoVen"]);
                    Clientes.CodCli = Convert.ToInt32(arrayDados["codigoCliFK"]);
                    Funcionario.CodFun = Convert.ToInt32(arrayDados["codigoFunFK"]);
                    Pacotes.CodPac = Convert.ToInt32(arrayDados["codigoPacFK"]);
                    Vendas.Retorno = "Sim";
                }

                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Vendas.Retorno = "Não";
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarVen()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarVendas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoVen", Vendas.CodVen);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venda excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O Venda não pôde ser excluido.");
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
    }
}
