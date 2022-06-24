using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProjetoAgenciaTI11T.Model;
using System.Windows.Forms;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaFuncionario
    {
        public void cadastrarFuncionario()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionario.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionario.SenhaFun);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                var respostas = MessageBox.Show("Cadastro efetivado com Sucesso, deseja efetuar um novo registro?","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respostas == DialogResult.Yes)
                {
                    Clientes.Retorno = "SIm";
                    return;
                }
                else
                {
                    Clientes.Retorno = "Não";
                    return;
                }
            }
            catch
            {

            }
        }

        public void pequisarCodigoFuncionario()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@codigoFun", Funcionario.CodFun);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Funcionario.CodFun = Convert.ToInt32(arrayDados["codigoFun"]);
                    Funcionario.NomeFun = arrayDados["nomeFun"].ToString();
                    Funcionario.EmailFun = arrayDados["emailFun"].ToString();
                    Funcionario.SenhaFun = arrayDados["senhaFun"].ToString();
                    Funcionario.Retono = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Funcionario.Retono = "Sim";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Funcionario.Retono = "Não";
            }
        }

        public void deletarFuncionario()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codFun", Funcionario.CodFun);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario excluido com sucesso", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("O funcionario não pode ser excluido", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarFuncionario()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoFun", Funcionario.CodFun);
                cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionario.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionario.SenhaFun);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario alterado com sucesso", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O funcionario não foi alterado", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public static BindingSource pesquisarNomeFuncionario()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarNomeFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}
