<%@ Page Title="" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="View_Usuario_Login" %>
   
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="../../General/Design.css" rel="stylesheet" />
        <link href="../../bootstrap/css/bootstrap.css" rel="stylesheet" />
        <script src="../../bootstrap/js/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <div>
        <div class="form-group">
            <label for="email">E-mail:</label>
            <asp:TextBox ID="Txtemail" Class="form-control" runat="server"></asp:TextBox>
        </div>
        <br/>
        <div class="form-group">
            <label for="senha">Senha:</label>
            <asp:TextBox ID="TxtSenha" Class="form-control" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <br/>
        <div class="form-group">
            <asp:Button ID="Btlogin" Class="form-control" Text="Entrar" runat="server" OnClick="Btlogin_Click" />
        </div>
        <br/>
        <asp:Label id="Labelerro" runat="server"></asp:Label>
    </div>
</asp:Content>

