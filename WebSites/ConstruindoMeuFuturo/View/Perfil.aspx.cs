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
    private CursoController cursocont;
    private AreaBean area;
    private AreaController areacont;
    private UnidadeController unidadecont;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        // Se não tiver usuario logado ele volta pra Home
        if(Session["usuario"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        //Label com nome do usuario
        lbNome.Text = Session["usuario"].ToString(); 
        //Carrega os cursos segundo o perfil
        ListarCursos();
    }
   

    protected void LbtAlterarPerfil_Click(object sender, EventArgs e)
    {
        int UsuarioId = int.Parse(Session["usuarioId"].ToString());
        perfcont = new PerfilController();
        perfil = perfcont.ConsultarPerfilPorIdUsuario(UsuarioId);

        if (perfil == null) {
            Response.Redirect("Cadastro_Perfil.aspx");
        } else
        Response.Redirect("Alterar_Perfil.aspx");
    }

    protected void LbtAlterarSenha_Click(object sender, EventArgs e)
    {
        int UsuarioId = int.Parse(Session["usuarioId"].ToString());
        Response.Redirect("Alterar_Senha.aspx");
      
    }

    protected void ListarCursos()
    {
        perfil = new PerfilBean();
        perfcont = new PerfilController();
        cursocont = new CursoController();
        areacont = new AreaController();
        unidadecont = new UnidadeController();

        //Consultando o ID do Perfil e tentando jogar para a tabela os cursos
        try
        {
            int UsuarioId = int.Parse(Session["usuarioId"].ToString());
            perfil = perfcont.ConsultarPerfilPorIdUsuario(UsuarioId);
            area = areacont.ConsultarAreaPerfil(perfil.Id_perfil);
            /*!!!!!!!!!!!!!!! Terminar de formatar a tabela e deixar com links acessiveis, mostrar apenas cursos que tenha na cidade depois e
           depois relacionar o curso com as unidades que tem ele,*/
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
                                "<div class=" + "\"" + "col-6 col-lg-4" + "\"" + " >" +
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