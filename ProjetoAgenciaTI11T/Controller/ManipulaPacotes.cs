﻿using System;
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
            catch
            {

            }
        }

        public void pesquisarCodigoPacotes()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarCodPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codPac", Funcionario.CodFun);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Pacotes.CodPac = Convert.ToInt32(arrayDados["@codPac"]);
                    Pacotes.ValorPac = Convert.ToDecimal(arrayDados["@valorPac"]);
                    Pacotes.OrigemPac = arrayDados["@origemPac"].ToString();
                    Pacotes.DestinoPac = arrayDados["@destinoPac"].ToString();
                    Pacotes.DataPacIda = Convert.ToDateTime(arrayDados["@dataPacIda"]);
                    Pacotes.DataPacVolta = Convert.ToDateTime(arrayDados[""]);
                    Pacotes.DescPac = arrayDados["@descPac"].ToString();
                    Pacotes.ImgPac = (System.Array)arrayDados["@imgPac"];
                    Pacotes.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Pacotes.Retorno = "Não";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clientes.Retorno = "Não";
            }
        }

        public void deletarPacote()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacotes.CodPac);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluido com sucesso", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("O Pacote não pode ser exlcuido",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cn.State != ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
        }

        public void alterarPacote()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacotes.CodPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacotes.OrigemPac);
                cmd.Parameters.AddWithValue("@destinoPac", Pacotes.DestinoPac);
                cmd.Parameters.AddWithValue("@dataPacIda", Pacotes.DataPacIda);
                cmd.Parameters.AddWithValue("dataPacVolta", Pacotes.DataPacVolta);
                cmd.Parameters.AddWithValue("@descPac", Pacotes.DescPac);
                cmd.Parameters.AddWithValue("@imgPac", Pacotes.ImgPac);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote alterado com sucesso", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O pacote não foi alterado", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if(cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public static BindingSource pesquisarNomePacote()
        {
            SqlConnection cn = new SqlConnection(conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarNomePac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomePac", Pacotes.ValorPac);
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
