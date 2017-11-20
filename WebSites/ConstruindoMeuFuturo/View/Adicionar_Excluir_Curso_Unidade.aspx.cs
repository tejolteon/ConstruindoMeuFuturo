using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Adicionar_Excluir_Curso : System.Web.UI.Page
{
    private CursoBean curso;
    private CursoController cursocont;
    private UnidadeEnsinoBean unidade;
    private UnidadeController unicont;
  

    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = "";
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
            var listaCursosUnidade = cursocont.ListaCursoUnidade(Convert.ToInt32(Request.QueryString["Id_Unidade"]));
            if (listaCursosUnidade != null)
            {
                this.grdCursosUnidade.DataSource = listaCursosUnidade;
                this.grdCursosUnidade.DataBind();
            }
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
        if (e.CommandName.Equals("Adicionar"))
        {
            unidade = new UnidadeEnsinoBean();
            string idCurso = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idCurso)) {
                unidade.Id_unidade= Convert.ToInt32(Request.QueryString["Id_Unidade"]);
                cursocont = new CursoController();
                try
                {
                    cursocont.InserirCursoUnidade(Convert.ToInt32(idCurso), unidade.Id_unidade);
                    //Falta colocar mensagem de cadastro com sucesso em algo como um messagebox ou Modal
                    Label2.Text = "Cadastro feito com sucesso";
                    var listaCursosUnidade = cursocont.ListaCursoUnidade(Convert.ToInt32(Request.QueryString["Id_Unidade"]));
                    if (listaCursosUnidade != null)
                    {
                        this.grdCursosUnidade.DataSource = listaCursosUnidade;
                        this.grdCursosUnidade.DataBind();
                    }
                }
                catch
                {

                }
            }
        }
    }
    //Após selecionar estado ele adiciona as cidades do estado

    protected void Txtpesquisa_TextChanged(object sender, EventArgs e)
    {
        this.grdDados.DataSource = null;
        var listaCursos = cursocont.ListaCursoPorNome(Txtpesquisa.Text);
        if (listaCursos != null)
        {
            this.grdDados.DataSource = listaCursos;
            this.grdDados.DataBind();

        }
    }


    protected void grdCursosUnidade_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Excluir"))
        {
            unidade = new UnidadeEnsinoBean();
            string idCurso = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idCurso))
            {
                unidade.Id_unidade = Convert.ToInt32(Request.QueryString["Id_Unidade"]);
                cursocont = new CursoController();
                try
                {
                    cursocont.ExcluirCurso(unidade.Id_unidade, Convert.ToInt32(idCurso));
                    //Falta colocar mensagem de cadastro com sucesso em algo como um messagebox ou Modal
                    Label2.Text = "Exclusão feita com sucesso";
                    var listaCursosUnidade = cursocont.ListaCursoUnidade(Convert.ToInt32(Request.QueryString["Id_Unidade"]));
                    if (listaCursosUnidade != null)
                    {
                        this.grdCursosUnidade.DataSource = listaCursosUnidade;
                        this.grdCursosUnidade.DataBind();
                    }
                }
                catch
                {
                    Label2.Text = "Erro ao excluir";
                }
            }
        }
    }
}