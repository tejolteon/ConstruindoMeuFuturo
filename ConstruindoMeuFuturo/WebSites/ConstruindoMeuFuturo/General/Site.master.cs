using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public static bool log;
    public static string nome;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(log)
        {
            pnOn.Visible = true;
            pnOff.Visible = false;
            lbNome.Text = nome;
        }    
        else
        {
            pnOff.Visible = true;
            pnOn.Visible = false;
        }
    }

    protected void Sair_Click(object sender, EventArgs e)
    {
        log = false;
        Response.Redirect("../View/Home.aspx");
    }
}
