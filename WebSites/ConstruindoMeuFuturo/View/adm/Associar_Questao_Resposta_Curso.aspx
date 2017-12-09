<%@ Page Title="Associar resposta ao Curso" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Associar_Questao_Resposta_Curso.aspx.cs" Inherits="View_Associar_Questao_Resposta_Curso" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <!DOCTYPE html>
    <html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
            <title></title>
        </head>
    <body>
        <link href="../General/Design.css" rel="stylesheet" />
        <div class="well container" style="margin-top:2%; max-width:80%; background-color:white;">
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cursos</h1></asp:Label>
                <br/>
                <br/> 
                 <div class="text-right col-lg-12">
                        <asp:Button ID="BtVoltar" runat="server" CssClass="btn btn-primary" Text="Voltar" width="100px" OnClick="BtVoltar_Click"/>
                 </div>
                 <asp:Label ID="Label2" runat="server" Text=""><h2>Cursos Já associados:</h2></asp:Label>
                <asp:GridView ID="grdQuestaoRespostaCurso" runat="server" AutoGenerateColumns="false" OnRowCommand="grdQuestaoRespostaCurso_RowCommand"  width="100%">
                    <Columns>        
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnExcluir" CssClass="btn btn-primary" width="100%" runat="server" CommandName="Excluir" Text="Excluir Curso"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br/>
                <div class="form-group">
                    <asp:TextBox ID="Txtpesquisa"  CssClass="form-control"  width="100%"  Height="40px" runat="server" AutoPostBack="True" OnTextChanged="Txtpesquisa_TextChanged" placeholder="Pesquisar por nome"></asp:TextBox>
                </div>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDados_RowCommand"  width="100%">
                    <Columns>        
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnAdicionar" CssClass="btn btn-primary" width="100%" runat="server" CommandName="Adicionar" Text="Adicionar Curso"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id")%>' />
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



