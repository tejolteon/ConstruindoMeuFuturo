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

    public void AlterarCurso(CursoBean curso)
    {
        //Verifica se unidade está sem nome
        ValidarCurso(curso);

        cursodao = new CursoDao();
        var linhasafetadas =cursodao.AlterarCurso(curso);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new UsuarioNaoCadastradoException();
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

}