<%@ Page Title="Meu Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Perfil.aspx.cs" Inherits="View_Perfil" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <!DOCTYPE html>
   
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
                    <asp:LinkButton ID="LbtAlterarPerfil" runat="server" OnClick="LbtAlterarPerfil_Click">Alterar Informações</asp:LinkButton>
                    <br />
                    <asp:LinkButton ID="LbtAlterarSenha" runat="server" OnClick="LbtAlterarSenha_Click" >Alterar Senha</asp:LinkButton>
                    <br />
                </div>
            </asp:Panel>
        </div>      
        <div class="container well col-lg-8 col-sm-6 col-xs-12" style="margin-top:2%;">
            <!-- !!!!!! A TABELA NÃO ESTÁ RESPONSIVA !!!!!! PENDENTE SOLUÇÃO -->
            <asp:Panel ID="pnPerfil" runat="server">
             
                   <h1>Sugestões de Cursos</h1>
                   <asp:Literal ID="ltPainel" runat="server"></asp:Literal>      
             </asp:Panel>
        </div>
        </div>
 
</asp:Content>
