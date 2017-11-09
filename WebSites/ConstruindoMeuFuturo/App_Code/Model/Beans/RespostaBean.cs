using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de RespostaBean
/// </summary>
public class RespostaBean
{
    private int id;
    private String texto;
    private int id_perfil;
    private int id_questao;

    private QuestaoBean questao;
    private PerfilBean perfil;

    public int Id_resposta
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

    public string Texto_resposta
    {
        get
        {
            return texto;
        }

        set
        {
            texto = value;
        }
    }

    public int Id_perfil
    {
        get
        {
            id_perfil = perfil.Id_perfil;
            return id_perfil;
        }

        set
        {
            perfil.Id_perfil = id_perfil;
            id_perfil = value;
        }
    }

    public int Id_questao
    {
        get
        {
            id_questao = questao.Id_questao;
            return id_questao;
        }

        set
        {

            questao.Id_questao = Id_resposta;
            id_questao = value;
        }
    }
}