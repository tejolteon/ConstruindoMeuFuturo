<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Adicionar_Excluir_Curso_Unidade.aspx.cs" Inherits="View_Adicionar_Excluir_Curso" %>


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
               
                <asp:Label ID="Label3" runat="server" Text=""><h4>Cursos já cadastrados</h4></asp:Label>
                <asp:GridView ID="grdCursosUnidade" runat="server" AutoGenerateColumns="false" OnRowCommand="grdCursosUnidade_RowCommand">
                    <Columns>        
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnExcluir" runat="server" CommandName="Excluir" Text="Excluir o curso"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id")%>' />   
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br/>
                 <div class="form-group">
                    <asp:TextBox ID="Txtpesquisa" CssClass="form-control"  width="100%"  Height="40px" runat="server" AutoPostBack="True" OnTextChanged="Txtpesquisa_TextChanged" placeholder="Pesquisar por nome"></asp:TextBox>
                </div>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                <br/>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDados_RowCommand">
                    <Columns>        
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnAdicionar" runat="server" CommandName="Adicionar" Text="Adicionar o curso"
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



