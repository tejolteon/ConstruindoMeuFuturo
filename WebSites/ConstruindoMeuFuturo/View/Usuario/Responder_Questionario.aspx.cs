using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class View_Cadastro_Resposta : System.Web.UI.Page
{
    private RespostaController respostacont;
    private RespostaBean resposta;

    private QuestaoController questaocont;
    private QuestaoBean questao;

    private CursoController cursocont;

    private QuestionarioBean questionario;
    private QuestionarioController questionariocont;

    private CidadeController cidadecont;
    private CidadeBean cidade;
 
    int idperfil;
    int idquestao;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        idperfil = Convert.ToInt32(Session["PerfilId"]);

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Verifica se o usuario está logado, se é Administrador e se ele está ativo
        try
        {
            if (Session["usuario"] == null || Session["UsuarioStatus"].ToString() != "A")
            {
                Response.Redirect("../Home.aspx");
            }
        }
        catch
        {
            Response.Redirect("../Home.aspx");
        }

        questaocont = new QuestaoController();
        questao = new QuestaoBean();
        questao = questaocont.ConsultarQuestaoNaorespondia(idperfil);
        if (questao != null)
        {
            //Seta a label com o texto da questão
            questaotexto.Text = "<h2>" + questao.Texto_questao + "</h2>";
            //Cria um textbox para armazenar o id da questão
            idquestao = questao.Id_questao;
            //seta radio list para receber as respostas
            radiolist.Items.Clear();
            respostacont = new RespostaController();
            foreach (RespostaBean resposta in this.respostacont.ListarRespostaQuestao(questao.Id_questao))
            {
                //Cria um list item para armazenar o texto e o valor da resposta
                ListItem itemresposta = new ListItem();
                itemresposta.Text = resposta.Texto_resposta;
                itemresposta.Value = Convert.ToString(resposta.Id_resposta);
                //Armazena essa resposta na radiolis(Questão)
                radiolist.Items.Add(itemresposta);

            }
            pnQuestionario.Controls.Add(radiolist);
        }
        else {
            btProximo.Visible = false;
            questaotexto.Text = "<h1>Questionario Finalizado</h1>";
            cidade = new CidadeBean();
            cidadecont = new CidadeController();
            cidade = cidadecont.ConsultaCidadePerfil(idperfil);
                cursocont = new CursoController();
                cursocont.InserirCursoIndicadoQuestionarios(idperfil,cidade.Id_cidade);
;        }
    }

     protected void btProximo_Click(object sender, EventArgs e)
     {

        string a;
        a = Request.Form["radiolist"];
        questionario = new QuestionarioBean();  
        questionario.Id_questao = idquestao;
        questionario.Id_perfil = idperfil;
        questionario.Id_resposta = Convert.ToInt32(a);

        questionariocont = new QuestionarioController();
        try
        {
            questionariocont.InserirQuestionariopPerfil(questionario);
            questaotexto = null;
        }
        catch {
            Labelerro.Text = "Erro ao cadastrar a resposta";
        }
        Response.Redirect("Responder_Questionario.aspx");

    }

}