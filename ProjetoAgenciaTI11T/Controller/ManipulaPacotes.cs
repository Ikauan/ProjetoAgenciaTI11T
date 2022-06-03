using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProjetoAgenciaTI11T.Controller;
using ProjetoAgenciaTI11T.Model;
using System.Windows.Forms;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaPacotes
    {
        public void cadastrarPacotes()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPac", Pacotes.ValorPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacotes.OrigemPac);
                cmd.Parameters.AddWithValue("@destinoPac", Pacotes.DestinoPac);
                cmd.Parameters.AddWithValue("@dataidaPac", Pacotes.DataPacIda);
                cmd.Parameters.AddWithValue("@datavoltaPac", Pacotes.DataPacVolta);
                cmd.Parameters.AddWithValue("@descricaoPac", Pacotes.DescPac);
                cmd.Parameters.AddWithValue("@imagemPac", Pacotes.ImgPac);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoPac", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();
                var respostas = MessageBox.Show("Cadastro de Cliente efetuado com sucesso, deseja efetuar um novo registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respostas == DialogResult.Yes)
                {
                    Pacotes.Retorno = "Sim";
                    return;
                }
                else
                {
                    Pacotes.Retorno = "Não";
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
