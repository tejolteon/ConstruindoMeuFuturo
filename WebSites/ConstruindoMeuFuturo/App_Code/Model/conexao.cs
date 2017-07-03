using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de connection
/// </summary>
public class Conexao
{
    public static string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoConstruindo"].ConnectionString;
    public static SqlConnection connection = new SqlConnection(connetionString);

    public static void Conectar() {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }
    public static void Desconectar() {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}