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
    private QuestaoBean questao;


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

    public QuestaoBean Questao
    {
        get
        {
            return questao;
        }

        set
        {
            questao = value;
        }
    }
}