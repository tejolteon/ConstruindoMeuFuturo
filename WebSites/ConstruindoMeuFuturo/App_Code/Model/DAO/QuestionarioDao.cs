using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Questao_RespostaDao
/// </summary>
public class QuestionarioDao
{
    public int InserirQuestionarioPerfil(QuestionarioBean questionario)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_PERFIL_has_TB_QUESTIONARIO(Id_Perfil,Id_Resposta,Id_Questao) VALUES (@idperfil,@idresposta,@idquestao)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idperfil", questionario.Id_perfil);
            command.Parameters.AddWithValue("@idresposta", questionario.Id_resposta);
            command.Parameters.AddWithValue("@idquestao", questionario.Id_questao);
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

    public int InserirQuestionario(int idresposta, int idquestao)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_QUESTIONARIO(Id_Resposta, Id_Questao) " +
                "VALUES (@id_resposta, @id_questao)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_resposta", idresposta);
            command.Parameters.AddWithValue("@id_questao", idquestao);

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


    public int ExcluirQuestionario(int idresposta, int idquestao)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "DELETE FROM TB_QUESTIONARIO WHERE Id_Resposta = @idresposta AND Id_Questao = @idquestao";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idresposta", idresposta);
            command.Parameters.AddWithValue("@idquestao", idquestao);

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

    public List<QuestionarioBean> ListarQuestionarioResposta(int idquestao)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT A.Texto_Resposta, A.Id_Resposta FROM TB_RESPOSTA A " +
                                "INNER JOIN TB_QUESTIONARIO B " +
                                "ON A.Id_Resposta = B.Id_Resposta " +
                                "INNER JOIN TB_QUESTAO C " +
                                "ON B.Id_Questao = C.Id_Questao " +
                                "WHERE B.Id_Questao = @idquestao";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idquestao", idquestao);
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var respostas = new List<QuestionarioBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var questionario = new QuestionarioBean();
                questionario = new QuestionarioBean();
                questionario.Id_resposta = Convert.ToInt32(reader["Id_Resposta"]);
                questionario.Texto_resposta = Convert.ToString(reader["Texto_Resposta"]);
                respostas.Add(questionario);
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

    public List<QuestionarioBean> ListarQuestionarioCurso(QuestionarioBean questionario)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_QUESTIONARIO_has_TB_CURSO WHERE Id_Questao = @idquestao AND Id_Resposta = @idresposta";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idresposta", questionario.Id_resposta );
            command.Parameters.AddWithValue("@idresposta", questionario.Id_questao);
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var questionarios = new List<QuestionarioBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                questionario = new QuestionarioBean();
                questionario.Id_curso = Convert.ToInt32(reader["Id_Curso"]);
                questionario.Id_resposta = Convert.ToInt32(reader["Id_Resposta"]);
                questionario.Id_questao = Convert.ToInt32(reader["Id_Questao"]);
                questionarios.Add(questionario);
            }
            return questionarios;
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