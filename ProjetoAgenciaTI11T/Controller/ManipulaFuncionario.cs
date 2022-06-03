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
            catch (Exception)
            {

                throw;
            }
        }
    }
}
