using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaPacotes
    {
        public void cadastrarPacotes()
        {
            SqlConnection cn = new SqlConnection(conexão.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPac", "");
                cmd.Parameters.AddWithValue("@origemPac", "");
                cmd.Parameters.AddWithValue("@destinoPac", "");
                cmd.Parameters.AddWithValue("@dataPacIda", "");
                cmd.Parameters.AddWithValue("@dataPacVolta", "");
                cmd.Parameters.AddWithValue("@descPac", "");
                cmd.Parameters.AddWithValue("@imgPac", "");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
