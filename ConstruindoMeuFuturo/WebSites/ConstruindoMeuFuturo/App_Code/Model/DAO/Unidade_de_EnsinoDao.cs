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
}