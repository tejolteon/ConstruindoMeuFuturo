using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (MasterPage.log)
        {
            pnCursos.Visible = true;
            pnPassos.Visible = false;
        }
        else
        {
            pnPassos.Visible = true;
            pnCursos.Visible = false;
        }
    }

    protected void btnQCadastro_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cadastro.aspx");
    }
}