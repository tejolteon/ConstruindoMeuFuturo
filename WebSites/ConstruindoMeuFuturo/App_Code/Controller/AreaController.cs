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

    public AreaBean ConsultarAreaPerfil(int idperfil)
    {
        areadao = new AreaDao();
        area = areadao.ConsultarIdAreaPerfil(idperfil);
        try {
            //para retornar também o nome da área
            area = areadao.ConsultarAreaPorId(area.Id);
            return area;
        }
        catch
        {
            area.Id = 0;
            return area;
        }
        
    }

    /*Teste com list POR ser N * N no MER
     * public List<AreaBean> ConsultarIdAreaPerfil(PerfilBean id_estado) {
        areadao = new AreaDao();
        var areas = new List<AreaBean>();
        areas = areadao.ListarIdAreaPerfil(id_estado);
        return areas;
    }*/
}