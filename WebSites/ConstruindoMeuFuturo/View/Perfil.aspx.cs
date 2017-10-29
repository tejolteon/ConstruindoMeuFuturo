﻿using System;
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
    protected void Page_Load(object sender, EventArgs e)
    {
        lbNome.Text = MasterPage.nome;
        try
        {
            perfcont.ConsultarPerfilPorIdUsuario(MasterPage.usuarioID);
            ListarTabela(perfil.Id_perfil);
        }
        catch {
        }
    }
    public void ListarTabela(int idarea)
    {
        foreach (CursoBean curso in this.cursocont.ListaCursoPorArea(idarea))
        {
            TabelaCursos.Equals(new ListItem(curso.Nome, Convert.ToString(curso.Id)));
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