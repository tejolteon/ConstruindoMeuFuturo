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
            command.CommandText = "INSERT INTO TB_PERFIL(Id_Usuario, Data_Nascimento_Perfil, Escolaridade_Perfil) OUTPUT INSERTED.Id_Perfil VALUES(@id_usuario,@datanascimento,@escolaridade)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_usuario", perfil.Id);
            command.Parameters.AddWithValue("@datanascimento", perfil.Datanascimento);
            command.Parameters.AddWithValue("@escolaridade", perfil.Escolaridade);
            //Executa e retorna o id_usuario que foi gerado
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
            command.Parameters.AddWithValue("@id_cidade",cidade.Id_cidade);
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

    public int InserirPerfilArea(PerfilBean perfil, AreaBean area)
    {
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

    public int AlterarPerfil(PerfilBean perfil) {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco 
            command.CommandText = "UPDATE  TB_PERFIL SET Data_Nascimento_Perfil = @datanascimento, Escolaridade_Perfil= @escolaridade WHERE Id_Perfil = @id_perfil;";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", perfil.Id_perfil);
            command.Parameters.AddWithValue("@datanascimento", perfil.Datanascimento);
            command.Parameters.AddWithValue("@escolaridade", perfil.Escolaridade);
            //Executa
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

    //Arumar Id cidade porque o usuario pode se cadastrar em várias
    public int AlterarPerfilCidade(PerfilBean perfil, CidadeBean cidade, int idantigocidade) {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "UPDATE TB_PERFIL_has_TB_CIDADE SET Id_Cidade=@id_cidade WHERE Id_Perfil = @id_perfil ";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", perfil.Id_perfil);
            command.Parameters.AddWithValue("@id_cidade", cidade.Id_cidade);
            //command.Parameters.AddWithValue("@idantigo", idantigocidade);
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

    public int ExcluirPerfilArea(PerfilBean perfil)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "DELETE FROM TB_PERFIL_has_TB_AREA WHERE Id_Perfil = @id_perfil";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", perfil.Id_perfil);
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
    public PerfilBean ConsultarPerfilPorIdUsuario(int idusuario)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT Id_Perfil, Id_Usuario, CONVERT(CHAR(10),Data_Nascimento_Perfil,101)Data_Nascimento_Perfil, Escolaridade_Perfil FROM TB_PERFIL WHERE Id_Usuario = @id_usuario";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_usuario", idusuario);
            //Executar o comando 
            var reader = command.ExecuteReader();
            PerfilBean perfil = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                perfil = new PerfilBean();
                perfil.Id_perfil = Convert.ToInt32(reader["Id_Perfil"]);
                perfil.Id = Convert.ToInt32(reader["Id_Usuario"]);
                perfil.Datanascimento = Convert.ToString(reader["Data_Nascimento_Perfil"]);
                perfil.Escolaridade = Convert.ToString(reader["Escolaridade_Perfil"]);

            }
            return perfil;
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