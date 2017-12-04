using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class View_Cadastro_Questao : System.Web.UI.Page
{
    private QuestaoController questaocont;
    private QuestaoBean questao;
    protected void Page_Load(object sender, EventArgs e)
    { 
        //Verifica se o usuario está logado, se é Administrador e se ele está ativo
        try
        {
            if (Session["usuario"] == null || Session["UsuarioTipo"].ToString() != "A" || Session["UsuarioStatus"].ToString() != "A")
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }
        catch
        {
            Response.Redirect("~/View/Home.aspx");
        }
        if (!Page.IsPostBack)
        {
            CarregarCamposAlterar();
        }
    }

    private void CarregarCamposAlterar()
    {

        questao = new QuestaoBean();
        questao.Id_questao = Convert.ToInt32(Request.QueryString["Id_Questao"]);

        questaocont = new QuestaoController();
        questao = questaocont.ConsultarQuestaoPorId(questao.Id_questao);
        txtTextoquestao.InnerText = questao.Texto_questao;
    }
    protected void Btalterar_Click(object sender, EventArgs e)
    {

        //Colocando os valores no bean
        questao = new QuestaoBean();
        questao.Texto_questao = txtTextoquestao.InnerText;
        questao.Id_questao = Convert.ToInt32(Request.QueryString["Id_Questao"]);

        //Mandando para o controler
        questaocont = new QuestaoController();
        try
        {
            questaocont.AlteararQuestao(questao);
            Response.Redirect("Lista_Questao.aspx");
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
}