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
        if (Session["UsuarioStatus"].ToString() == "A")
        {
            try
            {
                //Verifica se ele é um administrador
                if (Session["UsuarioTipo"].ToString() == "A")
                {
                    ltPainel.Text += "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Cadastro_Curso.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Cadastrar um curso novo</a></p>" +
                                     "</div>" +
                                     "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Cadastro_Questao.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Cadastrar uma questão nova nova</a></p>" +
                                     "</div>" +
                                     "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Cadastro_Unidade_de_Ensino.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Cadastrar uma unidade de ensino nova</a></p>" +
                                     "</div>" +
                                     "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Adicionar_Curso_Unidade.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Adicionar Curso a unidade</a></p>" +
                                     "</div>" +
                                     "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Lista_Curso.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Consultar todos os Cursos/editar</a></p>" +
                                     "</div>" +
                                     "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Lista_Questao.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Consultar todas as Questoes/editar</a></p>" +
                                     "</div>" +
                                     "<div class=" + "\"" + "col-lg-5" + "\"" + " style=" + "\"" + "border:1px solid gray; margin-right:2px; margin-bottom:2px; background-color: #D8D8D8; border-radius:1px;" + "\"" + " > " +
                                     "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Lista_Unidade_de_Ensino.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Consultar todas as unidades de ensino/editar</a></p>" +
                                     "</div>";
                }
                else
                {
                    //Verifica se o usuário fez o cadastro de perfil
                    try
                    {
                        perfil = perfcont.ConsultarPerfilPorIdUsuario(UsuarioId);
                        if (perfil == null)
                        {
                            ltPainel.Text = "<div>Complete seu cadastro para receber opções de curso" +
                                "<p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + "Cadastro_Perfil.aspx" + "\"" + " role= " + "\"" + "button" + "\"" + " >Concluir Cadastro »</a></p></div>";
                        }
                    }
                    catch
                    {

                    }



                    try
                    {
                        //Consultando o ID do Perfil
                        perfil = perfcont.ConsultarPerfilPorIdUsuario(UsuarioId);
                        area = areacont.ConsultarAreaPerfil(perfil.Id_perfil);
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
                    catch
                    {

                    }
                }
            }
            catch { }
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