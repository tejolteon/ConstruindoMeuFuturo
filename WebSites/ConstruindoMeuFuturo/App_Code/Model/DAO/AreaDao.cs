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
    public AreaBean ConsultarArea(string id)
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
}
