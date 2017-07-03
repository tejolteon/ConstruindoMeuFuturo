using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CidadeBean
/// </summary>
public class CidadeBean
{
    private int id;
    private String nome;

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
}
