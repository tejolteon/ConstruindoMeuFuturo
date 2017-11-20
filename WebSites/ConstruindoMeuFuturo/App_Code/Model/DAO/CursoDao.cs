using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CursoDao
/// </summary>
public class CursoDao
{
    public int InserirCurso(CursoBean curso)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_CURSO (Tipo_Curso,Nome_Curso,Descricao_Curso) VALUES (@tipo, @nome, @descricao)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@nome",curso.Nome);
            command.Parameters.AddWithValue("@tipo", curso.Tipo);
            command.Parameters.AddWithValue("@descricao", curso.Descricao);

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

    public int InserirCursoUnidade(int idcurso, int idunidade)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_UNIDADE_DE_ENSINO_has_TB_CURSO(Id_unidade_de_ensino,Id_curso) VALUES (@idunidade, @idcurso)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idcurso", idcurso);
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

    public int AlterarCurso(CursoBean curso)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "UPDATE  TB_CURSO SET " +
                "Tipo_Curso = @tipo, Nome_Curso = @nome, Descricao_Curso = @descricao WHERE Id_Curso = @id;";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@nome", curso.Nome);
            command.Parameters.AddWithValue("@tipo", curso.Tipo);
            command.Parameters.AddWithValue("@descricao", curso.Descricao);
            command.Parameters.AddWithValue("@id", curso.Id);


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

    public int ExcluirCursoUnidade(int idunidade, int idcurso)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "DELETE FROM TB_UNIDADE_DE_ENSINO_has_TB_CURSO WHERE Id_Unidade_de_Ensino = @idunidade AND Id_Curso = @idcurso;";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idunidade", idunidade);
            command.Parameters.AddWithValue("@idcurso", idcurso);

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
    public CursoBean ConsultarCursoID(int idcurso)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_CURSO WHERE  Id_Curso = @idcurso";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idcurso", idcurso);
            //Executar o comando 
            var reader = command.ExecuteReader();
            CursoBean curso = null;
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                curso = new CursoBean();
                curso.Id = Convert.ToInt32(reader["Id_Curso"]);
                curso.Nome = Convert.ToString(reader["Nome_Curso"]);
                curso.Tipo = Convert.ToString(reader["Tipo_Curso"]);
                curso.Descricao = Convert.ToString(reader["Descricao_Curso"]);


            }
            return curso;
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

    public List<CursoBean> ListarCurso()
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_CURSO ORDER BY Nome_Curso";
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria List
            var cursosareas = new List<CursoBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var curso = new CursoBean();
                curso.Id = Convert.ToInt32(reader["Id_Curso"]);
                curso.Nome = Convert.ToString(reader["Nome_Curso"]);
                curso.Tipo = Convert.ToString(reader["Tipo_Curso"]);
                curso.Descricao = Convert.ToString(reader["Descricao_Curso"]);
                cursosareas.Add(curso);
            }
            return cursosareas;
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

    public List<CursoBean> ListarCursoArea(int idarea)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT  A.Nome_Curso, B.Id_Curso, C.Nome_Area "+
                "FROM TB_CURSO A INNER JOIN TB_AREA_has_TB_CURSO B " +
                "ON A.Id_Curso = B.Id_Curso " +
                "INNER JOIN TB_AREA C " +
                "ON B.Id_Area = C.Id_Area "+
                "WHERE C.Id_area = @idarea";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idarea", idarea);
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria List
            var cursosareas = new List<CursoBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var curso = new CursoBean();
                curso.Id = Convert.ToInt32(reader["Id_Curso"]);
                curso.Nome = Convert.ToString(reader["Nome_Curso"]);
                cursosareas.Add(curso);
            }
            return cursosareas;
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

    public List<CursoBean> ListarCursoUnidade(int idunidade)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT C.Nome_Curso, C.Tipo_Curso, B.Id_Curso " +
                "FROM TB_UNIDADE_DE_ENSINO A INNER JOIN TB_UNIDADE_DE_ENSINO_has_TB_CURSO B " +
                "ON A.Id_Unidade_de_Ensino = B.Id_Unidade_de_Ensino " +
                "INNER JOIN TB_CURSO C " +
                "ON B.Id_Curso = C.Id_Curso " +
                "WHERE A.Id_Unidade_de_Ensino = @idunidade;";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@idunidade", idunidade);
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria List
            var cursosareas = new List<CursoBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var curso = new CursoBean();
                curso.Id = Convert.ToInt32(reader["Id_Curso"]);
                curso.Nome = Convert.ToString(reader["Nome_Curso"]);
                curso.Tipo = Convert.ToString(reader["Tipo_Curso"]);
                cursosareas.Add(curso);
            }
            return cursosareas;
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

    public List<CursoBean> ListarCursoNome(string nomecurso)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_CURSO WHERE  Nome_Curso like @nomecurso";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@nomecurso", "%"+nomecurso+"%");
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria List
            var cursosareas = new List<CursoBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var curso = new CursoBean();
                curso.Id = Convert.ToInt32(reader["Id_Curso"]);
                curso.Nome = Convert.ToString(reader["Nome_Curso"]);
                curso.Tipo = Convert.ToString(reader["Tipo_Curso"]);
                curso.Descricao = Convert.ToString(reader["Descricao_Curso"]);
                cursosareas.Add(curso);
            }
            return cursosareas;
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