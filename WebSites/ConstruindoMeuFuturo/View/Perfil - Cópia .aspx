<%@ Page Title="Meu Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Perfil - Cópia .aspx.cs" Inherits="View_Perfil" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <link href="../General/Design.css" rel="stylesheet" />
        <div class="col-lg-12">
        <div class="container well col-lg-4 col-sm-6 col-xs-12" style="margin-top:2%;">
            <h1>Meu Perfil</h1>
            <asp:Panel ID="pnInfo" runat="server">
                <div class="col-lg-12 col-sm-12 col-xs-4">
                    <asp:Image ID="imgPerfil" runat="server" Height="200" Width="150"/>
                </div>
                <div class="col-lg-12 col-sm-12 col-xs-8">
                    <br />
                    <asp:Label ID="lbNome" runat="server" Text="Nome"></asp:Label>
                    <br />
                    <asp:Label ID="lbCidade" runat="server" Text="São Paulo"></asp:Label>
                    <br />
                    <asp:LinkButton ID="lbtAlterarPerfil" runat="server" OnClick="lbtAlterarPerfil_Click">Alterar Informações</asp:LinkButton>
                    <br />
                    <asp:LinkButton ID="lbtAlterarSenha" runat="server">Alterar Senha</asp:LinkButton>
                    <br />
                </div>
            </asp:Panel>
        </div>      
        <div class="container well col-lg-8 col-sm-6 col-xs-12" style="margin-top:2%;">
            <asp:Panel ID="pnPerfil" runat="server">
                <h1>Sugestões de Cursos</h1>
                <a href="Curso.aspx">
                    <h3>ANÁLISE E DESENVOLVIMENTO DE SISTEMAS</h3>
                    <h4>FATEC ZONA SUL – DOM EVARISTO ARNS</h4>
                </a>
                <a>
                    <h3>ANÁLISE E DESENVOLVIMENTO DE SISTEMAS</h3>
                    <h4>FATEC IPIRANGA – PASTOR ENÉAS TOGNINI</h4>
                </a>
                <a>
                    <h3>ANÁLISE E DESENVOLVIMENTO DE SISTEMAS</h3>
                    <h4>ESTÁCIO – CAMPUS SANTO AMARO</h4>
                </a>
            </asp:Panel>
        </div>
        </div>
    </body>
    </html>
</asp:Content>
