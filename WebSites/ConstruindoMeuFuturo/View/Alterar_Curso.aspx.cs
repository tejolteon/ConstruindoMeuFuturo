using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Alterar_Curso : System.Web.UI.Page
{/*Id_Curso=*/
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

        if (!Page.IsPostBack)
        {
            CarregarCamposAlterar();
        }
    }

    private void CarregarCamposAlterar()
    {

        curso = new CursoBean();
        curso.Id = Convert.ToInt32(Request.QueryString["Id_Curso"]);

        cursocont = new CursoController();
        curso = cursocont.ConsultarCursoId(curso.Id);
        Txtnomecurso.Text = curso.Nome;
        DDLtipo.SelectedValue = curso.Tipo;
        Txtdescricao.InnerText = curso.Descricao;
    
    }

    protected void Btalterar_Click(object sender, EventArgs e)
    {
        curso = new CursoBean();
        curso.Nome = Txtnomecurso.Text;
        curso.Descricao = Txtdescricao.InnerText;
        curso.Tipo = DDLtipo.SelectedValue;
        curso.Id = Convert.ToInt32(Request.QueryString["Id_Curso"]);

        cursocont = new CursoController();
        try
        {
            cursocont.AlterarCurso(curso);
            Response.Redirect("Lista_Curso.aspx");
        }
        catch (Exception)
        {
            throw;
        }
    }
    //Após selecionar estado ele adiciona as cidades do estado
}