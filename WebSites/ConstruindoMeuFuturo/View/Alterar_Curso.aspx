﻿<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Alterar_Curso.aspx.cs" Inherits="View_Alterar_Curso" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <!DOCTYPE html>
    <html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
            <title></title>
        </head>
    <body>
        <link href="../General/Design.css" rel="stylesheet" />
        <div class="well container" style="margin-top:2%; max-width:60%;">
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cadastro de um novo Curso</h1></asp:Label>
                <br/>
                <div class="form-group">

                    <label for="nomeo">Nome</label>
                    <asp:TextBox ID="Txtnomecurso" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
              
                <div class="form-group">
                    <label for="tipo">Tipo de Curso</label>
                    <asp:DropDownList ID="DDLtipo" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Profissionalizante" Value="profissionalizante"/>
                        <asp:ListItem Text="Técnico" Value="téncino"/>
                        <asp:ListItem Text="Graduação" Value="graduação"/>
                        <asp:ListItem Text="Pós-Graduação" Value="Pós-graduação"/>
                    </asp:DropDownList>
                </div>
                <br/>
                 
                <!-- Lista da area de interesse -->
                <div class="form-group">
                    <label for="descricao">Descrição</label>
                </div>
                <br/>
                <textarea id="Txtdescricao" cols="20" name="S1" rows="2" runat="server"></textarea><div class="form-group">
                    <div class="text-right col-lg-6">
                        <asp:Button ID="BtAlterar" CssClass="btn btn-primary" Text="Salvar" runat="server" width="100px" OnClick="Btalterar_Click" />
                    </div>
                </div>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </body>
    </html>
</asp:Content>


