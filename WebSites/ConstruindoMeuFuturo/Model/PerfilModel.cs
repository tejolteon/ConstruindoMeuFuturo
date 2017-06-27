using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PerfilModel
/// </summary>
public class PerfilModel
{
    private int id;
    private string nome;
    private int datanascimento;
    private string escolaridade;

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
    //Get e Set data nascimento
    public int GetDatanascimento()
    {
        return datanascimento;
    }

    public void SetDatanascimento(int value)
    {
        datanascimento = value;
    }
    //Get e Set escolatidade
    public string GetEscolaridade()
    {
        return escolaridade;
    }

    public void SetEscolaridade(string value)
    {
        escolaridade = value;
    }
}