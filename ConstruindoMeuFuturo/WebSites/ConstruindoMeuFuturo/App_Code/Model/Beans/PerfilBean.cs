using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PerfilBean
/// </summary>
public class PerfilBean
{   private int id;
    private string nome;
    private int datanascimento;
    private string escolaridade;
    public virtual ICollection<UsuarioBean> id_usuario { get; set; }
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

    //Get e Set data nascimento

    public int Datanascimento
    {
        get
        {
            return datanascimento;
        }

        set
        {
            datanascimento = value;
        }
    }

    //Get e Set escolatidade

    public string Escolaridade
    {
        get
        {
            return escolaridade;
        }

        set
        {
            escolaridade = value;
        }
    }
}