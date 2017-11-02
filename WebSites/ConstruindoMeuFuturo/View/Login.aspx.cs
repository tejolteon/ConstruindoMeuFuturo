using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Usuario_Login : System.Web.UI.Page
{
    //instancionado controler login
    private UsuarioController usucont;
    private UsuarioBean usuario;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btlogin_Click(object sender, EventArgs e)
    {
        //Colocando os valores no bean
        usuario = new UsuarioBean();
        usuario.Email = Txtemail.Text;
        usuario.Senha = TxtSenha.Text;
        //Mandando para o controler
        usucont = new UsuarioController();
        try
        {
            usuario = usucont.ConsultarUsuario(usuario.Email, usuario.Senha);
            // Criando sessão de Usuario
            Session["usuario"] = usuario.Nome;
            Session["usuarioId"] = usuario.Id;
            //??????Criar pagina depois de logado???????
            Response.Redirect("Perfil.aspx");
        }
        catch (UsuarioNaoCadastradoException)

        {
            Labelerro.Text = "E-mail ou senha incorretos";
            //Redirecionar para pagina de logado
            //FormsAuthentication.RedirectFromLoginPage(usuario.Email, false);//mudar para true para manter o usuario logado
        }
        catch (Exception)
        {
            Labelerro.Text = "Erro inesperado do sistema, contate um administrador";
        }

    }
}