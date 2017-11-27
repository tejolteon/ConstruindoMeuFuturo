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

        //Verifica se o usuario está logado, se é Administrador e se ele está ativo
        try
        {
            if (Session["usuario"] == null || Session["UsuarioTipo"].ToString() != "A" || Session["UsuarioStatus"].ToString() != "A")
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
    protected void Txtpesquisa_TextChanged(object sender, EventArgs e)
    {
        this.grdDados.DataSource = null;
        cursocont = new CursoController();
        var listaCursos = cursocont.ListaCursoPorNome(Txtpesquisa.Text);
        if (listaCursos != null)
        {
            this.grdDados.DataSource = listaCursos;
            this.grdDados.DataBind();

        }
    }

    protected void Btcadastrar_Click(object sender, EventArgs e)
    {
        curso = new CursoBean();
        curso.Nome = Txtnomecurso.Text;
        curso.Descricao = Txtdescricao.InnerText;
        curso.Tipo = DDLcidade.SelectedValue;

        cursocont = new CursoController();
        try
        {
            cursocont.InserirNovoCurso(curso);
            cursocont = new CursoController();
           
            var listaCursos = cursocont.ListaCurso();
            if (listaCursos != null)
            {
                 this.grdDados.DataSource = listaCursos;
                 this.grdDados.DataBind();

            }
            PanelCadastro.Visible = false;
            btnPainelCadastrar.Visible = true;
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        PanelCadastro.Visible = true;
        btnPainelCadastrar.Visible = false;
    }
}