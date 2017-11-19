using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Lista_Curso : System.Web.UI.Page
{


  
    private CursoBean curso;
    private CursoController cursocont;

    protected void Page_Load(object sender, EventArgs e)
    {
     
        try
        {
            if (Session["usuario"] == null || Session["UsuarioTipo"].ToString() != "A")
            {
                Response.Redirect("Home.aspx");
            }
        }
        catch
        {
            Response.Redirect("Home.aspx");
        }


        cursocont = new CursoController();
        if (!Page.IsPostBack)
        {
            var listaCursos = cursocont.ListaCurso();
            if (listaCursos != null)
            {
                this.grdDados.DataSource = listaCursos;
                this.grdDados.DataBind();
                
            }
        }
    }

    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Editar"))
        {
            string idCurso = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idCurso))
                this.Response.Redirect("Alterar_Curso.aspx?Id_Curso=" + idCurso);
        }
    }
    //Após selecionar estado ele adiciona as cidades do estado


}