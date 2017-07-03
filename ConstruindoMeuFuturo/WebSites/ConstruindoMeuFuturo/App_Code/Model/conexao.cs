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
    /* Minha conexão não apaguem. Ass: Tiago*/
    public static string connetionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=construindomeufuturo;Data Source=TIAGO";
    //public static string connetionString = "";
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