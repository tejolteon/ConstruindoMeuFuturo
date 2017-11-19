using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AreaController
/// </summary>
public class QuestaoController
{
    private QuestaoBean questao;
    private QuestaoDao questaodao;

    public void InserirNovaQuestao(QuestaoBean questao)
    {
        //Verifica se as Variaveis obrigatórias estão null
        ValidarQuestao(questao);
        questaodao.InserirQuestao(questao);
    }

    public void AlteararQuestao(QuestaoBean questao)
    {
        //Verifica se as Variaveis obrigatórias estão null
        ValidarQuestao(questao);
        questaodao = new QuestaoDao();
        questaodao.AlterarQuestao(questao);
    }

    public void ValidarQuestao(QuestaoBean questao)
    {
        //Verifica se as variaveis estão nulas
        if (string.IsNullOrWhiteSpace(questao.Texto_questao))
        {
            throw new QuestaoInvalidaException();
        }
    }
    public List<QuestaoBean> ListarQuestao()
    {
        questaodao = new QuestaoDao();
        var questoes = new List<QuestaoBean>();
        questoes = questaodao.ListarQuestao();

        return questoes;
    }

    public QuestaoBean ConsultarQuestaoPorId(int idquestao)
    {
        questaodao = new QuestaoDao();
        questao = questaodao.ConsultarQuestaoPorId(idquestao);
        return questao;
    }
    
}