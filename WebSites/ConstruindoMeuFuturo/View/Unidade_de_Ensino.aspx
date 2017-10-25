<%@ Page Title="" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Unidade_de_Ensino.aspx.cs" Inherits="View_Unidade_de_Ensino" %>


<asp:Content ContentPlaceHolderID="Content" runat="server">
    <!DOCTYPE html>
    <html>
    <head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <link href="../General/Design.css" rel="stylesheet" />
        <div class="well container" style="margin-top:2%; max-width:80%;">
            <asp:Panel ID="pnCadstro" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cadastro de Usuario</h1></asp:Label>
                <br/>
                <asp:Repeater ID="RepeaterCursos" runat="server">
                    <ItemTemplate>

                    </ItemTemplate>
                </asp:Repeater>
                
                
                
                
                <div class="form-group text-right">
                    <asp:Button ID="Btcadastras" CssClass="btn btn-primary" Text="Cadastrar" runat="server" Width="100px" OnClick="Btcadastras_Click"/>
                </div>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>      
    </body>
    </html>
</asp:Content>
