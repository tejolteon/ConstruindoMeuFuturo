using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CidadeModel
/// </summary>
public class CidadeModel
{
    private int id;
    private String nome;

    //Get e Set id
    public int GetId()
    {
        return id;
    }

    public void SetId(int value)
    {
        id = value;
    }
    //Get e Set nome
    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string value)
    {
        nome = value;
    }
}