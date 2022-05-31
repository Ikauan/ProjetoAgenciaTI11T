using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaFuncionario
    {
        public void cadastrarFuncionario()
        {
            SqlConnection cn = new SqlConnection(conexão.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFun", "");
                cmd.Parameters.AddWithValue("@emailFun", "");
                cmd.Parameters.AddWithValue("@senhaFun", "");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
