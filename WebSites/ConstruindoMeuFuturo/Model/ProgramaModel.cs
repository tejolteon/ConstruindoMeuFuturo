using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AreaModel
/// </summary>
public class AreaModel
{
    private int id;
    private string nome;
    private string descricao;

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

    // get e set descricao
    public string GetDescricao()
    {
        return descricao;
    }

    public void SetDescricao(string value)
    {
        descricao = value;
    }
}