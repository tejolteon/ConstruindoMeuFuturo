using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CursoConstroller
/// </summary>
public class CursoConstroller
{
    CursoDao cursodao;
    CursoBean curso;
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



}