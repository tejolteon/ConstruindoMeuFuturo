using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Cadastro_Perfil : System.Web.UI.Page
{

    private PerfilController perfcont;
    private PerfilBean perfil;
    private AreaBean area;
    private CidadeBean cidade;
    private UsuarioBean usuario;
    private UsuarioController usuCont;

    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Btcadastrar_Click(object sender, EventArgs e)
    {   
        perfil = new PerfilBean() ;
        perfil.Datanascimento = Txtdatanascimento.Text;
        perfil.Escolaridade = DDLescolaridade.SelectedValue;
 
        area = new AreaBean();
        area.Id = Convert.ToInt32(DDLarea.SelectedValue);

        cidade = new CidadeBean();
        cidade.Id = Convert.ToInt32(DDLcidade.SelectedValue);

        usuario = new UsuarioBean();
        usuario.Id = MasterPage.usuarioID;

        //Campo estado é apenas um filtro para mostras apenas as cidades do estado selecionado, ficara pendente

        //Mandando para o controler
        perfcont = new PerfilController();
        usuCont = new UsuarioController();
        try
        {
            usuario = usuCont.ConsultarUsuarioPorID(usuario.Id);
            perfcont.InserirNovoPerfil(usuario, perfil, area, cidade);
            Response.Redirect("Perfil.aspx");
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void lbtMTarde_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}