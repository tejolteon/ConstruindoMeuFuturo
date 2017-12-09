using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AreaController
/// </summary>
public class AreaController
{
    private AreaBean area;
    private AreaDao areadao;
    public List<AreaBean> ListarAreas()
    {
        areadao = new AreaDao();
        var areas = new List<AreaBean>();
        areas = areadao.ListarArea();

        return areas;
    }

    public AreaBean ConsultarAreaPorId(int idarea)
    {
        area = areadao.ConsultarAreaPorId(idarea);
        return area;
    }

    public List<AreaBean> ListarAreaPerfil(int idperfil)
    {
        areadao = new AreaDao();
        var areas = new List<AreaBean>();
        areas = areadao.ListarAreaPerfil(idperfil);

        return areas;

    }
}