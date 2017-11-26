using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de QuestionarioController
/// </summary>
public class QuestionarioController
{
    QuestionarioDao questionariodao;
    CursoDao cursodao;
    public void ExcluirQuestionario(int idresposta, int idquestao)
    {
        //Verifica se as Variaveis obrigatórias estão null

        questionariodao = new QuestionarioDao();
        int linhasafetadas = questionariodao.ExcluirQuestionario(idresposta, idquestao);
        if (linhasafetadas == 0)
        {
            throw new NaoExcluidoException();
        }
    }


    public void InserirQuestionario(int idresposta, int idquestao)
    {
        questionariodao = new QuestionarioDao();
        int linhasafetadas = questionariodao.InserirQuestionario(idresposta, idquestao);
        if (linhasafetadas == 0)
        {
            throw new NaoCadastradoException();
        }
    }

    public void InserirQuestionariopPerfil(QuestionarioBean questionario)
    {
        questionariodao = new QuestionarioDao();
        int linhasafetadas = questionariodao.InserirQuestionarioPerfil(questionario);
        if(linhasafetadas == 0)
        {
            throw new NaoCadastradoException();
        }


    }

    public List<QuestionarioBean> ListarQuestionarioResposta(int idquestao)
    {
        questionariodao = new QuestionarioDao();
        var respostas= new List<QuestionarioBean>();
        respostas = questionariodao.ListarQuestionarioResposta(idquestao);
        return respostas;

    }

    public List<QuestionarioBean>  ConsultarQuestionarioCurso(QuestionarioBean questionario)
    {
        questionariodao = new QuestionarioDao();
        var questionarios = new List<QuestionarioBean>();
        questionarios = questionariodao.ListarQuestionarioCurso(questionario);
        return questionarios;
    }
    
  