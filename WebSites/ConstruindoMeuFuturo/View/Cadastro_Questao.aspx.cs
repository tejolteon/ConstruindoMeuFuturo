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
       /*
        if (Session["usuario"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        */
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
            Response.Redirect("Home.aspx");
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