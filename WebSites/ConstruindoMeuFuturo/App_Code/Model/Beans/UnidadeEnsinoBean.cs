using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de UnidadeEnsinoBean
/// </summary>
public class UnidadeEnsinoBean:CidadeBean
{
    private int id;
    private string nome;
    private string site;
    private string endereco;
    private string descricao;

    //get e set id
    public int Id_unidade
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

    public string Nome_unidade
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

    //get e set site
    public string Site
    {
        get
        {
            return site;
        }

        set
        {
            site = value;
        }
    }


    // get e set descricao

    public string Descricao_unidade
    {
        get
        {
            return descricao;
        }

        set
        {
            descricao = value;
        }
    }

    // get e set endereco
    public string Endereco_unidade
    {
        get
        {
            return endereco;
        }

        set
        {
            endereco = value;
        }
    }
}