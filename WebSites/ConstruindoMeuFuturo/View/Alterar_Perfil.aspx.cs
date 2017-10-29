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

        perfcont = new PerfilController();
        perfil = perfcont.ConsultarPerfilPorIdUsuario(MasterPage.usuarioID);
        /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Arrumar com Try Catch
           Arrumar com Try Catch                   Arrumar com Try Catch                                              Arrumar com Try Catch

         *********************************************             *********                                              *******************/

        //Consulta Cidade_Perfil se não for null
        if (cidade != null)
        {
            cidadecont = new CidadeController();
            cidade = cidadecont.ConsultaCidadePerfil(perfil.Id_perfil);
        }
        //Recebe id da cidade se não for null
        if (cidade != null)
        { 
            idcidadeantiga = cidade.Id_cidade;
        }
        //Seleciona o estado que já estava cadastrado no BD
        if (cidade != null)
        {
            DDLestado.SelectedValue = Convert.ToString(cidade.Id);
        }
        if (area != null)
        {
            areacont = new AreaController();
            area = areacont.ConsultarAreaPerfil(perfil.Id_perfil);
        }
        if (area != null)
        {  
            //Seleciona a area
                DDLarea.SelectedValue = Convert.ToString(area.Id);
        }
        //Seleciona a data de nascimento cadastrada no BD
        Txtdatanascimento.Text = perfil.Datanascimento;
        //Seleciona a escolaridade cadastrada no BD
        DDLescolaridade.SelectedValue = perfil.Escolaridade;

        //Carrega as cidades do estado
        CarregarCidades();
        //Seleciona a cidade que já estava cadastrado no BD se o valor não for null
        if (cidade != null)
        {
            DDLcidade.SelectedValue = Convert.ToString(cidade.Id_cidade);
        }
    }

    public void CarregarCidades()
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

    protected void Btalterar_Click(object sender, EventArgs e)
    {
        //Pega o Id do usuario da MasterPage
        usuario = new UsuarioBean
        {
            Id = MasterPage.usuarioID
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