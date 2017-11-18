using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de RespostaDao
/// </summary>
public class RespostaDao
{
    public int InserirResposta(RespostaBean resposta)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_RESPOSTA(Id_Questao, Id_Perfil, Texto_Resposta) " +
                "VALUES (@id_questao, @id_perfil, @texto)";
            //Entrada doa parâmetros

            command.Parameters.AddWithValue("@id_questao", resposta.Id_questao);
            command.Parameters.AddWithValue("@id_perfil", resposta.Id_perfil);
            command.Parameters.AddWithValue("@texto", resposta.Texto_resposta);
         

            //Executa e retorna o tanto de linhas que foram afetadas
            return command.ExecuteNonQuery();
        }
        catch (Exception)
        {

            throw;
        }
        //encerrar conexão com o banco
        finally
        {
            Conexao.Desconectar();
        }

    }

    public RespostaBean ConsultarRespostaPorId(int id)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_RESPOSTA WHERE Id_resposta = @id";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id", id);
            //Executar o comando 
            var reader = command.ExecuteReader();
            RespostaBean resposta = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                resposta = new RespostaBean();
                resposta.Id_resposta = Convert.ToInt32(reader["Id_Resposta"]);
                resposta.Id_questao = Convert.ToInt32(reader["Id_Questao"]);
                resposta.Id_perfil = Convert.ToInt32(reader["Id_Perfil"]);
                resposta.Texto_resposta = Convert.ToString(reader["texto_Resposta"]);
            }
            return resposta;
        }
        catch (Exception)
        {

            throw;
        }
        //encerrar conexão com o banco
        finally
        {
            Conexao.Desconectar();
        }

    }

    public List<RespostaBean> ListarResposta()
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_RESPOSTA";
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var respostas = new List<RespostaBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var resposta = new RespostaBean();
                resposta = new RespostaBean();
                resposta.Id_resposta = Convert.ToInt32(reader["Id_Resposta"]);
                resposta.Id_questao = Convert.ToInt32(reader["Id_Questao"]);
                resposta.Id_perfil = Convert.ToInt32(reader["Id_Perfil"]);
                resposta.Texto_resposta = Convert.ToString(reader["texto_Resposta"]);
                respostas.Add(resposta);
            }
            return respostas;
        }
        catch (Exception)
        {

            throw;
        }
        //encerrar conexão com o banco
        finally
        {
            Conexao.Desconectar();
        }

    }
}