using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CursoBean
/// </summary>
public class CursoBean
{
   private int id;
    private string nome;
    private string tipo;
    private string descricao;
    private char status_indicado;
    private int pontos;

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

    //Get e Set tipo

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

    // get e set descricao

    public string Descricao
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

    public int Pontos
    {
        get
        {
            return pontos;
        }

        set
        {
            pontos = value;
        }
    }

    public char Status_indicado
    {
        get
        {
            return status_indicado;
        }

        set
        {
            status_indicado = value;
        }
    }
}