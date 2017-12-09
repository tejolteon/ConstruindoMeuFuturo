using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Cursos_Curso : System.Web.UI.Page
{
    private CursoBean curso;
    private CursoController cursocont;
    private UnidadeEnsinoBean unidade;
    private UnidadeController unidadecont;
    private ProgramaController programacont;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Se não tiver usuario logado ele volta pra Home
        if (Session["usuario"] == null)
        {
            Response.Redirect("../Home.aspx");
        }

        unidade = new UnidadeEnsinoBean();
        unidadecont = new UnidadeController();

        //Le o Id da unidade que está na URL
        unidade.Id_unidade = Convert.ToInt32(Request.QueryString["UnidadeId"]);

        curso = new CursoBean();
        cursocont = new CursoController();
        //Ler o Id do curso que está na URL
        curso.Id = Convert.ToInt32(Request.QueryString["CursoId"]);
        try
        {
            unidade = unidadecont.ConsultarUnidadeId(unidade.Id_unidade);
        }
        catch {
            //Erro ao consulta Unidade
        }

        try{
            curso = cursocont.ConsultarCursoId(curso.Id);
        }

        catch {
            //Erro ao consultar curso
        }
        try
        {
            //Colocar Os valores das variaveis no literal, jogando com a formatação 
            ltConteudo.Text = " <div class=" + "\"" + "text-center" + "\"" + " ><h2><p>" + curso.Nome + " - " + unidade.Nome_unidade + "</p></h2></div>" +
            "<p>De acordo com seus dados selecionamos o curso de " + curso.Nome + " na " + unidade.Nome_unidade + "</p>" +
            "<div class=" + "\"" + "text-center" + "\"" + " > <h2><p>O Curso</p></h2></div>" +
            "<p>" + curso.Descricao + "</p>" +
            "<div class=" + "\"" + "text-center" + "\"" + " > <h2><p>A faculdade</p></h2></div>" +
            "<p>" + unidade.Descricao_unidade + "</p>" +
            "<p>Endereço: " + unidade.Endereco_unidade + "</p>";
            int cont = 0;
            programacont = new ProgramaController();
            foreach (ProgramaBean programa in this.programacont.ListarProgramasUnidade(unidade.Id_unidade))
            {
                cont++;
                if(cont == 1)
                {
                    ltConteudo.Text += " <div class=" + "\"" + "text-center" + "\"" + "><h2><p>Formas de ingresso</p></h2>" +
                   "<p> ";
                }
                ltConteudo.Text +="<p>" + programa.Nome + " </p>";
            }
            //Button para entrar no site da unidade de ensino
            ltConteudo.Text += " </div> <p><a class= " + "\"" + "btn btn-primary btn-lg" + "\"" + " href= " + "\"" + unidade.Site + "\"" + " target=" + "\"" + "resource window" +"\"" + " role= " + "\"" + "button" + "\"" + " >Site da faculdade</a></p>";
        }
        catch { 
            //erro ao preencher lbConteudo
        }
        //obs.: "\"" é igual a "
    }
}