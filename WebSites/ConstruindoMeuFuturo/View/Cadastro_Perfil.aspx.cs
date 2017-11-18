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
    private AreaController areacont;
    private CidadeController cidadecont;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Se não tiver usuario logado ele volta pra Home
        if (Session["usuario"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        areacont = new AreaController();
        //Lista todas as areas
        foreach (AreaBean area in this.areacont.ListarAreas())
        {
            DDLarea.Items.Add(new ListItem(area.Nome, Convert.ToString(area.Id)));
        }
    }



    protected void Btcadastrar_Click(object sender, EventArgs e)
    {
        perfil = new PerfilBean();
        perfil.Datanascimento = Txtdatanascimento.Text;
        perfil.Escolaridade = DDLescolaridade.SelectedValue;

        area = new AreaBean();
        area.Id = Convert.ToInt32(DDLarea.SelectedValue);

        cidade = new CidadeBean();
        cidade.Id_cidade = Convert.ToInt32(DDLcidade.SelectedValue);

        usuario = new UsuarioBean();
        usuario.Id = int.Parse(Session["usuarioId"].ToString());

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
        Response.Redirect("Perfil.aspx");
    }

    //Após selecionar estado ele adiciona as cidades do estado
    protected void DDLestado_SelectedIndexChanged(object sender, EventArgs e)
    {

        int id_estado = 0;
        //Pega o Id do estado
        id_estado = Convert.ToInt16(DDLestado.SelectedValue);
        //chamando o controller das cidades
        cidadecont = new CidadeController();
        //Peenche a lista das cidades de acordo com o estado
        foreach (CidadeBean cidade in this.cidadecont.ListarCidadesPorEstado(id_estado))
        {
            DDLcidade.Items.Add(new ListItem(cidade.Nome, Convert.ToString(cidade.Id_cidade)));
        }
        //!!!!!!!!!!!!!!!ATENÇÃO!! ao trocar para outros estados devemos limpar a lista, senão ele apenas dicionara mais cidades
    }

    protected void DDLarea_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}