using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PerfilDao
/// </summary>
public class PerfilDao
{
    PerfilBean perfil = new PerfilBean();

    public int InserirPerfilRetornandoId(PerfilBean perfil) {

        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_PERFIL(Id_Usuario, Data_Nascimento_Perfil, Escolaridade_Perfil) OUTPUT INSERTED.Id_Perfil VALUES(@id,@datadascimento,@escolaridade)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id", perfil.Id);
            command.Parameters.AddWithValue("@datanascimento", perfil.Datanascimento);
            command.Parameters.AddWithValue("@escolaridade", perfil.Escolaridade);
            //Executa e retorna o id que foi gerado
            return (Int32)command.ExecuteScalar();
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

    public int InserirPerfilArea(PerfilBean perfil, AreaBean area) {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_PERFIL_has_TB_AREA(Id_Perfil,Id_Area) VALUES (@id_perfil,@id_Area)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", perfil.Id_perfil);
            command.Parameters.AddWithValue("@id_area", area.Id);
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

    public int InserirPerfilCidade(PerfilBean perfil, CidadeBean cidade)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_PERFIL_has_TB_CIDADE(Id_Perfil,Id_Cidade) VALUES (@id_perfil,@id_cidade)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", perfil.Id_perfil);
            command.Parameters.AddWithValue("@id_area",cidade.Id);
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