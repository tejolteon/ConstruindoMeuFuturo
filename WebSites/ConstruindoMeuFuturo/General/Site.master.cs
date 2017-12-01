using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    // váriaveis da master removida
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["usuario"] != null)
        {
            pnOn.Visible = true;
            pnOff.Visible = false;
            lbNome.Text = Session["usuario"].ToString();
        }    
        else
        {
            pnOff.Visible = true;
            pnOn.Visible = false;
        }

        //  Panel1.Style[HtmlTextWriterStyle.Position]= "bottom:0";
        //if(Page.si)
        //Panel1.Style.Remove(HtmlTextWriterStyle.Position);
        //Panel1.Style.Add("bottom","0");
        //Panel1.Style.Add("position", "absolute");
        
        
    }

    protected void Sair_Click(object sender, EventArgs e)
    {
        Session.Remove("usuario");
        Session.Remove("usuarioId");
        Response.Redirect("../View/Home.aspx");
    }

    protected void lbNome_Click(object sender, EventArgs e)
    {
        Response.Redirect("../View/Perfil.aspx");
    }
}
