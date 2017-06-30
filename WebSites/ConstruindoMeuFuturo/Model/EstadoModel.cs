using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de EstadoModel
/// </summary>
public class EstadoModel
{
    private int id;
    private String nome;
    private String sigla;

   
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

    //Get e Set Sigla
    public string GetSigla()
    {
        return sigla;
    }

    public void SetSigla(string value)
    {
        sigla = value;
    }

}