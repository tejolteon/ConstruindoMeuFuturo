using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Descrição resumida de connection
/// </summary>
public class Conexao
{
    /* Minha conexão não apaguem. Ass: Tiago*/
    public static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=construindomeufuturo;Data Source=GAMER-PC";
    //public static string connectionString = ConfigurationManager.ConnectionStrings["ConexaoConstruindo"].ConnectionString;
    public static SqlConnection connection = new SqlConnection(connectionString);

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