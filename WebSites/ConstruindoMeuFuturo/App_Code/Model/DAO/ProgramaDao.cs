using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ProgramaDao
/// </summary>
public class ProgramaDao
{
    public int InserirPrograma(ProgramaBean programa)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_PROGRAMA(Nome_Programa,Descricao_Programa) VALUES(@nome,@descricao)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@nome", programa.Nome);
            command.Parameters.AddWithValue("@descricao", programa.Descricao);
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

    public List<ProgramaBean> ListarProgramas()
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_PROGRAMA";
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var programas = new List<ProgramaBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var programa = new ProgramaBean();
                programa.Id = Convert.ToInt32(reader["Id_Programa"]);
                programa.Nome = Convert.ToString(reader["Nome_Programa"]);
                programa.Descricao = Convert.ToString(reader["Descricao_Programa"]);
                programas.Add(programa);
            }
            return programas;
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

    public List<ProgramaBean> ListarProgramasUnidade(int idunidade)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_PROGRAMA_has_TB_UNIDADE_DE_ENSINO A INNER JOIN TB_PROGRAMA B ON A.Id_Programa = B.Id_Programa  WHERE Id_Unidade_de_Ensino = @idunidade";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idunidade", idunidade);
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var programas = new List<ProgramaBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var programa = new ProgramaBean();
                programa.Id = Convert.ToInt32(reader["Id_Programa"]);
                programa.Nome = Convert.ToString(reader["Nome_Programa"]);
                programa.Descricao = Convert.ToString(reader["Descricao_Programa"]);
                programas.Add(programa);
            }
            return programas;
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

    public int InserirProgramaUnidade(ProgramaBean programa, int idunidade)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_PROGRAMA_has_TB_UNIDADE_DE_ENSINO(Id_Programa,Id_Unidade_de_Ensino) VALUES(@idprograma,@idunidade);";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idprograma", programa.Id);
            command.Parameters.AddWithValue("@idunidade", idunidade);
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

}