<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Lista_Unidade_de_Ensino.aspx.cs" Inherits="View_Lista_Unidade_de_Ensino" %>


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
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cadastro Unidade de Ensino</h1></asp:Label>
                <br/>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDados_RowCommand">
                    <Columns>        
                        <asp:BoundField DataField="Nome_unidade" HeaderText="Nome" />
                        <asp:BoundField DataField="Site" HeaderText="Site" />
                        <asp:BoundField DataField="Endereco_unidade" HeaderText="Endereco" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEditar" runat="server" CommandName="Editar" Text="Editar Dados"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_unidade")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </body>
    </html>
</asp:Content>



