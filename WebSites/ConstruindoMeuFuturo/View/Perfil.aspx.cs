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
    
    protected void Page_Load(object sender, EventArgs e)
    {
        perfil = new PerfilBean();
        perfcont = new PerfilController();
        cursocont = new CursoConstroller();
        areacont = new AreaController();
        //Label com nome do usuario
        lbNome.Text = MasterPage.nome;
        //Consultando o ID do Perfil e tentando jogar para a tabela os cursos
        try
        {
            perfil = perfcont.ConsultarPerfilPorIdUsuario(MasterPage.usuarioID);
            area = areacont.ConsultarAreaPerfil(perfil.Id_perfil);
            /*!!!!!!!!!!!!!!! Terminar de formatar a tabela e deixar com links acessiveis, mostrar apenas cursos que tenha na cidade depois e
           depois relacionar o curso com as unidades que tem ele,*/
            try
            {
                foreach (CursoBean curso in this.cursocont.ListaCursoPorArea(area.Id))
                {
                    ListItem i;
                    i = new ListItem(curso.Nome, Convert.ToString(curso.Id));
                    TableRow tr = new TableRow();
                    TableCell tc = new TableCell();
                        tc.Text = "<font size=5>" + curso.Nome + "</font>";
                        tr.Cells.Add(tc);
  
                        tr.HorizontalAlign = HorizontalAlign.Center;
                        tr.VerticalAlign = VerticalAlign.Top;
                        TabelaCursos.Rows.Add(tr);
          
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
        perfcont = new PerfilController();
        perfil = perfcont.ConsultarPerfilPorIdUsuario(MasterPage.usuarioID);

        if (perfil == null) {
            Response.Redirect("Cadastro_Perfil.aspx");
        } else
        Response.Redirect("Alterar_Perfil.aspx");
    }
}