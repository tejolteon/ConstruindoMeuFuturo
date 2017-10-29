using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AreaDao
/// </summary>
public class AreaDao
{
    public List<AreaBean> ListarArea()
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_AREA";
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var areas = new List<AreaBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var area = new AreaBean();
                area.Id = Convert.ToInt32(reader["Id_Area"]);
                area.Nome = Convert.ToString(reader["Nome_Area"]);
                areas.Add(area);
            }
            return areas;
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
    public AreaBean ConsultarAreaPorId(int id)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_AREA WHERE Id_Area = @id";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id", id);
            //Executar o comando 
            var reader = command.ExecuteReader();
            AreaBean area = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                area = new AreaBean();
                area.Id = Convert.ToInt32(reader["Id_Area"]);
                area.Nome = Convert.ToString(reader["Nome_Area"]);
            }
            return area;
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

    public AreaBean ConsultarIdAreaPerfil(int idperfil) {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_PERFIL_has_TB_AREA WHERE Id_Perfil = @id_perfil";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", idperfil);
            //Executar o comando 
            var reader = command.ExecuteReader();
            AreaBean area = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                area = new AreaBean();
                area.Id = Convert.ToInt32(reader["Id_Area"]);
            }
            return area;
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

    /* Teste com List por ser N * N no MER
    public List<AreaBean> ListarIdAreaPerfil(PerfilBean id)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_PERFIL_has_TB_AREA WHERE Id_Perfil = @id_perfil";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", id);
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Criar list
            var areas = new List<AreaBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var area = new AreaBean();
                area = new AreaBean();
                area.Id = Convert.ToInt32(reader["Id_Area"]);
                areas.Add(area);
            }
            return areas;
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
    */
}

