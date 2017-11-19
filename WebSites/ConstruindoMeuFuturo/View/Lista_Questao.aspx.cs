﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Lista_Questao : System.Web.UI.Page
{


  
    private QuestaoBean questao;
    private QuestaoController questaocont;

    protected void Page_Load(object sender, EventArgs e)
    {
     
        try
        {
            if (Session["usuario"] == null || Session["UsuarioTipo"].ToString() != "A")
            {
                Response.Redirect("Home.aspx");
            }
        }
        catch
        {
            Response.Redirect("Home.aspx");
        }


        questaocont = new QuestaoController();
        if (!Page.IsPostBack)
        {
            var listaQuestoes = questaocont.ListarQuestao();
            if (listaQuestoes != null)
            {
                this.grdDados.DataSource = listaQuestoes;
                this.grdDados.DataBind();
                
            }
        }
    }

    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Editar"))
        {
            string idQuestao = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(idQuestao))
                this.Response.Redirect("Alterar_Questao.aspx?Id_Questao=" + idQuestao);
        }
    }
    //Após selecionar estado ele adiciona as cidades do estado


}