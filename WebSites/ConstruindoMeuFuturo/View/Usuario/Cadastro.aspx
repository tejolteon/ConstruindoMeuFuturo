<%@ Page Title="" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="View_Usuario_Cadastro" %>

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
            <label for="confirmarsenha">Confirmar Senha:</label>
            <asp:TextBox ID="TxtConfirmarSenha" Class="form-control" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <br/>
        
        <div class="form-group">
            <asp:Button ID="Btcadastras" Class="form-control" Text="Cadastrar" runat="server" OnClick="Btcadastras_Click"/>
        </div>
        <br/>
        <asp:Label id="Labelerro" runat="server"></asp:Label>
    </div>
</asp:Content>

