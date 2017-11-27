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
                unidade = new UnidadeEnsinoBean();
                unidade.Id_unidade = Convert.ToInt32(reader["Id_Unidade_de_Ensino"]);
                unidade.Nome_unidade = Convert.ToString(reader["Nome_Unidade_de_Ensino"]);
                unidade.Site = Convert.ToString(reader["Site_Unidade_de_Ensino"]);
                unidade.Endereco_unidade = Convert.ToString(reader["Endereco_Unidade_de_Ensino"]);
                unidade.Descricao_unidade = Convert.ToString(reader["Descricao_Unidade_de_Ensino"]);
                unidade.Id_cidade = Convert.ToInt32(reader["Id_Cidade"]);


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

    public int InserirUnidade(UnidadeEnsinoBean unidade)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_UNIDADE_DE_ENSINO(Nome_Unidade_de_Ensino,Site_Unidade_de_Ensino,Id_Cidade,Endereco_Unidade_de_Ensino, Descricao_Unidade_de_Ensino)" +
                                " VALUES (@nome, @site, @idcidade, @endereco, @descricao)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@nome", unidade.Nome_unidade);
            command.Parameters.AddWithValue("@site", unidade.Site);
            command.Parameters.AddWithValue("@idcidade", unidade.Id_cidade);
            command.Parameters.AddWithValue("@endereco", unidade.Endereco_unidade);
            command.Parameters.AddWithValue("@descricao", unidade.Descricao_unidade);

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

    public int AlterarUnidade(UnidadeEnsinoBean unidade)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "UPDATE TB_UNIDADE_DE_ENSINO SET " +
                "Nome_Unidade_de_Ensino = @nome, " +
                "Site_Unidade_de_Ensino =@site, " +
                "Id_Cidade = @idcidade," +
                "Endereco_Unidade_de_Ensino = @endereco, " +
                "Descricao_Unidade_de_Ensino = @descricao " +
                "WHERE Id_Unidade_de_Ensino = @id";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@nome", unidade.Nome_unidade);
            command.Parameters.AddWithValue("@site", unidade.Site);
            command.Parameters.AddWithValue("@idcidade", unidade.Id_cidade);
            command.Parameters.AddWithValue("@endereco", unidade.Endereco_unidade);
            command.Parameters.AddWithValue("@descricao", unidade.Descricao_unidade);
            command.Parameters.AddWithValue("@id", unidade.Id_unidade);

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

    public List<UnidadeEnsinoBean> ListarUnidades()
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

                unidade.Id_unidade = Convert.ToInt32(reader["Id_Unidade_de_Ensino"]);
                unidade.Nome_unidade = reader["Nome_Unidade_de_Ensino"].ToString();
                unidade.Site = reader["Site_Unidade_de_Ensino"].ToString();
                //unidade. = reader[].ToString();Faltando
                unidade.Endereco_unidade = reader["Endereco_Unidade_de_Ensino"].ToString();
                unidade.Descricao_unidade = reader["Descricao_Unidade_de_Ensino"].ToString();
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
            command.Parameters.AddWithValue("@idcurso", idcurso);
            //Executar o comando 
            var reader = command.ExecuteReader();

            var unidades = new List<UnidadeEnsinoBean>();

            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var unidade = new UnidadeEnsinoBean();
                unidade.Id_unidade = Convert.ToInt32(reader["Id_Unidade_de_Ensino"]);
                unidade.Nome_unidade = reader["Nome_Unidade_de_Ensino"].ToString();
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

    public List<UnidadeEnsinoBean> ListarUnidadeNome(String nome)
    {
        try
        {

            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_UNIDADE_DE_ENSINO WHERE Nome_Unidade_de_Ensino LIKE @nome";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@nome", nome + "%");
            //Executar o comando 
            var reader = command.ExecuteReader();

            var unidades = new List<UnidadeEnsinoBean>();

            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var unidade = new UnidadeEnsinoBean();

                unidade.Id_unidade = Convert.ToInt32(reader["Id_Unidade_de_Ensino"]);
                unidade.Nome_unidade = reader["Nome_Unidade_de_Ensino"].ToString();
                unidade.Site = reader["Site_Unidade_de_Ensino"].ToString();
                //unidade. = reader[].ToString();Faltando
                unidade.Endereco_unidade = reader["Endereco_Unidade_de_Ensino"].ToString();
                unidade.Descricao_unidade = reader["Descricao_Unidade_de_Ensino"].ToString();
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

    public List<UnidadeEnsinoBean> ListarUnidadeCidade(int idcidade)
    {
        try
        {

            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT Id_Unidade_de_Ensino FROM TB_UNIDADE_DE_ENSINO WHERE Id_Cidade = @idcidade";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idcidade", idcidade);
            //Executar o comando 
            var reader = command.ExecuteReader();

            var unidades = new List<UnidadeEnsinoBean>();

            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var unidade = new UnidadeEnsinoBean();
                unidade.Id_unidade = Convert.ToInt32(reader["Id_Unidade_de_Ensino"]);
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

}