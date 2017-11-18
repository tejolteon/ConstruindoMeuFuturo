using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


/// <summary>
/// Descrição resumida de UsuarioDao
/// </summary>
public class UsuarioDao
{
    UsuarioBean usuario = new UsuarioBean();
    //DAO para inserir usuarios
    public int InserirUsuario(UsuarioBean usuario)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_USUARIO(Nome_Usuario, Email_Usuario, Senha_Usuario,Tipo_Usuario,Status_Usuario,Data_Cadastro_Usuario) " +
                " VALUES(@nome, @email, @senha,@tipo,'A',GETDATE())";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@nome", usuario.Nome);
            command.Parameters.AddWithValue("@email", usuario.Email);
            command.Parameters.AddWithValue("@senha", usuario.Senha);
            command.Parameters.AddWithValue("@tipo", usuario.Tipo);

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

    public UsuarioBean ConsultarUsuario(string email, string senha)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_USUARIO WHERE Email_Usuario = @email AND Senha_Usuario = @senha";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", senha);
            //Executar o comando 
            var reader = command.ExecuteReader();
            UsuarioBean usuario = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                usuario = new UsuarioBean();
                usuario.Id = Convert.ToInt32(reader["Id_Usuario"]);
                usuario.Nome = Convert.ToString(reader["Nome_Usuario"]);
                usuario.Email = Convert.ToString(reader["Email_Usuario"]);
                usuario.Senha = Convert.ToString(reader["Senha_Usuario"]);
                usuario.Tipo = Convert.ToString(reader["Tipo_Usuario"]);
                usuario.Status = Convert.ToString(reader["Status_Usuario"]);

            }
            return usuario;
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

    public UsuarioBean ConsultarUsuarioEmail(string email)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT Id_Usuario,Email_Usuario,Nome_Usuario FROM TB_USUARIO WHERE Email_Usuario = @email";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@email", email);
            //Executar o comando 
            var reader = command.ExecuteReader();
            UsuarioBean usuario = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                usuario = new UsuarioBean();
                usuario.Id = Convert.ToInt32(reader["Id_Usuario"]);
                usuario.Nome = Convert.ToString(reader["Nome_Usuario"]);
                usuario.Email = Convert.ToString(reader["Email_Usuario"]);
            }
            return usuario;
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

    public UsuarioBean ConfirmarSenha(int id, string senha)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_USUARIO WHERE Id_Usuario = @id AND Senha_Usuario = @senha";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@senha", senha);
            var reader = command.ExecuteReader();
            UsuarioBean usuario = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                usuario = new UsuarioBean();
                usuario.Id = Convert.ToInt32(reader["Id_Usuario"]);
                usuario.Nome = Convert.ToString(reader["Nome_Usuario"]);
                usuario.Email = Convert.ToString(reader["Email_Usuario"]);
                usuario.Senha = Convert.ToString(reader["Senha_Usuario"]);

            }
            return usuario;
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

    public UsuarioBean ConsultarUsuarioPorID(int id)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_USUARIO WHERE Id_Usuario = @id";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id", id);
            //Executar o comando 
            var reader = command.ExecuteReader();
            UsuarioBean usuario = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                usuario = new UsuarioBean();
                usuario.Id = Convert.ToInt32(reader["Id_Usuario"]);
                usuario.Nome = Convert.ToString(reader["Nome_Usuario"]);
                usuario.Email = Convert.ToString(reader["Email_Usuario"]);
                usuario.Senha = Convert.ToString(reader["Senha_Usuario"]);

            }
            return usuario;
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

    public int AlterarSenha(UsuarioBean usuario)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco 
            command.CommandText = "UPDATE TB_USUARIO SET Senha_Usuario = @senha WHERE Id_Usuario = @id;";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id", usuario.Id);
            command.Parameters.AddWithValue("@senha", usuario.Senha);
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
}