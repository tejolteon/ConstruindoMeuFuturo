using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Alterar_Unidade_de_Ensino : System.Web.UI.Page
{


    private CidadeBean cidade;
    private UnidadeEnsinoBean unidade;

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
        if (Txtnome.Text == "")
        {
            CarregarCamposAlterar();
        }
    }
    private void CarregarCamposAlterar()
    {

        unidade = new UnidadeEnsinoBean();
        cidade = new CidadeBean();
        unidade.Id_unidade = Convert.ToInt32(Request.QueryString["Id_Unidade"]);

        unicont = new UnidadeController();
        unidade = unicont.ConsultarUnidadeId(unidade.Id_unidade);
        //Consulta Cidade_Unidade
        try
        {
            cidadecont = new CidadeController();
            cidade = cidadecont.ConsultarCidadePorId(unidade.Id_cidade);
        }
        catch
        {

        }
        if (cidade.Id_estado != 0)
        {
            //Seleciona o estado 
            DDLestado.SelectedValue = Convert.ToString(cidade.Id_estado);
        }
        //Carrega as cidades do estado
        try
        {
            CarregarCidades();
        }
        catch
        {

        }
        //Seleciona a cidade que já estava cadastrado no BD
        if (cidade.Id_cidade != 0)
        {
            DDLcidade.SelectedValue = Convert.ToString(cidade.Id_cidade);
        }


        

        Txtnome.Text = unidade.Nome_unidade;
        Txtendereco.Text = unidade.Endereco_unidade;
        TxtSite.Text = unidade.Site;
        Txtdescricao.InnerText = unidade.Descricao_unidade;
    }

    private void CarregarCidades()
    {
        //Limpa a lista antes de receber
        DDLcidade.Items.Clear();
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
    }


    protected void Btalterar_Click(object sender, EventArgs e)
    {
        unidade = new UnidadeEnsinoBean();
        unidade.Id_unidade = Convert.ToInt32(Request.QueryString["Id_Unidade"]);
        unidade.Nome_unidade = Txtnome.Text;
        unidade.Site = TxtSite.Text;
        unidade.Endereco_unidade = Txtendereco.Text;
        unidade.Descricao_unidade = Txtdescricao.InnerText;
        unidade.Id_cidade = Convert.ToInt32(DDLcidade.SelectedValue);

        unicont = new UnidadeController();
        try
        {
            unicont.AlterarUnidade(unidade);
            Response.Redirect("Lista_Unidade_de_Ensino.aspx");
        }
        catch (Exception)
        {
            throw;
        }
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