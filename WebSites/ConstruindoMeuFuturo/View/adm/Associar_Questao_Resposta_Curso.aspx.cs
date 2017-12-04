using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Associar_Questao_Resposta_Curso : System.Web.UI.Page
{


  
    private CursoBean curso;
    private CursoController cursocont;
    private int idresposta;
    private int idquestao;

    protected void Page_Load(object sender, EventArgs e)
    {
        idquestao = Convert.ToInt32(Request.QueryString["Id_Questao"]);
        idresposta = Convert.ToInt32(Request.QueryString["Id_Resposta"]);

        //Verifica se o usuario está logado, se é Administrador e se ele está ativo
        try
        {
            if (Session["usuario"] == null || Session["UsuarioTipo"].ToString() != "A" || Session["UsuarioStatus"].ToString() != "A")
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }
        catch
        {
            Response.Redirect("~/View/Home.aspx");
        }


       
        if (!Page.IsPostBack)
        {
            CarregargrdDados();
            CarregargrdQuestaoRespostaCurso();
        }
    }


    protected void CarregargrdDados()
    {
        cursocont = new CursoController();
        var listaCursos = cursocont.ListaCurso();
        if (listaCursos != null)
        {
            this.grdDados.DataSource = listaCursos;
            this.grdDados.DataBind();

        }
    }

    protected void CarregargrdQuestaoRespostaCurso()
    {
        cursocont = new CursoController();
        var listaCursosRespostaQuestao = cursocont.ListaCursoRespostaQuestao(idquestao,idresposta);
        if (listaCursosRespostaQuestao != null)
        {
            this.grdQuestaoRespostaCurso.DataSource = listaCursosRespostaQuestao;
            this.grdQuestaoRespostaCurso.DataBind();

        }
    }
    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Adicionar"))
        {
            string idCurso = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idCurso))
            {
                cursocont = new CursoController();
                try
                {
                   cursocont.InserirCursoRespostaQuestao(idresposta, idquestao, Convert.ToInt32(idCurso));
                    CarregargrdQuestaoRespostaCurso();
                }
                catch
                {

                }
            }
        }
    }

    protected void grdQuestaoRespostaCurso_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Excluir"))
        {
            string idCurso = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idCurso))
            {
                cursocont = new CursoController();
                try
                {
                    cursocont.ExcluirCursoRespostaQuestao(idresposta, idquestao, Convert.ToInt32(idCurso));
                    CarregargrdQuestaoRespostaCurso();
                }
                catch
                {

                }
            }
        }
    }
    protected void Txtpesquisa_TextChanged(object sender, EventArgs e)
    {
        this.grdDados.DataSource = null;
        cursocont = new CursoController();
        var listaCursos = cursocont.ListaCursoPorNome(Txtpesquisa.Text);
        if (listaCursos != null)
        {
            this.grdDados.DataSource = listaCursos;
            this.grdDados.DataBind();

        }
    }
}