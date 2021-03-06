﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Adicionar_Resposta_Questao : System.Web.UI.Page
{


    private QuestaoBean questao;
    private RespostaBean resposta;

    private QuestaoController questaocont;
    private RespostaController respostacont;

    private QuestionarioBean questionario;
    private QuestionarioController questionariocont;

    private int idquestao;

    protected void Page_Load(object sender, EventArgs e)
    {
        idquestao = Convert.ToInt32(Request.QueryString["Id_Questao"]);

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

            questaocont = new QuestaoController();
            questao = new QuestaoBean();
            respostacont = new RespostaController();

            try
            {
                //Consulta o texto da questão
                questao = questaocont.ConsultarQuestaoPorId(idquestao);
                LabelQuestao.Text = "<h1>"+questao.Texto_questao+"</h1>";
            }
            catch {

            }
            CarregagrdRespostasJaAdicionadas();
            CarregagrdRespostasCadastradas();


        }
    }

    protected void CarregagrdRespostasJaAdicionadas()
    {
        respostacont = new RespostaController();
        //Carregar lista
        var listaRepostasQuestao = respostacont.ListarRespostaQuestao(idquestao);
        if (listaRepostasQuestao != null)
        {

            this.grdRespostaQuestao.DataSource = listaRepostasQuestao;
            this.grdRespostaQuestao.DataBind();

        }
    }

    protected void CarregagrdRespostasCadastradas(){

        //Carrega lista respostas já adicionadas
        var listaRespostas = respostacont.ListarResposta();
        if (listaRespostas != null)
        {

            this.grdDados.DataSource = listaRespostas;
            this.grdDados.DataBind();

        }
    }

    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Adicionar"))
        {
            string idResposta = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idResposta)) {
                questionariocont = new QuestionarioController();
                questionario = new QuestionarioBean();

                questionario.Id_resposta = Convert.ToInt32(idResposta);
                try
                {
                    questionariocont.InserirQuestionario(questionario.Id_resposta, idquestao);
                    CarregagrdRespostasJaAdicionadas();
                }
                catch
                {

                }
            }
                
        }

        
    }
    protected void grdRespostaQuestao_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Excluir"))
        {
            string idResposta = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idResposta))
            {

                questionariocont = new QuestionarioController();
                questionario = new QuestionarioBean();

                questionario.Id_resposta = Convert.ToInt32(idResposta);
                try
                {
                    questionariocont.ExcluirQuestionario(questionario.Id_resposta, idquestao);
                    //Atualiza grd com os já cadastrados
                    CarregagrdRespostasJaAdicionadas();
                }
                catch {

                }
            }
        }

        if (e.CommandName.Equals("Associar"))
        {
            string idResposta = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idResposta))
            {
                this.Response.Redirect("Associar_Questao_Resposta_Curso.aspx?Id_Resposta=" + idResposta + "&Id_Questao=" + idquestao);
            }
        }
    }


    protected void Txtpesquisa_TextChanged(object sender, EventArgs e)
    {
        this.grdDados.DataSource = null;
        respostacont = new RespostaController();
        var listaRespostas = respostacont.ListarRespostaTexto(Txtpesquisa.Text);
        if (listaRespostas != null)
        {
            this.grdDados.DataSource = listaRespostas;
            this.grdDados.DataBind();

        }
    }

    protected void Btcadastras_Click(object sender, EventArgs e)
    {

        //Colocando os valores no bean
        resposta = new RespostaBean();
        resposta.Texto_resposta = txtTextoresposta.InnerText;


        //Mandando para o controler
        respostacont = new RespostaController();
        try
        {
            respostacont.InserirNovaResposta(resposta);
            CarregagrdRespostasCadastradas();
        }
        catch (RespostaInvalidaException)
        {
            Labelerro.Text = "Campo de texto é obrigatório";
        }
        catch (Exception)
        {

            throw;
        }
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        pnCadastro.Visible = true;
        btnPainelCadastrar.Visible = false;
    }

    protected void BtVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Lista_Questao.aspx");
    }
}