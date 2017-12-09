<%@ Page Language="C#" Title ="Cadastro" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="View_Cadastro"%>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <link href="../General/Design.css" rel="stylesheet" />
        <div class="well container" align="center" style="margin-top:2%; max-width:80%; background-color:white;">
            <asp:Panel ID="pnCadstro" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cadastro de Usuario</h1></asp:Label>
                <br/>
                <div class="form-group" style="max-width:400px;">
                    <label for="nome">Nome:</label>
                    <asp:TextBox Width="100%" CssClass="form-control" ID="txtNome" runat="server"></asp:TextBox>
                </div>
                <br/>
                <div class="form-group" style="max-width:400px;">
                    <label for="email">E-mail:</label>
                    <asp:TextBox ID="Txtemail" CssClass="form-control" Width="100%" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Txtemail" ErrorMessage="Formato de e-mail invalido"></asp:RegularExpressionValidator>
                </div>
                <br/>
                <div class="form-group" style="max-width:400px;">
                    <label for="senha">Senha:</label>
                    <asp:TextBox ID="TxtSenha" CssClass="form-control" Width="100%" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <br/>
                 <div class="form-group" style="max-width:400px;">
                    <label for="confirmarsenha">Confirmar Senha:</label>
                    <asp:TextBox ID="TxtConfirmarSenha" CssClass="form-control" Width="100%" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <br/>
                <div class="form-group">
                    <asp:Button ID="Btcadastras" CssClass="btn btn-primary" Text="Cadastrar" runat="server" Width="100px" OnClick="Btcadastras_Click"/>
                </div>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>      
    </body>
    </html>
</asp:Content>
