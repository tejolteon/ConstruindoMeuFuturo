<%@ Page Title="Lista de todas as questões" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Lista_Questao.aspx.cs" Inherits="View_Lista_Questao" %>


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
                <asp:Label ID="Label1" runat="server" Text=""><h1>Questões</h1></asp:Label>
                <br/>
                 <div class="form-group">
                    <asp:TextBox ID="Txtpesquisa" runat="server" AutoPostBack="True" OnTextChanged="Txtpesquisa_TextChanged" placeholder="Pesquisar por nome"></asp:TextBox>
                </div>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDados_RowCommand">
                    <Columns>      
                        <asp:BoundField DataField="Id_Questao" HeaderText="Número" />
                        <asp:BoundField DataField="Texto_Questao" HeaderText="Texto" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEditar" runat="server" CommandName="Editar" Text="Editar Dados"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_Questao")%>' />
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



