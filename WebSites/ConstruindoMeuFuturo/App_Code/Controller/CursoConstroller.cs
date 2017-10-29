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
        var cursos = cursodao.ListarCursoArea(idarea);
        return cursos;
    }
}