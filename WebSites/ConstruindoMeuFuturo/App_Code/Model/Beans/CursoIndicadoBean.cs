using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CursoIndicadoBean
/// </summary>
public class CursoIndicadoBean
{
    private int idcurso;
    private int idperfil;
    private char statuscurso;
    private int pontuacao;

    public int Idcurso
    {
        get
        {
            return idcurso;
        }

        set
        {
            idcurso = value;
        }
    }

    public int Idperfil
    {
        get
        {
            return idperfil;
        }

        set
        {
            idperfil = value;
        }
    }

    public char Statuscurso
    {
        get
        {
            return statuscurso;
        }

        set
        {
            statuscurso = value;
        }
    }

    public int Pontuacao
    {
        get
        {
            return pontuacao;
        }

        set
        {
            pontuacao = value;
        }
    }
}