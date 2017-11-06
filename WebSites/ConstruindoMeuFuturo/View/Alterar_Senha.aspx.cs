using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Alterar_Perfil : System.Web.UI.Page
{



    private UsuarioBean usuario;
    private UsuarioController usucont;
 
    int idcidadeantiga;//? caso depois façamos o cadastro de mais de uma cidade precisara saber qual estava cadastrada antes para saber qual delas deve trocar

    protected void Page_Load(object sender, EventArgs e)
    {
        // Se não tiver usuario logado ele volta pra Home
        if (Session["usuario"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        
    }


    protected void Btalterar_Click(object sender, EventArgs e)
    {
        //Colocando os valores no bean
       

        //usuario.Senha = TxtSenha.Text;
       
        //Mandando para o controler
        usucont = new UsuarioController();
        try
        {
            usuario = new UsuarioBean();
            usuario.Id = int.Parse(Session["usuarioId"].ToString());
            usuario.Senha = TxtSenha.Text;
            usucont.ConfirmarSenha(usuario.Id, usuario.Senha);
            try {
                //Verificando se os campos conforem
                if (TxtSenhaNova.Text == TxtConfirmarSenhaNova.Text)
                {
                   
                    usuario.Senha = TxtSenhaNova.Text;
                    usucont.AlterarSenha(usuario);
                    Response.Redirect("Perfil.aspx");
                }
                else {
                    Labelerro.Text = "Campos de senha nova não conferem";
                }
            }
            catch {
            }

        }
        catch (UsuarioNaoCadastradoException)

        {
            Labelerro.Text = "Campo senha atual incorreto";
            //Redirecionar para pagina de logado
            //FormsAuthentication.RedirectFromLoginPage(usuario.Email, false);//mudar para true para manter o usuario logado
        }
        catch (Exception)
        {
            Labelerro.Text = "Erro inesperado do sistema, contate um administrador";
        }
    }

    protected void lbtMTarde_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}