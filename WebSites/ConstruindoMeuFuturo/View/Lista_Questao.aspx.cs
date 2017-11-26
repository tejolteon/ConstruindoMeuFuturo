using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Lista_Questao : System.Web.UI.Page
{



    private QuestaoBean questao;
    private QuestaoController questaocont;

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


        questaocont = new QuestaoController();
        if (!Page.IsPostBack)
        {
            var listaQuestoes = questaocont.ListarQuestao();
            if (listaQuestoes != null)
            {
                this.grdDados.DataSource = listaQuestoes;
                this.grdDados.DataBind();

            }
        }
    }

    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Editar"))
        {
            string idQuestao = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idQuestao))
                this.Response.Redirect("Alterar_Questao.aspx?Id_Questao=" + idQuestao);
        }


        if (e.CommandName.Equals("Adicionar"))
        {
            string idQuestao = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idQuestao))
                this.Response.Redirect("Adicionar_Resposta_Questao.aspx?Id_Questao=" + idQuestao);
        }
    }
    protected void Txtpesquisa_TextChanged(object sender, EventArgs e)
    {
        this.grdDados.DataSource = null;
        var listaQuestoes = questaocont.ListarQuestaoTexto(Txtpesquisa.Text);
        if (listaQuestoes != null)
        {
            this.grdDados.DataSource = listaQuestoes;
            this.grdDados.DataBind();

        }
    }

    protected void Btcadastras_Click(object sender, EventArgs e)
    {

        //Colocando os valores no bean
        questao = new QuestaoBean();
        questao.Texto_questao = txtTextoquestao.InnerText;


        //Mandando para o controler
        questaocont = new QuestaoController();
        try
        {
            questaocont.InserirNovaQuestao(questao);
            pnCadastroQuestao.Visible = false;
            btnPainelCadastrar.Visible = true;

            var listaQuestoes = questaocont.ListarQuestao();
            if (listaQuestoes != null)
            {
                this.grdDados.DataSource = listaQuestoes;
                this.grdDados.DataBind();

            }
        }
        catch (QuestaoInvalidaException)
        {
            Labelerro.Text = "Campo de texto é obrigatório";
        }
        catch (Exception)
        {

            throw;
        }
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        pnCadastroQuestao.Visible = true;
        btnPainelCadastrar.Visible = false;
    }
}