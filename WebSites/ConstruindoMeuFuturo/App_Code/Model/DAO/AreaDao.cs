﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AreaDao
/// </summary>
public class AreaDao
{
    public int InserirArea(AreaBean area)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "INSERT INTO TB_AREA(Nome_Area) VALUES(@nome),";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@nome", area.Nome);
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
    public List<AreaBean> ListarArea()
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_AREA";
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var areas = new List<AreaBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var area = new AreaBean();
                area.Id = Convert.ToInt32(reader["Id_Area"]);
                area.Nome = Convert.ToString(reader["Nome_Area"]);
                areas.Add(area);
            }
            return areas;
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
    public AreaBean ConsultarAreaPorId(int id)
    {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_AREA WHERE Id_Area = @id_area";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_area", id);
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

    public List<AreaBean> ListarAreaPerfil(int idperfil) {
        try
        {
            //Conectar com o banco
            Conexao.Conectar();
            var command = new SqlCommand();
            command.Connection = Conexao.connection;
            //Comando no banco
            command.CommandText = "SELECT * FROM TB_PERFIL_has_TB_AREA A INNER JOIN TB_AREA B ON "+ 
            "B.Id_Area = A.Id_Area WHERE Id_Perfil = @id_perfil";
            //Entrada doa parâmetros
            command.Parameters.AddWithValue("@id_perfil", idperfil);
            //Executar o comando 
            var reader = command.ExecuteReader();
            //Cria list
            var areas = new List<AreaBean>();
            //Inserir os valores do resultado no bean
            while (reader.Read())
            {
                var area = new AreaBean();
                area.Id = Convert.ToInt32(reader["Id_Area"]);
                area.Nome = Convert.ToString(reader["Nome_Area"]);
                areas.Add(area);
            }
            return areas;
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

