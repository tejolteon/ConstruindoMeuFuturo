using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CursoConstroller
/// </summary>
public class CursoController
{
    CursoDao cursodao;
    public List<CursoBean> ListaCurso()
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCurso();
            return cursos;
        }
        catch
        {
            return null;
        }
    }
    public List<CursoBean> ListaCursoPorArea(int idarea)
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoArea(idarea);
            return cursos;
        }
        catch
        {
            return null;
        }
    }

    public List<CursoBean> ListaCursoPorNome(string nomecurso)
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoNome(nomecurso);
            return cursos;
        }
        catch
        {
            return null;
        }
    }
    public List<CursoBean> ListaCursoUnidade(int idunidade)
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoUnidade(idunidade);
            return cursos;
        }
        catch
        {
            return null;
        }
    }

    public List<CursoBean> ListaCursoRespostaQuestao(int idquestao, int idresposta)
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoQuestionario(idquestao, idresposta);
            return cursos;
        }
        catch
        {
            return null;
        }
    }

    public CursoBean ConsultarCursoId(int idcurso)
    {
        try
        {
            cursodao = new CursoDao();
            var curso = cursodao.ConsultarCursoID(idcurso);
            return curso;
        }
        catch {
            return null;
        }
    }

    public void InserirNovoCurso(CursoBean curso)
    {
        //Verifica se unidade está sem nome
        ValidarCurso(curso);

        cursodao = new CursoDao();
        var linhasafetadas = cursodao.InserirCurso(curso);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new UsuarioNaoCadastradoException();
        }
    }
    public void InserirCursoRespostaQuestao(int idresposta, int idquestao, int idcurso)
    {
        cursodao = new CursoDao();
        var linhasafetadas = cursodao.InserirCursoRespostaQuestao(idresposta, idquestao, idcurso);
        if (linhasafetadas == 0)
        {
            throw new CursoNaoExcluidoException();
        }
    }
    public void ExcluirCurso(int idunidade,int idcurso)
    {
       
        cursodao = new CursoDao();
        var linhasafetadas = cursodao.ExcluirCursoUnidade(idunidade, idcurso);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new CursoNaoExcluidoException();
        }
    }

    public void ExcluirCursoRespostaQuestao(int idresposta, int idquestao, int idcurso)
    {
        cursodao = new CursoDao();
        var linhasafetadas = cursodao.ExcluirRespostaQuestaoCurso(idresposta, idquestao, idcurso);
        if (linhasafetadas == 0)
        {
            throw new CursoNaoExcluidoException();
        }
    }
    public void InserirCursoUnidade(int idcurso, int idunidade)
    {
       
        cursodao = new CursoDao();
        var linhasafetadas = cursodao.InserirCursoUnidade(idcurso,idunidade);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new UsuarioNaoCadastradoException();
        }
    }

    public void AlterarCurso(CursoBean curso)
    {
        //Verifica se unidade está sem nome
        ValidarCurso(curso);

        cursodao = new CursoDao();
        var linhasafetadas =cursodao.AlterarCurso(curso);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new NaoCadastradoException();
        }
    }


    public void ValidarCurso(CursoBean curso)
    {
        //Verifica se as variaveis estão nulas
        if (string.IsNullOrWhiteSpace(curso.Nome)|| string.IsNullOrWhiteSpace(curso.Tipo))
        {
            throw new UnidadeInvalidaException();
        }
    }


    public void InserirCursoRecomendado(int idcurso, int idperfil, int ponto)
    {

        cursodao = new CursoDao();
        var linhasafetadas = cursodao.InserirPontoCursoRecomendado(idcurso,idperfil,ponto);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new NaoCadastradoException();
        }
    }

    public void Calcular_Ponto_Curso_Recomendado(QuestionarioBean questionario, int idperfil)
    {
        foreach (CursoBean curso in cursodao.ListarCursoRecomendado(questionario.Id_curso, idperfil))
        {

        }

    }
}