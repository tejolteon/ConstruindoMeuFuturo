using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Unidade_de_Ensino : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void CarregarRepeater()
    {
        RepeaterCursos.DataSource = new List<UnidadeEnsinoBean>
        {
            new UnidadeEnsinoBean{Nome = }
        }
    }
}