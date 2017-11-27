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
                    LabelTop.Text = "<h1> Gerenciador </h1>";
                    ltPainel.Text += "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Lista_Curso.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Cursos</a></p>" +
                                     "</div>" +
                                     "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Lista_Questao.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Questionario</a></p>" +
                                     "</div>" +
                                     "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Lista_Unidade_de_Ensino.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Unidade de ensino</a></p>" +
                                     "</div>";
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
                            ltPainel.Text = "<div>Complete seu cadastro para receber opções de curso" +
                                "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Cadastro_Perfil.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Concluir Cadastro »</a></p></div>";
                            lbtAlterarPerfil.Visible = false;
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

        //se não ter respondido o questionario ele recomenda apenas pela area
        if (questao != null)
        {
            BtQuestionario.Visible = true;
            try
            {
                //Consultando o ID do Perfil
                
                foreach (AreaBean area in this.areacont.ListarAreaPerfil(idperfil))
                {
                    try
                    {
                        foreach (CursoBean curso in this.cursocont.ListaCursoPorArea(area.Id))
                        {
                            try
                            {
                                foreach (UnidadeEnsinoBean unidade in this.unidadecont.ListarUnidadeCurso(curso.Id))
                                {
                                    //Insere os valores no literal com a formatação devida
                                    ltPainel.Text += "" +
                                        "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:20px; margin-bottom:20px; background-color: #D8D8D8; border-radius:5px;" + "\"" + " > " +
                                        "<p><h2>" + curso.Nome + "</h2></p>" +
                                        "<p>" + unidade.Nome_unidade + "</p>" +
                                        //Button para ver detalhes
                                        "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Curso.aspx?CursoId=" + curso.Id + "&UnidadeId=" + unidade.Id_unidade + " " + "\"" + " role= " + "\"" + "button" + "\"" + " >Ver detalhes »</a></p>" +
                                        "</div>";
                                    //obs.: "\"" é igual a "
                                }

                            }
                            catch
                            {

                            }

                        }
                    }
                    catch
                    {
                        throw new ErroTabelaCursoException("Erro ao preencher tabela");
                    }
                }
            }
            catch
            {

            }
        }

        //ele lista pelos cursos recomendados
        else
        {
            foreach (AreaBean area in this.areacont.ListarAreaPerfil(idperfil))
            {
                cursocont = new CursoController();
                foreach (CursoBean curso in this.cursocont.ListaCursoPorArea(area.Id))
                {
                    
                    foreach (CursoBean curso2 in this.cursocont.ListarCursosIndicado(idperfil))
                    {
                        if (curso2.Id == curso.Id)
                        {

                            try
                            {
                                foreach (UnidadeEnsinoBean unidade in this.unidadecont.ListarUnidadeCurso(curso2.Id))
                                {
                                    //Insere os valores no literal com a formatação devida
                                    ltPainel.Text += "" +
                                        "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:20px; margin-bottom:20px; background-color: #D8D8D8; border-radius:5px;" + "\"" + " > " +
                                        "<p><h2>" + curso2.Nome + "</h2></p>" +
                                        "<p>" + unidade.Nome_unidade + "</p>" +
                                        //Button para ver detalhes
                                        "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Curso.aspx?CursoId=" + curso2.Id + "&UnidadeId=" + unidade.Id_unidade + " " + "\"" + " role= " + "\"" + "button" + "\"" + " >Ver detalhes »</a></p>" +
                                        "</div>";
                                    //obs.: "\"" é igual a "
                                }

                            }
                            catch
                            {

                            }
                        }

                    }
                }
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