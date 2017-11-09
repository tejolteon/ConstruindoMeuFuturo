using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de QuestaoBean
/// </summary>
public class QuestaoBean
{
    private int id;
    private string texto;

    public int Id_questao
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

    public string Texto_questao
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
}