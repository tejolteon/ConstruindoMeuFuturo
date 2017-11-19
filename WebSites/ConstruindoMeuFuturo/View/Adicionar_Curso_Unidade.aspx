<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Adicionar_Curso_Unidade.aspx.cs" Inherits="View_Lista_Unidade_de_Ensino" %>


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
                <asp:Label ID="Label1" runat="server" Text=""><h1>Adicionar Curso na unidade</h1></asp:Label>
                <div class="form-group">
                    <asp:TextBox ID="Txtpesquisa" runat="server" AutoPostBack="True" OnTextChanged="Txtpesquisa_TextChanged" placeholder="Pesquisar por nome"></asp:TextBox>
                </div>
                <br/>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDados_RowCommand">
                    <Columns>        
                        <asp:BoundField DataField="Nome_unidade" HeaderText="Nome" />
                        <asp:BoundField DataField="Site" HeaderText="Site" />
                        <asp:BoundField DataField="Endereco_unidade" HeaderText="Endereco" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnAdicionar" runat="server" CommandName="Adicionar" Text="Adicionar Curso nessa unidade"
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



