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
    private UnidadeEnsinoBean unidade;
    private UnidadeController unicont;
  

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
                }
                catch
                {

                }
            }
        }
    }
    //Após selecionar estado ele adiciona as cidades do estado
}