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
    class ManipulaCliente
    {
        public void cadastrarCliente()
        {
            SqlConnection cn = new SqlConnection(conexão.conectar());
            SqlCommand cmd = new SqlCommand( "pCadastrarCliente" ,cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCli", Clientes.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli", Clientes.EmailCli);
                cmd.Parameters.AddWithValue("@senhaCli", Clientes.SenhaCli);
                cmd.Parameters.AddWithValue("@imgCli", Clientes.ImgCli);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codCli", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                var respostas = MessageBox.Show("Cadastro de Cliente efetuado com sucesso, deseja efetuar um novo registro?","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respostas == DialogResult.Yes)
                {
                    Clientes.Retorno = "Sim";
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
                 
                throw;
            }
        }
    }
}
