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
        <div class="well container" style="margin-top:2%; max-width:60%; background-color:white;">
            <asp:Panel ID="pnCadastroQuestao" runat="server" Visible ="False">
                <asp:Label ID="Label2" runat="server" Text=""><h1>Cadastro de questões</h1></asp:Label>
                <br/>
                <div class="form-group">
                    <label for="textoquestao">Texto:</label>
                    <br/>
                    <textarea id="txtTextoquestao" name="S1" rows="3" runat="server" style="width:100%;"></textarea>
                </div>
                <div class="form-group text-right">
                    <asp:Button ID="Btcadastrar" CssClass="btn btn-primary" Text="Cadastrar" runat="server" Width="100px" OnClick="Btcadastras_Click"/>
                </div>
                <br/>
                <asp:Label id="Label3" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="PanelLista" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""><h1>Questões</h1></asp:Label>
                <br/>
                <asp:Button ID="btnPainelCadastrar" runat="server" Text="Cadastrar uma questão nova" CssClass="btn btn-primary"  OnClick="btnCadastrar_Click"  />
                <br />
                 <div class="form-group">
                    <asp:TextBox ID="Txtpesquisa"  CssClass="form-control"  width="100%"  Height="40px" runat="server" AutoPostBack="True" OnTextChanged="Txtpesquisa_TextChanged" placeholder="Pesquisar por nome"></asp:TextBox>
                </div>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDados_RowCommand"  width="100%">
                    <Columns>      
                        <asp:BoundField DataField="Id_Questao" HeaderText="Número" />
                        <asp:BoundField DataField="Texto_Questao" HeaderText="Texto" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEditar" CssClass="btn btn-primary" width="100%" runat="server" CommandName="Editar" Text="Editar Pergunta"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_Questao")%>' />
                                 <asp:Button ID="btnAdicionar" CssClass="btn btn-primary" width="100%" runat="server" CommandName="Adicionar" Text="Adicionar Resposta"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_Questao")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel> 
        </div>
         <%-- Rodapé --%>
        <div> </div>
        <div class ="navbar-inverse" style="position:absolute; width:100%; min-height:50px; color:floralwhite; font-size:16px;">
            <div style="font-size:10px;"> </div>
	        <div style="margin-left:2%;">Copyright 2017 Construindo meu Futuro</div>
        </div>
    </body>
    </html>
</asp:Content>



