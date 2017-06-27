using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de UsuarioModel
/// </summary>
public class UsuarioModel
{
    private int id;
    private string email;
    private string senha;

    //Get e Set id
    public int GetId()
    {
        return id;
    }

    public void SetId(int value)
    {
        id = value;
    }
    //Get e Set email
    public string GetEmail()
    {
        return email;
    }

    public void SetEmail(string value)
    {
        email = value;
    }
    //Get e Set senha
    public string GetSenha()
    {
        return senha;
    }

    public void SetSenha(string value)
    {
        senha = value;
    }
    
}