using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de UsuarioBean
/// </summary>
public class UsuarioBean
{

    private int id;
    private string nome;
    private string email;
    private string senha;
    private string confirmarsenha;
    private string tipo;
    private string status;
    private string datacadastro;

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

    //Get e Set email
    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }

    //Get e Set senha
    public string Senha
    {
        get
        {
            return senha;
        }

        set
        {
            senha = value;
        }
    }
    //Get e Set Confirmar Senha
    public string Confirmarsenha
    {
        get
        {
            return confirmarsenha;
        }

        set
        {
            confirmarsenha = value;
        }
    }

    public string Tipo
    {
        get
        {
            return tipo;
        }

        set
        {
            tipo = value;
        }
    }

    public string Status
    {
        get
        {
            return status;
        }

        set
        {
            status = value;
        }
    }

    public string Datacadastro
    {
        get
        {
            return datacadastro;
        }

        set
        {
            datacadastro = value;
        }
    }
}