using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PerfilBean
/// </summary>
public class PerfilBean:UsuarioBean
{   private int id_perfil;
    private String datanascimento;
    private string escolaridade;


    //Get e Set id perfil
    public int Id_perfil
    {
        get
        {
            return id_perfil;
        }

        set
        {
            id_perfil = value;
        }
    }

    //Get e Set data nascimento
    public String Datanascimento
    {
        get
        {
            return datanascimento;
        }

        set
        {
            datanascimento = value;
        }
    }

    //Get e Set escolatidade

    public string Escolaridade
    {
        get
        {
            return escolaridade;
        }

        set
        {
            escolaridade = value;
        }
    }
}