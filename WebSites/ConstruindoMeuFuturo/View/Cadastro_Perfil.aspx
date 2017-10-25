﻿<%@ Page Title="" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Cadastro_Perfil.aspx.cs" Inherits="View_Cadastro_Perfil" %>


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
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cadastro de Perfil</h1></asp:Label>
                <br/>
                <div class="form-group">
                    <label for="datanascimento">Data de Nascimento:</label>
                    <asp:TextBox ID="Txtdatanascimento" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <br/>
                <div class="form-group">
                    <label for="escolaridade">Escolaridade</label>
                    <asp:DropDownList ID="DDLescolaridade" runat="server">
                        <asp:ListItem Text="Esino Fundamental Incompelto" Value="Esino Fundamental Incompelto"/>
                        <asp:ListItem Text="Esino Fundamental Compelto" Value="Esino Fundamental Compelto"/>
                        <asp:ListItem Text="Esino Médio Incompelto" Value="Esino Médio Incompelto"/>
                        <asp:ListItem Text="Esino Médio Compelto" Value="Esino Médio Compelto"/>
                        <asp:ListItem Text="Esino Superior Incompelto" Value="Esino Superior Incompelto"/>
                        <asp:ListItem Text="Esino Superior Compelto" Value="Esino Superior Compelto"/>
                    </asp:DropDownList>
                </div>
                <br/>
                 <div class="form-group">
                    <label for="estado">Estado</label>
                    <asp:DropDownList ID="DDLestado" runat="server">
                        <asp:ListItem Text="São Paulo" Value="São Paulo"/>
                    </asp:DropDownList>
                </div>
                <br/>
                <div class="form-group">
                    <label for="cidade">Cidade</label>
                    <!--O valor está fixo porque só tem São Paulo por enquanto,
                            depois iremos pegar os valores a partir do banco-->
                    <asp:DropDownList ID="DDLcidade" runat="server">
                        <asp:ListItem Text="São Paulo" Value="5270"/>
                    </asp:DropDownList>
                </div>
                <br/>
                <div class="form-group">
                    <label for="area">Area de Interesse</label>
                    <!--Depois pegaremos a partir do banco de dados-->
                    <asp:DropDownList ID="DDLarea" runat="server">
                        <asp:ListItem Text="Administração" Value="1"/>
                        <asp:ListItem Text="Negócios e Serviços" Value="2"/>
                        <asp:ListItem Text="Artes e Design" Value="3"/>
                        <asp:ListItem Text="Ciências Biológicas" Value="4"/>
                        <asp:ListItem Text="Ciências Exatas" Value="5"/>
                        <asp:ListItem Text="Ciências da Terra" Value="6"/>
                        <asp:ListItem Text="Informática" Value="7"/>
                        <asp:ListItem Text="Ciências Sociais" Value="8"/>
                        <asp:ListItem Text="Humanas" Value="9"/>
                        <asp:ListItem Text="Comunicação e Informação" Value="10"/>
                        <asp:ListItem Text="Engenharia e Produção" Value="11"/>
                        <asp:ListItem Text="Ciências da Saúde" Value="12"/>
                        <asp:ListItem Text="Ciências Agrárias" Value="13"/>
                        <asp:ListItem Text="Linguistica" Value="14"/>
                        <asp:ListItem Text="Letras" Value="15"/>
                    </asp:DropDownList>
                </div>
                <br/>
                <div class="form-group text-right">
                    <asp:Button ID="BtCadastrar" CssClass="btn btn-primary" Text="Salvar" runat="server" width="100px" OnClick="Btcadastrar_Click" />
                </div>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </body>
    </html>
</asp:Content>


