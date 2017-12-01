<%@ Page Title="Login" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Login_adm.aspx.cs" Inherits="View_Usuario_Login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">    
       <br/>
        <link href="../General/Design.css" rel="stylesheet" />
        <div class="container" style="margin-top:2%; max-width:380px;">
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" CssClass="text-center" runat="server" Text=""><h1>Login</h1></asp:Label>
                <br/>
                <div class="form-group">
                    <%--<label for="email">E-mail:</label>--%>
                    <asp:TextBox ID="Txtemail" CssClass="form-control"  width="100%"  Height="40px" runat="server" placeholder="E-mail"></asp:TextBox>
                <%--</div>
                <br/>
                <div class="form-group">--%> 
                    <%--<label for="senha">Senha:</label>--%>
                    <asp:TextBox ID="TxtSenha" CssClass="form-control" runat="server"  width="100%" Height="40px" TextMode="Password" placeholder="Senha"></asp:TextBox>
                </div>
                <div class="form-group text-right">
                    <div style="float:left"><asp:CheckBox ID="cbLembrar" Text="Lembre de mim" CssClass="text-left" runat="server"/></div>
                    <asp:LinkButton ID="btEsqueci" runat="server" Text="Esqueci minha senha"/>
                </div>
                <div class="form-group">
                    <asp:Button ID="Btlogin" CssClass="btn btn-primary" Text="Entrar" runat="server" width="100%" Height="40px" OnClick="Btlogin_Click"/>
                </div>
                <br/>
                <asp:Label id="Labelerro" CssClass="text-danger" runat="server"></asp:Label>
            </asp:Panel>
        </div>
</asp:Content>

