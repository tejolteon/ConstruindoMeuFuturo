using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class View_Cadastro : System.Web.UI.Page
{
    private UsuarioController usucont;
    private UsuarioBean usuario;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btcadastras_Click(object sender, EventArgs e)
    {

        //Colocando os valores no bean
        usuario = new UsuarioBean();
        usuario.Nome = txtNome.Text;
        usuario.Email = Txtemail.Text;
        usuario.Senha = TxtSenha.Text;
        usuario.Confirmarsenha = TxtConfirmarSenha.Text;       

        //Mandando para o controler
        usucont = new UsuarioController();
        try
        {
            usucont.InserirNovoUsuario(usuario);
            usuario = usucont.ConsultarUsuario(usuario.Email, usuario.Senha);
            // criando sessão de usuário
            Session["usuario"] = usuario.Nome;
            Session["usuarioId"] = usuario.Id;
            Response.Redirect("Cadastro_Perfil.aspx");
        }
        catch (SenhaUsuarioInvalidaException)
        {
            Labelerro.Text = "Campos de senha não condizem";
        }
        catch (UsuarioInvalidoException)
        {
            Labelerro.Text = "Todos os campos são obrigatórios";
        }
        catch (EmailJaCadastradoException)
        {
            Labelerro.Text = "Esse email já está cadastrado";
        }
        catch (Exception)
        {

            throw;
        }
    }
}