using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class View_Cadastro_Questao : System.Web.UI.Page
{
    private RespostaController respostacont;
    private  RespostaBean resposta;
    private QuestaoBean questao;
    private QuestaoController questaocont;
    private PerfilBean perfil;
    private PerfilController perfilcont;

    private int cont = 1;
    protected void Page_Load(object sender, EventArgs e)
    {

        //Verifica se o usuario está logado e se ele está ativo
       
       if (Session["usuario"] == null || Session["UsuarioStatus"].ToString() != "A")
       { 
            Response.Redirect("Home.aspx");
       }
        
    }
    protected void Btcadastras_Click(object sender, EventArgs e)
    {

        //Colocando os valores no bean
        resposta = new RespostaBean();
        resposta.Texto_resposta = txtTextresposta.InnerText;
        perfilcont = new PerfilController();
        perfil = new PerfilBean();
        try
        {
            int UsuarioId = int.Parse(Session["usuarioId"].ToString());
            perfil = perfilcont.ConsultarPerfilPorIdUsuario(UsuarioId);
        }
        catch { }

        resposta.Id_perfil = perfil.Id_perfil;

        resposta.Id_questao = cont;

        //Mandando para o controler
        respostacont = new RespostaController();
        try
        {
            respostacont.InserirNovaResposta(resposta);
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
        CarregarQuestao(cont++);
    }

    protected void CarregarQuestao(int i)
    {
      
        questaocont = new QuestaoController();
        foreach (QuestaoBean questao in this.questaocont.ListarQuestao())
        {
            if (cont == i)
            {
                lbTextoquestao.InnerText = "Questao" + "<\br>" +
                questao.Texto_questao + "</br>";
                lbTextoresposta.InnerText = "";
            }
        }
        
    }
}