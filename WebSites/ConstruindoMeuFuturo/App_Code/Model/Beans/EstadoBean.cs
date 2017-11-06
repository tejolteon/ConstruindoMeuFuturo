using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de EstadoBean
/// </summary>
public class EstadoBean
{
    private int id_estado;
    private String nome;
    private String sigla;


    //Get e Set id_estado

    public int Id_estado
    {
        get
        {
            return id_estado;
        }

        set
        {
            id_estado = value;
        }
    }

    //Get e Set nome

    public string Nome
    {
        get
        {
            return nome;
        }

        set
        {
            nome = value;
        }
    }

    //Get e Set Sigla

    public string Sigla
    {
        get
        {
            return sigla;
        }

        set
        {
            sigla = value;
        }
    }
}