using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaVendas
    {
        public void cadastrarVendas()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarVen", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codVen", "");
                cmd.Parameters.AddWithValue("@codCliFK", "");
                cmd.Parameters.AddWithValue("@codPackFK", "");
                cmd.Parameters.AddWithValue("@pagoVen", "");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
