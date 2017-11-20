﻿using System;
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
            command.CommandText = "INSERT INTO TB_RESPOSTA(Texto_Resposta) " +
                "VALUES (@texto)";
            //Entrada doa parâmetros


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

    public int InserirRespostaQuestao(int idresposta, int idquestao)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_RESPOSTA_QUESTAO(Id_Resposta, Id_Questao) " +
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

    public int ExcluirRespostaQuestao(int idresposta, int idquestao)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "DELETE FROM TB_RESPOSTA_QUESTAO WHERE Id_Resposta = @idresposta AND Id_Questao = @idquestao";
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

    public int InserirRespostaQuestaoCurso(int idresposta, int idquestao,int idcurso)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_RESPOSTA_QUESTAO_has_TB_CURSO(Id_Curso,Id_Resposta, Id_Questao)" +
                " VALUES(@idcurso,@idresposta,@idquestao)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idresposta", idresposta);
            command.Parameters.AddWithValue("@idquestao", idquestao);
            command.Parameters.AddWithValue("@idquestao", idresposta);

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

    public List<RespostaBean> ListarRespostaTexto(String texto)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_RESPOSTA WHERE Texto_Resposta LIKE @texto";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@texto", "%"+texto+"%");
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
                resposta.Texto_resposta = Convert.ToString(reader["Texto_Resposta"]);
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

    public List<RespostaBean> ListarRespostaQuestao(int idquestao)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT A.Texto_Resposta, A.Id_Resposta FROM TB_RESPOSTA A "+
                                "INNER JOIN TB_RESPOSTA_QUESTAO B "+
                                "ON A.Id_Resposta = B.Id_Resposta "+
                                "INNER JOIN TB_QUESTAO C "+
                                "ON B.Id_Questao = C.Id_Questao " +
                                "WHERE B.Id_Questao = @idquestao";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idquestao", idquestao );
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
                resposta.Texto_resposta = Convert.ToString(reader["Texto_Resposta"]);
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