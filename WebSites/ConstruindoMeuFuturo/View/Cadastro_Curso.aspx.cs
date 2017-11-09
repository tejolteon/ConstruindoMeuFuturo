using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Cadastro_Curso : System.Web.UI.Page
{


    private CursoBean curso;
    private CursoController cursocont;
  

    protected void Page_Load(object sender, EventArgs e)
    {
        /* Se não tiver usuario logado ele volta pra Home
        if (Session["usuario"] == null)
        {
            Response.Redirect("Home.aspx");
        }*/
    }



    protected void Btcadastrar_Click(object sender, EventArgs e)
    {
        curso = new CursoBean();
        curso.Nome = Txtnomecurso.Text;
        curso.Descricao = Txtdescricao.InnerText;
        curso.Tipo = DDLcidade.SelectedValue;

        cursocont = new CursoController();
        try
        {
            cursocont.InserirNovoCurso(curso);
            ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! iremos ver para onde vai direcionar
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
}