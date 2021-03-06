﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AreaDao
/// </summary>
public class QuestaoDao
{
    public int InserirQuestao(QuestaoBean questao)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_QUESTAO(Texto_Questao) VALUES (@texto)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@texto", questao.Texto_questao);
         
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

    public int AlterarQuestao(QuestaoBean questao)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "UPDATE  TB_QUESTAO SET " +
                "Texto_Questao = @texto WHERE Id_Questao = @id;";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@texto", questao.Texto_questao);
            command.Parameters.AddWithValue("@id", questao.Id_questao);
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

    public List<QuestaoBean> ListarQuestao()
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_QUESTAO";
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var questoes = new List<QuestaoBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var questao = new QuestaoBean();
                questao.Id_questao= Convert.ToInt32(reader["Id_Questao"]);
                questao.Texto_questao = Convert.ToString(reader["Texto_Questao"]);
                questoes.Add(questao);
            }
            return questoes;
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
    public List<QuestaoBean> ListarQuestaoTexto(String texto)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_QUESTAO WHERE Texto_Questao LIKE @texto";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@texto", "%" + texto + "%");
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var questoes = new List<QuestaoBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var questao = new QuestaoBean();
                questao.Id_questao = Convert.ToInt32(reader["Id_Questao"]);
                questao.Texto_questao = Convert.ToString(reader["Texto_Questao"]);
                questoes.Add(questao);
            }
            return questoes;
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
    public QuestaoBean ConsultarQuestaoNaoRespondida(int idperfil)
 
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT TOP 1 Id_Questao, Texto_Questao FROM TB_QUESTAO WHERE Id_Questao NOT IN " +
                                  "(SELECT Id_Questao FROM TB_PERFIL_has_TB_QUESTIONARIO  WHERE Id_Perfil = @idPerfil)";
;
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idperfil", idperfil);
            //Executar o comando 
            var reader = command.ExecuteReader();
            QuestaoBean questao = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                questao = new QuestaoBean();
                questao.Id_questao = Convert.ToInt32(reader["Id_Questao"]);
                questao.Texto_questao = Convert.ToString(reader["Texto_Questao"]);
            }
            return questao;
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

    public QuestaoBean ConsultarQuestaoPorId(int id)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_QUESTAO WHERE Id_Questao = @id";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id", id);
            //Executar o comando 
            var reader = command.ExecuteReader();
            QuestaoBean questao = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                questao = new QuestaoBean();
                questao.Id_questao = Convert.ToInt32(reader["Id_Questao"]);
                questao.Texto_questao = Convert.ToString(reader["texto_Questao"]);
            }
            return questao;
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

