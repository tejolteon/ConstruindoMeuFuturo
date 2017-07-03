using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de EstadoBean
/// </summary>
public class EstadoBean
{
    private int id;
    private String nome;
    private String sigla;


    //Get e Set id

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
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