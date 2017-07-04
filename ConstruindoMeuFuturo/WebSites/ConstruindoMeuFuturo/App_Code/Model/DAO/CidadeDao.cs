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
    public CidadeBean ConsultarCidade(string id_cidade)
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
                cidade.Id = Convert.ToInt32(reader["Id_Estado"]);
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
}