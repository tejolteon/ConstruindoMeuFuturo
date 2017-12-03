using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class View_Perfil : System.Web.UI.Page
{
    private PerfilController perfcont;
    private PerfilBean perfil;
    private CursoBean curso;
    private CursoController cursocont;
    private AreaBean area;
    private AreaController areacont;
    private UnidadeEnsinoBean unidade;
    private UnidadeController unidadecont;
    private QuestaoController questaocont;
    private QuestaoBean questao;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Se não tiver usuario logado ele volta pra Home
        if(Session["usuario"] == null)
        {
            Response.Redirect("Home.aspx");
        }

       
        perfil = new PerfilBean();
        perfcont = new PerfilController();
        cursocont = new CursoController();
        areacont = new AreaController();
        unidadecont = new UnidadeController();
        //Label com nome do usuario
        lbNome.Text = Session["usuario"].ToString();
        int UsuarioId = int.Parse(Session["usuarioId"].ToString());
            //verifica se o status do usuario esta ativo
           // if (Session["UsuarioStatus"].ToString() == "A") {
            try
            {
                //Verifica se ele é um administrador
                if (Session["UsuarioTipo"].ToString() == "A")
                {
                  
                }
                else
                {
                    //Verifica se o usuário fez o cadastro de perfil
                    try
                    {
                        perfil = perfcont.ConsultarPerfilPorIdUsuario(UsuarioId);
                        Session["PerfilId"] = perfil.Id_perfil;
                    if (perfil == null)
                    {
                        Panel conteudo = new Panel();

                       
                            lbtAlterarPerfil.Visible = false;
                        Label lbcursounidade = new Label();
                        lbcursounidade.Text = "< div > Complete seu cadastro para receber opções de curso" +
                                "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Cadastro_Perfil.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Concluir Cadastro »</a></p></div>";
                        conteudo.Controls.Add(lbcursounidade);
                        pnPerfil.Controls.Add(conteudo);
                    }
                    else
                    {
                        //carrega os cursos sugeridos
                        Sugestoesdcurso(UsuarioId,perfil.Id_perfil);
                    }
                    }
                    catch
                    {

                    }
                }
            }
            catch { }
       // }
    }

    protected void Sugestoesdcurso(int usuarioid, int idperfil) {

        questaocont = new QuestaoController();
        questao = new QuestaoBean();
        questao = questaocont.ConsultarQuestaoNaorespondia(idperfil);

        if(questao != null)
        {
            BtQuestionario.Visible = true;
        }
      
        foreach (CursoBean curso in this.cursocont.ListarCursosIndicado(idperfil))
        {
            try
            {

                Panel cursospanel = new Panel();
                cursospanel.CssClass = "col-lg-12";
                int cont = 0;
                foreach (UnidadeEnsinoBean unidade in this.unidadecont.ListarUnidadeCurso(curso.Id))
                {
                    
                  
                    //declarando painel
                    Panel conteudo = new Panel();
                    //formantando a div
                    conteudo.CssClass = "col-lg-6 col-xs-12";
                    conteudo.Style.Add("border", "1px solid gray");
                    conteudo.Style.Add("background-color", "#D8D8D8");
                    conteudo.Style.Add("border-radius", "5px");
                 
                    //Criando o button
                    LinkButton btunidadecurso = new LinkButton();
                    btunidadecurso.Text = "Ver detalhes »";
                    btunidadecurso.CssClass = "btn btn-primary btn-lg";
                    btunidadecurso.PostBackUrl = "Curso.aspx?CursoId=" + curso.Id + "&UnidadeId=" + unidade.Id_unidade;
                    Label lbcursounidade = new Label();
                    lbcursounidade.Text = "<p><h2>" + curso.Nome + "</h2></p>" +
                    "<p>" + unidade.Nome_unidade + "</p>";
                    conteudo.Controls.Add(lbcursounidade);
                    conteudo.Controls.Add(btunidadecurso);
                   
                    cursospanel.Controls.Add(conteudo);
                    cont++;
                }
                if (cont > 2)
                {
                    cursospanel.Style.Add("overflow", "hidden");
                    cursospanel.Height = 150;
                }

                    pnPerfil.Controls.Add(cursospanel);
                if (cont > 2)
                {
                    Panel painelbutton = new Panel();
                    painelbutton.CssClass = "col-lg-12";
                    Button btvermais = new Button();
                    btvermais.Text = "Ver mais unidades";
                    btvermais.CssClass = "btn btn-warning center-block";
                    btvermais.Style.Add("width","75%");
                    painelbutton.Style.Add("position", "center");
                    painelbutton.Controls.Add(btvermais);
                   
                    pnPerfil.Controls.Add(painelbutton);
                }
               
                
       

            }
            catch
            {

            }

        }
        
    }

    protected void lbtAlterarPerfil_Click(object sender, EventArgs e)
    {
        int UsuarioId = int.Parse(Session["usuarioId"].ToString());
        perfcont = new PerfilController();
        perfil = perfcont.ConsultarPerfilPorIdUsuario(UsuarioId);

        if (perfil == null) {
            Response.Redirect("Cadastro_Perfil.aspx");
        } else
        Response.Redirect("Alterar_Perfil.aspx");
    }

    protected void lbtAlterarSenha_Click(object sender, EventArgs e)
    {
        int UsuarioId = int.Parse(Session["usuarioId"].ToString());
        Response.Redirect("Alterar_Senha.aspx");
      
    }
}