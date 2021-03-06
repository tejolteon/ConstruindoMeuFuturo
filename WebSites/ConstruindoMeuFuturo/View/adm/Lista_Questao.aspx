﻿<%@ Page Title="Lista de todas as questões" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Lista_Questao.aspx.cs" Inherits="View_Lista_Questao" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
 
        <link href="../../bootstrap/css/bootstrap.css" rel="stylesheet" />
        <link href="../../General/Design.css" rel="stylesheet" />
        <link rel="icon" href="../../Images/Logo.png" />
        <script src="../../bootstrap/js/jquery.min.js"></script>

        <div class="well container" style="margin-top:2%; max-width:60%; background-color:white;">
            <asp:Label ID="Label2" runat="server" Text="" style="text-align:center"><h1>Gerenciador de Questionario</h1></asp:Label>
            <asp:Panel ID="pnCadastroQuestao" runat="server" Visible ="False">
                <br/>
                <div class="form-group">
                    <label for="textoquestao">Texto:</label>
                    <br/>
                    <textarea id="txtTextoquestao" name="S1" rows="3" runat="server" style="width:100%;"></textarea>
                </div>
                <div class="form-group text-right">
                    <asp:Button ID="Btcadastrar" CssClass="btn btn-primary" Text="Adicionar" runat="server" Width="100px" OnClick="Btcadastras_Click"/>
                </div>
                <br/>
                <asp:Label id="Label3" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="PanelLista" runat="server">
                <div class="text-center col-lg-12" style="margin-bottom:30px;margin-top:30px">
                     <asp:Button ID="btnPainelCadastrar" runat="server" Text="Cadastrar uma nova questão" CssClass="btn btn-primary"  OnClick="btnCadastrar_Click"/>
                </div>
                   <div class="text-right col-lg-12">
                        <asp:Button ID="BtVoltar" runat="server" CssClass="btn btn-primary" Text="Voltar" width="100px" OnClick="BtVoltar_Click"/>
                 </div>
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
</asp:Content>



