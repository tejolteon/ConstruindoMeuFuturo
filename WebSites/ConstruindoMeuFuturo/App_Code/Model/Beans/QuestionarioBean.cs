using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Questionario Bean
/// </summary>
public class QuestionarioBean
{
    private int id_questao;
    private int id_resposta;
    private int id_perfil;
    private int id_curso;
    private string texto_questao;
    private string texto_resposta;

    public int Id_questao
    {
        get
        {
            return id_questao;
        }

        set
        {
            id_questao = value;
        }
    }

    public int Id_resposta
    {
        get
        {
            return id_resposta;
        }

        set
        {
            id_resposta = value;
        }
    }

    public int Id_perfil
    {
        get
        {
            return id_perfil;
        }

        set
        {
            id_perfil = value;
        }
    }

    public int Id_curso
    {
        get
        {
            return id_curso;
        }

        set
        {
            id_curso = value;
        }
    }

    public string Texto_questao
    {
        get
        {
            return texto_questao;
        }

        set
        {
            texto_questao = value;
        }
    }

    public string Texto_resposta
    {
        get
        {
            return texto_resposta;
        }

        set
        {
            texto_resposta = value;
        }
    }
}