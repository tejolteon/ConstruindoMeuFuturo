using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Alterar_Perfil : System.Web.UI.Page
{


    private PerfilController perfcont;
    private PerfilBean perfil;
    private AreaBean area;
    private CidadeBean cidade;
    private UsuarioBean usuario;
    private UsuarioController usuCont;
    private AreaController areacont;
    private CidadeController cidadecont;
    int idcidadeantiga;//? caso depois façamos o cadastro de mais de uma cidade precisara saber qual estava cadastrada antes para saber qual delas deve trocar

    protected void Page_Load(object sender, EventArgs e)
    {
        // Se não tiver usuario logado ele volta pra Home
        if (Session["usuario"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        //Verifica se a lista de areas está vazia antes de executar o código
        if (DDLarea.Items.Count <= 1)
        {
            areacont = new AreaController();
            //Lista todas as areas
            foreach (AreaBean area in this.areacont.ListarAreas())
            {
                DDLarea.Items.Add(new ListItem(area.Nome, Convert.ToString(area.Id)));
            }
            //Carrega as informações que já contem no perfil

            CarregarCamposAlterar();
        }
        
    }
    public void CarregarCamposAlterar() {
        perfil = new PerfilBean();
        cidade = new CidadeBean();
        area = new AreaBean();
        int usuarioID = int.Parse(Session["usuarioId"].ToString());

        perfcont = new PerfilController();
        perfil = perfcont.ConsultarPerfilPorIdUsuario(usuarioID);
        /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                        ARRUMAR     OS      TRY's     CATCH's     cCOM        ERROS
         *********************************************             *********                                              *******************/

        //Consulta Cidade_Perfil
        try
        {
            cidadecont = new CidadeController();
            cidade = cidadecont.ConsultaCidadePerfil(perfil.Id_perfil);
        }
        catch {

        }

        if (cidade.Id_estado != 0)
        {
            idcidadeantiga = cidade.Id_cidade;//Não funcional ainda(Servira para quando a tabela estiver N * N)
           
            //Seleciona o estado que já estava cadastrado no BD
            DDLestado.SelectedValue = Convert.ToString(cidade.Id_estado);
        }
        
        
        //Consulta Area_Perfil
        try
        {
            areacont = new AreaController();
            area = areacont.ConsultarAreaPerfil(perfil.Id_perfil);
        }
        catch {

        }

        //Seleciona a area
        if (area.Id != 0)
        {
            DDLarea.SelectedValue = Convert.ToString(area.Id);
        }

        //Seleciona a data de nascimento cadastrada no BD
        Txtdatanascimento.Text = perfil.Datanascimento;

        //Seleciona a escolaridade cadastrada no BD
        DDLescolaridade.SelectedValue = perfil.Escolaridade;

        //Carrega as cidades do estado
        try
        {
            CarregarCidades();
        }
        catch {

        }

        //Seleciona a cidade que já estava cadastrado no BD
        if (cidade.Id_cidade != 0)
        {
            DDLcidade.SelectedValue = Convert.ToString(cidade.Id_cidade);
        }
    }

    public void CarregarCidades()
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
        //Pega o Id do usuario da MasterPage
        usuario = new UsuarioBean
        {
            Id = int.Parse(Session["usuarioId"].ToString())
    };
        perfil = new PerfilBean();

        //Consulta o perfil pelo id do usuario
        perfcont = new PerfilController();
        perfil = perfcont.ConsultarPerfilPorIdUsuario(usuario.Id);

        perfil.Datanascimento = Txtdatanascimento.Text;
        perfil.Escolaridade = DDLescolaridade.SelectedValue;

        //Pegando os ids nos campos
        area = new AreaBean();
        area.Id = Convert.ToInt32(DDLarea.SelectedValue);
        
     
        cidade = new CidadeBean();
        cidade.Id_cidade = Convert.ToInt32(DDLcidade.SelectedValue);
            
        //Controller Usuario
        usuCont = new UsuarioController();
        
        try
        {       
            //Consulta o Usuario pelo ID para pegar as informações do usuario
            usuario = usuCont.ConsultarUsuarioPorID(usuario.Id);

            perfcont.AlterarPerfil(usuario, perfil, area, cidade,idcidadeantiga);
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
        //Ao selecionar um estado ele carrega as cidades do BD
        CarregarCidades();
    }
}