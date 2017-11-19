<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Adicionar_Alterar_Curso_Unidade.aspx.cs" Inherits="View_Alterar_Curso" %>


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
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cadastro de um novo Curso</h1></asp:Label>
                <br/>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDados_RowCommand">
                    <Columns>        
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEditar" runat="server" CommandName="Adicionar" Text="Adicionar esse curso"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </div>
    </body>
    </html>
</asp:Content>



