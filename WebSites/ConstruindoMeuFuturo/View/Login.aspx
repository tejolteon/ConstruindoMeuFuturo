<%@ Page Title="" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="View_Usuario_Login" %>
   
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
                <asp:Label ID="Label1" runat="server" Text=""><h1>Login</h1></asp:Label>
                <br/>
                <div class="form-group">
                    <label for="email">E-mail:</label>
                    <asp:TextBox ID="Txtemail" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <br/>
                <div class="form-group">
                    <label for="senha">Senha:</label>
                    <asp:TextBox ID="TxtSenha" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <br/>
                <div class="form-group text-right">
                    <asp:Button ID="Btlogin" CssClass="btn btn-primary" Text="Entrar" runat="server" width="100px" OnClick="Btlogin_Click" />
                </div>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </body>
    </html>
</asp:Content>

