using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class View_Cadastro_Resposta : System.Web.UI.Page
{
    private RespostaController respostacont;
    private RespostaBean resposta;
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
    }
    protected void Btcadastras_Click(object sender, EventArgs e)
    {

        //Colocando os valores no bean
        resposta = new RespostaBean();
        resposta.Texto_resposta = txtTextoresposta.InnerText;
          

        //Mandando para o controler
        respostacont = new RespostaController();
        try
        {
            respostacont.InserirNovaResposta(resposta);
            Response.Redirect("Perfil.aspx");
        }
        catch (RespostaInvalidaException)
        {
            Labelerro.Text = "Campo de texto é obrigatório";
        }
        catch (Exception)
        {

            throw;
        }
    }
}