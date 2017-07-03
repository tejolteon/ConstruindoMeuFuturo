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

    public int InserirPerfil(PerfilBean perfil) {

        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_PERFIL(Id_Usuario, Nome_Perfil, Data_Nascimento_Perfil, Escolaridade_Perfil) VALUES(@usuario,@nome,@idade,@escolaridade)";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@senha", perfil.id_usuario);
            command.Parameters.AddWithValue("@email", perfil.Nome);
            command.Parameters.AddWithValue("@senha", perfil.Datanascimento);
            command.Parameters.AddWithValue("@senha", perfil.Escolaridade);
          

            //Executa e retorna o tanto de linhas que foram afetadas
            return command.ExecuteNonQuery();
        }
        catch (Exception)
        {

            throw;
        }
    }
}