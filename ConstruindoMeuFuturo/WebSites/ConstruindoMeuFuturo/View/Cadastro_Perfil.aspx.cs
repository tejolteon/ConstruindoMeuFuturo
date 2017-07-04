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

        //Campo estado é apenas um filtro para mostras apenas as cidades do estado selecionado, ficara pendente

        //Mandando para o controler
        perfcont = new PerfilController();

        try
        {
            perfcont.InserirNovoPerfil(perfil, area, cidade);
        }
        catch (Exception)
        {

            throw;
        }
    }
}