<%@ Page Title="Meu Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Perfil.aspx.cs" Inherits="View_Perfil" %>

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
            
        <div class="container-fluid well-sm col-lg-2 col-sm-5 col-xs-12" style="margin-top:2%; background-color: white;"> 
            <asp:Panel ID="pnInfo" runat="server">
                <h1>Meu Perfil</h1>
                <div class="col-lg-12">
                    <asp:Image ID="imgPerfil" runat="server" Height="200" Width="150"/>
                </div>
                <div class="col-lg-12">
                    <br />
                    <asp:Label ID="lbNome" runat="server" Text="Nome"></asp:Label>
                    <br />
                    <asp:Label ID="lbCidade" runat="server" Text="São Paulo"></asp:Label>
                    <br />
                    <asp:LinkButton ID="lbtAlterarPerfil" runat="server" OnClick="lbtAlterarPerfil_Click">Alterar Informações</asp:LinkButton>
                    <br />
                    <asp:LinkButton ID="lbtAlterarSenha" runat="server" OnClick="lbtAlterarSenha_Click" >Alterar Senha</asp:LinkButton>
                    <br />
                </div>
            </asp:Panel>
        </div>
            <div class="col-lg-1 col-sm-1"></div>
        <div class="container well-lg col-lg-9 col-sm-6 col-xs-12" style="">
            <asp:Panel ID="pnPerfil" runat="server" class="row">
                <asp:Label ID="LabelTop" runat="server" Text="<h1>Sugestões de Cursos</h1>"></asp:Label>
                   <!-- Literal que recebe cursos ou tela administrativa -->
                <asp:Literal ID="ltPainel" runat="server"></asp:Literal>      
             </asp:Panel>
        </div>
        </div>
    </body>
    </html>
</asp:Content>
