<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Adicionar_Resposta_Questao.aspx.cs" Inherits="View_Adicionar_Resposta_Questao" %>


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
            <br/>
                <asp:Label id="LabelQuestao" runat="server"></asp:Label>
                <br/>
            <asp:Panel ID="pnCadastro" runat="server" Visible ="false">
                <asp:Label ID="Label2" runat="server" Text=""><h3>Cadastro de resposta</h3></asp:Label>
                <br/>
                <div class="form-group">
                    <label for="textoresposta">Texto:</label>
                    <br/>
                    <textarea id="txtTextoresposta" CssClass="form-control"  style="width:100%;" maxlength="255" name="S1" rows="3" runat="server"  ></textarea>
                </div>
                <div class="form-group text-right">
                    <asp:Button ID="Btcadastrar" CssClass="btn btn-primary" Text="Adicionar" runat="server" OnClick="Btcadastras_Click"/>
                </div>
            </asp:Panel>

            <asp:Panel ID="Panel1" runat="server">
                 <div class="text-center col-lg-12" style="margin-bottom:30px;margin-top:30px">
                     <asp:Button ID="btnPainelCadastrar" runat="server" Text="Cadastrar uma nova resposta" CssClass="btn btn-primary"  OnClick="btnCadastrar_Click"/>
                </div>
                <asp:Label runat="server" Text=""><h3>Respostas já adicionadas na questao:</h3></asp:Label>
                 <br/>
                <asp:GridView ID="grdRespostaQuestao" runat="server" AutoGenerateColumns="false" OnRowCommand="grdRespostaQuestao_RowCommand"  width="100%">
                    <Columns>
                        <asp:BoundField DataField="Id_Resposta" HeaderText="Id" />
                        <asp:BoundField DataField="Texto_Resposta" HeaderText="Texto" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnExcluir" CssClass="btn btn-primary" width="100%" runat="server" CommandName="Excluir" Text="Excluir essa resposta da questao"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_Resposta")%>' />
                                 <asp:Button ID="btnAssociar" CssClass="btn btn-primary" width="100%" runat="server" CommandName="Associar" Text="Associar um curso"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_Resposta")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br/>
                <asp:Label runat="server" Text=""><h3>Respostas formuladas que já existem</h3></asp:Label>
                <div class="form-group">
                    <asp:TextBox ID="Txtpesquisa" CssClass="form-control"  width="100%"  Height="40px" runat="server" AutoPostBack="True" OnTextChanged="Txtpesquisa_TextChanged" placeholder="Pesquisar por nome"></asp:TextBox>
                </div>
                <br/>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDados_RowCommand"  width="100%">
                    <Columns>
                        <asp:BoundField DataField="Id_Resposta" HeaderText="Id" />
                        <asp:BoundField DataField="Texto_Resposta" HeaderText="Texto" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnAdicionar" runat="server" CommandName="Adicionar" Text="Adicionar essa resposta na questao"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_Resposta")%>' />
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



