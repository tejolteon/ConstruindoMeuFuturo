using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Unidade_de_EnsinoDao
/// </summary>
public class Unidade_de_EnsinoDao
{
    public List<UnidadeEnsinoBean> ListarFaculdades()
    {
        try
        {

            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_UNIDADE_DE_ENSINO";
            //Executar o comando 
            var reader = command.ExecuteReader();

            var unidades = new List<UnidadeEnsinoBean>();

            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var unidade = new UnidadeEnsinoBean();

                unidade.Id = Convert.ToInt32(reader["Id_Unidade_de_Ensino"]);
                unidade.Nome = reader["Nome_Unidade_de_Ensino"].ToString();
                unidade.Site = reader["Site_Unidade_de_Ensino"].ToString();
                //unidade. = reader[].ToString();Faltando

                unidade.Endereco = reader["Endereco_Unidade_de_Ensino"].ToString();

                unidade.Descricao = reader["Descrição_Unidade_de_Ensino"].ToString();
                unidades.Add(unidade);
            }

            return unidades;

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
    public List<UnidadeEnsinoBean> ListarUnidadeCurso(int idcurso)
    {
        try
        {

            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT A.Nome_Unidade_de_Ensino, B.Id_Unidade_de_Ensino " +
                "FROM TB_UNIDADE_DE_ENSINO A INNER JOIN TB_UNIDADE_DE_ENSINO_has_TB_CURSO B " +
                "ON A.Id_Unidade_de_Ensino = B.Id_Unidade_de_Ensino " +
                "INNER JOIN TB_CURSO C " +
                "ON B.Id_Curso = C.Id_Curso " +
                "WHERE B.Id_Curso = @idcurso;";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idcurso",idcurso);
            //Executar o comando 
            var reader = command.ExecuteReader();

            var unidades = new List<UnidadeEnsinoBean>();

            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var unidade = new UnidadeEnsinoBean();
                unidade.Id = Convert.ToInt32(reader["Id_Unidade_de_Ensino"]);
                unidade.Nome = reader["Nome_Unidade_de_Ensino"].ToString();   
                unidades.Add(unidade);
            }

            return unidades;

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

    public UnidadeEnsinoBean ConsultarUnidadeID(int idunidade)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_UNIDADE_DE_ENSINO WHERE  Id_Unidade_de_Ensino = @idunidade";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idunidade", idunidade);
            //Executar o comando 
            var reader = command.ExecuteReader();
            UnidadeEnsinoBean unidade = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                unidade= new UnidadeEnsinoBean();
                unidade.Id = Convert.ToInt32(reader["Id_Unidade_de_Ensino"]);
                unidade.Nome = Convert.ToString(reader["Nome_Unidade_de_Ensino"]);
                unidade.Site = Convert.ToString(reader["Site_Unidade_de_Ensino"]);
                unidade.Endereco = Convert.ToString(reader["Endereco_Unidade_de_Ensino"]);
                unidade.Descricao = Convert.ToString(reader["Descricao_Unidade_de_Ensino"]);
         

            }
            return unidade;
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