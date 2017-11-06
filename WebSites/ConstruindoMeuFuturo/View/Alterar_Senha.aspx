<%@ Page Title="Alterar Senha" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Alterar_Senha.aspx.cs" Inherits="View_Alterar_Perfil" %>


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
                <asp:Label ID="Label1" runat="server" Text=""><h1>Alterar Senha</h1></asp:Label>
                <div class="form-group">
                    <label for="SenhaAtual">Senha Atual:</label>
                    <asp:TextBox ID="TxtSenha" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <br/>
                <div class="form-group">
                    <label for="NovaSenha">Nova Senha:</label></div>
                <asp:TextBox ID="TxtSenhaNova" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                <br/>
                 <label for="NovaSenha"> Confirmar Nova Senha:</label>
                    <asp:TextBox ID="TxtConfirmarSenhaNova" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                <br/>

                <div class="form-group">
                    <div class="text-left col-lg-6">
                        <asp:LinkButton ID="lbtMTarde" runat="server" CssClass="text-left" OnClick="lbtMTarde_Click">Mais Tarde</asp:LinkButton>
                    </div>
                    <div class="text-right col-lg-6">
                        <asp:Button ID="Btalterar" CssClass="btn btn-primary" Text="Salvar" runat="server" width="100px" OnClick="Btalterar_Click" />
                    </div>
                </div>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </body>
    </html>
</asp:Content>



