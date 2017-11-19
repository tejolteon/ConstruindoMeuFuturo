using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Cadastro_Unidade_de_Ensino : System.Web.UI.Page
{


    private CidadeBean cidade;
    private UsuarioBean usuario;
    private UnidadeEnsinoBean unidade;

    private UsuarioController usuCont;
    private CidadeController cidadecont;
    private UnidadeController unicont;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["usuario"] == null || Session["UsuarioTipo"].ToString() != "A")
            {
                Response.Redirect("Home.aspx");
            }
        }
        catch
        {
            Response.Redirect("Home.aspx");
        }
    }



    protected void Btcadastrar_Click(object sender, EventArgs e)
    {
        unidade = new UnidadeEnsinoBean();
        unidade.Nome_unidade = Txtnome.Text;
        unidade.Site = TxtSite.Text;
        unidade.Endereco_unidade = Txtendereco.Text;
        unidade.Descricao_unidade = Txtdescricao.InnerText;
        unidade.Id_cidade = Convert.ToInt32(DDLcidade.SelectedValue);

        unicont = new UnidadeController();
        try
        {
            unicont.InserirNovaUnidade(unidade);
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