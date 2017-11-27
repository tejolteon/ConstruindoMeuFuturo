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
    Unidade_de_EnsinoDao unidadedao;
    CursoController cursocont;

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
        if (linhasafetadas == 0)
        {
            throw new NaoCadastradoException();
        }


    }

    public List<QuestionarioBean> ListarQuestionarioCurso(int idcurso)
    {
        try
        {
            questionariodao = new QuestionarioDao();
            var questionarios = questionariodao.ListarQuestionarioCurso(idcurso);
            return questionarios;
        }
        catch
        {
            return null;
        }
    }
    public List<QuestionarioBean> ListarQuestionarioPerfil(int idperfil, int idquestao, int idresposta)
    {
        try
        {
            questionariodao = new QuestionarioDao();
            var questionarios = questionariodao.ListarQuestionarioPerfil(idperfil,idquestao,idresposta);
            return questionarios;
        }
        catch
        {
            return null;
        }
    }
}
    
  