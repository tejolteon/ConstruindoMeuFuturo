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
    private CursoConstroller cursocont;
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
        cursocont = new CursoConstroller();
        areacont = new AreaController();
        unidadecont = new UnidadeController();
        //Label com nome do usuario
        lbNome.Text = Session["usuario"].ToString();
        int UsuarioId = int.Parse(Session["usuarioId"].ToString());
        //Consultando o ID do Perfil e tentando jogar para a tabela os cursos
        try
        {
            perfil = perfcont.ConsultarPerfilPorIdUsuario(UsuarioId);
            area = areacont.ConsultarAreaPerfil(perfil.Id_perfil);
            /*!!!!!!!!!!!!!!! Terminar de formatar a tabela e deixar com links acessiveis, mostrar apenas cursos que tenha na cidade depois e
           depois relacionar o curso com as unidades que tem ele,*/
            try
            {
                TableRow tr = new TableRow();
                foreach (CursoBean curso in this.cursocont.ListaCursoPorArea(area.Id))
                {
                    try
                    {
                        foreach (UnidadeEnsinoBean unidade in this.unidadecont.ListarUnidadeCurso(curso.Id))
                        {
                            TableCell tc = new TableCell();
                            //Insere 
                            tc.Text = "<font size=5><br><a href="+"Curso.aspx"+">" + curso.Nome + "<p></a>" + unidade.Nome + "</br></font>";
                            tr.Cells.Add(tc);

                            //Alinha as células
                            tr.HorizontalAlign = HorizontalAlign.Center;
                            tr.VerticalAlign = VerticalAlign.Top;

                            //Adiciona 2 colunas na tabela (FALTA SER RESPONSIVO)
                            if (tr.Cells.Count == 2)
                            {
                                TabelaCursos.Rows.Add(tr);
                                tr = new TableRow();
                            }


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
        catch {

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
}