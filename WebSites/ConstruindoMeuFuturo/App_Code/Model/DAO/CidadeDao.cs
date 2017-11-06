using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CidadeDao
/// </summary>
public class CidadeDao
{
    public List<CidadeBean> ListarCidadePorEstado(int id_estado)
    {

        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_CIDADE WHERE Id_Estado = @id_estado";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_estado", id_estado);
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Criar list
            var cidades = new List<CidadeBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var cidade = new CidadeBean();
                cidade.Id_cidade = Convert.ToInt32(reader["Id_Cidade"]);
                cidade.Nome = Convert.ToString(reader["Nome_Cidade"]);
                cidade.Id_estado = Convert.ToInt32(reader["Id_Estado"]);
                cidades.Add(cidade);
            }
            return cidades;


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

    public CidadeBean ConsultarCidadePorId(int id_cidade)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_CIDADE WHERE Id_Cidade = @id_cidade";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_cidade", id_cidade);
            //Executar o comando 
            var reader = command.ExecuteReader();
            CidadeBean cidade = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                cidade = new CidadeBean();
                cidade.Id_cidade = Convert.ToInt32(reader["Id_Cidade"]);
                cidade.Nome = Convert.ToString(reader["Nome_Cidade"]);
                cidade.Id_estado = Convert.ToInt32(reader["Id_Estado"]);
            }
            return cidade;
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

    public CidadeBean ConsultarIdCidadePerfil(int idperfil) {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_PERFIL_has_TB_CIDADE WHERE Id_Perfil = @id_perfil";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", idperfil);
            //Executar o comando 
            var reader = command.ExecuteReader();
            CidadeBean cidade = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                cidade = new CidadeBean();
                cidade.Id_cidade = Convert.ToInt32(reader["Id_Cidade"]);    
            }
            return cidade;
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
    

    /*Teste com List por ser N * N no MER
    public List<CidadeBean> ListarIdCidadePerfil(int id_estado) {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_PERFIL_has_TB_CIDADE WHERE Id_Perfil = @id_perfil";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", id_estado);
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Criar list
            var cidades = new List<CidadeBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var cidade = new CidadeBean();
                cidade = new CidadeBean();
                cidade.Id_cidade = Convert.ToInt32(reader["Id_Cidade"]);
                cidades.Add(cidade);
            }
            return cidades;
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