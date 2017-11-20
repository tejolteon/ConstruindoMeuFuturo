using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Lista_Unidade_de_Ensino : System.Web.UI.Page
{


    private CidadeBean cidade;
    private UsuarioBean usuario;
    private UnidadeEnsinoBean unidade;

    private UsuarioController usuCont;
    private CidadeController cidadecont;
    private UnidadeController unicont;

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


        unicont = new UnidadeController();
        if (!Page.IsPostBack)
        {
            var listaUnidades = unicont.ListarUnidade();
            if (listaUnidades != null)
            {
                this.grdDados.DataSource = listaUnidades;
                this.grdDados.DataBind();
                
            }
        }
    }

    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Editar"))
        {
            string idUnidade = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idUnidade))
                this.Response.Redirect("Alterar_Unidade_de_Ensino.aspx?Id_Unidade=" + idUnidade);
        }
    }
    //Após selecionar estado ele adiciona as cidades do estado
    protected void Txtpesquisa_TextChanged(object sender, EventArgs e)
    {
        this.grdDados.DataSource = null;
        var listaUnidades = unicont.ListarUnidadeNome(Txtpesquisa.Text);
        if (listaUnidades != null)
        {
            this.grdDados.DataSource = listaUnidades;
            this.grdDados.DataBind();
        }
    }

}