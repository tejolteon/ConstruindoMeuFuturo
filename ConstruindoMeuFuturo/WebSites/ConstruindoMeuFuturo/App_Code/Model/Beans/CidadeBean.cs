using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CidadeBean
/// </summary>
public class CidadeBean:EstadoBean
{
    private int id_cidade;
    private String nome;

    //Get e Set id
    public int Id_cidade
    {
        get
        {
            return id_cidade;
        }

        set
        {
            id_cidade = value;
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
