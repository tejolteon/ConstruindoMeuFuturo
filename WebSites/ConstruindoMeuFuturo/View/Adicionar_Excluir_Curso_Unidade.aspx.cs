using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Adicionar_Excluir_Curso_Unidade : System.Web.UI.Page
{


  
    private CursoBean curso;
    private CursoController cursocont;
    private int idunidade;

    protected void Page_Load(object sender, EventArgs e)
    {
        idunidade = Convert.ToInt32(Request.QueryString["Id_Unidade"]);

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

        if (!Page.IsPostBack)
        {
            
            CarregargrdCursoUnidade();
            CarregargrDados();
        }
    }
    protected void CarregargrDados()
    {
    
            cursocont = new CursoController();
            idunidade = Convert.ToInt32(Request.QueryString["Id_Unidade"]);
            var listaCursos = cursocont.ListaCurso();
            if (listaCursos != null)
            {
                this.grdDados.DataSource = listaCursos;
                this.grdDados.DataBind();

            } 
    }

    protected void CarregargrdCursoUnidade()
    {
            cursocont = new CursoController();
            var listaCursosUnidades = cursocont.ListaCursoUnidade(idunidade);
            if (listaCursosUnidades != null)
            {
                this.grdCusoUnidade.DataSource = listaCursosUnidades;
                this.grdCusoUnidade.DataBind();

            }
            if(listaCursosUnidades.Count == 0)
        {
            LblJaCadastrados.Text = "";
        }else
        {
            LblJaCadastrados.Text = "Cursos já cadastrados:";
        }
    }

    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Adicionar"))
        {
            string idCurso = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idCurso))
            {

                cursocont = new CursoController();
                try
                {
                    cursocont.InserirCursoUnidade(Convert.ToInt32(idCurso), idunidade);
                    CarregargrdCursoUnidade();
                }
                catch
                {

                }
            }
        }
    }

    protected void grdCusoUnidade_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Excluir"))
        {
            string idCurso = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idCurso))
            {

                cursocont = new CursoController();
                try
                {
                    cursocont.ExcluirCurso(idunidade, Convert.ToInt32(idCurso));
                    CarregargrdCursoUnidade();
                }
                catch
                {

                }
            }
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
}