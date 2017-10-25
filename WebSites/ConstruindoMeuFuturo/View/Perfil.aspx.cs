using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Perfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbNome.Text = MasterPage.nome;
    }

    protected void lbtAlterarPerfil_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cadastro_Perfil.aspx");
    }
}