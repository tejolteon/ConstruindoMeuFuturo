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
    private CursoController cursocont;
    int cont;
    int idcidadeantiga;//? caso depois façamos o cadastro de mais de uma cidade precisara saber qual estava cadastrada antes para saber qual delas deve trocar

    protected void Page_Load(object sender, EventArgs e)
    {
        //Verifica se o usuario está logado, e se ele está ativo

        if (Session["usuario"] == null || Session["UsuarioStatus"].ToString() != "A")
        {
            Response.Redirect("Home.aspx");
        }
        //Verifica se a lista de areas está vazia antes de executar o código
       
       
        //Limpa contador
        cont = 0;

        areacont = new AreaController();
        //adiciona as areas cadastradas no Bd ao CheckListBox
        foreach (AreaBean area in this.areacont.ListarAreas())
        {
            ListItem itemarea = new ListItem();
            itemarea.Text = area.Nome;
            itemarea.Value = Convert.ToString(area.Id);
            CheckBox asdas = new CheckBox();
            CheckListArea.Items.Add(itemarea);
            cont++;
        }

        if (!Page.IsPostBack) // Função preenche os campos só quando a pagina é renderizada pela primeira vez
        {
            CarregarCamposAlterar();
        }
    }
    private void CarregarCamposAlterar()
    {
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
        catch
        {

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
            foreach (AreaBean area1 in this.areacont.ListarAreaPerfil(perfil.Id_perfil))
            {
                for (int i = 0; i < cont; i++)
                {
                    
                    bool selecionado = CheckListArea.Items[i].Selected;
                    if (Convert.ToInt16(CheckListArea.Items[i].Value) == area1.Id)
                    {
                        CheckListArea.Items[i].Selected = true;
                    }

                }
            }            
        }
        catch
        {

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
        catch
        {

        }

        //Seleciona a cidade que já estava cadastrado no BD
        if (cidade.Id_cidade != 0)
        {
            DDLcidade.SelectedValue = Convert.ToString(cidade.Id_cidade);
        }
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

        //Pegando o id no campo
        cidade = new CidadeBean();
        cidade.Id_cidade = Convert.ToInt32(DDLcidade.SelectedValue);

        //Controller Usuario
        usuCont = new UsuarioController();

        try
        {
            cursocont = new CursoController();
            //Consulta o Usuario pelo ID para pegar as informações do usuario
            usuario = usuCont.ConsultarUsuarioPorID(usuario.Id);

            perfcont.AlterarPerfil(usuario, perfil, cidade, idcidadeantiga);
            //Retira os pontos adicionados pela area do curso
            cursocont.RetirarCursoIndicadoArea(perfil.Id_perfil);
            //Exclui todas as areas associadas ao perfil
            perfcont.ExcluirPerfilArea(perfil);
            for (int i = 0; i < cont; i++)
            {
                bool selecionado = CheckListArea.Items[i].Selected;
                if (selecionado == true)
                {
                    area = new AreaBean();
                    area.Id = Convert.ToInt16(CheckListArea.Items[i].Value);
                    try
                    {
                        perfcont.InserirPerfilArea(perfil, area);
                        cursocont.InserirCursoIndicadoArea(perfil.Id_perfil);
                    }
                    catch {

                    }
                }

            }
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
        //Ao selecionar um estado ele carrega as cidades do BD
        CarregarCidades();
    }
}

    
