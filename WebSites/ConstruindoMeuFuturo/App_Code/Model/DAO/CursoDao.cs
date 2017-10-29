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
}