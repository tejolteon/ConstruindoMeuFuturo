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
    private CidadeBean cidade;
    private UsuarioBean usuario;
    private AreaBean area;
    private UsuarioController usuCont;
    private CidadeController cidadecont;
    private AreaController areacont;
    private CursoController cursocont;
    int cont;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Verifica se o usuario está logado e se ele está ativo
        
        if (Session["usuario"] == null || Session["UsuarioStatus"].ToString() != "A")
            {
            Response.Redirect("Home.aspx");
        }

        areacont = new AreaController();
        //Lista todas as areas
        foreach (AreaBean area in this.areacont.ListarAreas())
        {
            ListItem itemarea = new ListItem();
            itemarea.Text = area.Nome;
            itemarea.Value = Convert.ToString(area.Id);
            CheckBox asdas = new CheckBox();
            CheckListArea.Items.Add(itemarea);
            cont++;
        }
    }

    protected void Btcadastrar_Click(object sender, EventArgs e)
    {
        perfil = new PerfilBean();
        perfil.Datanascimento = Txtdatanascimento.Text;
        perfil.Escolaridade = DDLescolaridade.SelectedValue;


        if (Convert.ToInt32(DDLcidade.SelectedValue) == 0)
        {
            Labelerro.Text = "Campo estado e cidade obrigatórios";
        }
        else
        {


            cidade = new CidadeBean();
            cidade.Id_cidade = Convert.ToInt32(DDLcidade.SelectedValue);

            usuario = new UsuarioBean();
            usuario.Id = int.Parse(Session["usuarioId"].ToString());


            //Mandando para o controler
            perfcont = new PerfilController();
            usuCont = new UsuarioController();
            try
            {
                cursocont = new CursoController();
                usuario = usuCont.ConsultarUsuarioPorID(usuario.Id);
                int idperfil = perfcont.InserirNovoPerfil(usuario, perfil, cidade);
                perfil.Id_perfil = idperfil;

                for (int i = 0; i < cont; i++)
                {
                    bool selecionado = CheckListArea.Items[i].Selected;
                    if (selecionado == true)
                    {
                        area = new AreaBean();
                        area.Id = Convert.ToInt16(CheckListArea.Items[i].Value);
                        perfcont.InserirPerfilArea(perfil, area);
                        //Insere mais 1 ponto no curso indicado se o curso pertencer a area
                        cursocont.InserirCursoIndicadoArea(perfil.Id_perfil);
                    }

                }
                Response.Redirect("Perfil.aspx");
            }
            catch (Exception)
            {
                throw;
            }
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
}