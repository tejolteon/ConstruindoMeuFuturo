<%@ Page Title="Lista das Unidades" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Lista_Unidade_de_Ensino.aspx.cs" Inherits="View_Lista_Unidade_de_Ensino" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
   
        <link href="../../bootstrap/css/bootstrap.css" rel="stylesheet" />
        <link href="../../General/Design.css" rel="stylesheet" />
        <link rel="icon" href="../../Images/Logo.png" />
        <script src="../../bootstrap/js/jquery.min.js"></script>

        <div class="well container" style="margin-top:2%; max-width:80%; background-color:white;">
            <asp:Panel ID="PanelCadastroUnidade" runat="server" Visible ="false">
                <asp:Label ID="Label2" runat="server" Text=""><h1>Cadastro Unidade de Ensino</h1></asp:Label>
                <br/>
                <div class="form-group">

                    <label for="nomeo">Nome da unidade</label>
                    <asp:TextBox ID="Txtnome" CssClass="form-control" runat="server"></asp:TextBox>

                    <label for="site">Site</label>
                    <asp:TextBox ID="TxtSite" CssClass="form-control" runat="server"></asp:TextBox>

                    <label for="endereco">Endereço</label>
                    <asp:TextBox ID="Txtendereco" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <!-- Lista de estado que está fixa-->
                 <div class="form-group">
                    <label for="estado">Estado</label>
                    <asp:DropDownList ID="DDLestado" runat="server" CssClass="form-control" OnSelectedIndexChanged="DDLestado_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Text="Selecione um estado" Value="0"/>
                        <asp:ListItem Text="São Paulo" Value="26"/>
                        
                    </asp:DropDownList>
                </div>
                <br/>
                <!-- Lista das cidades do estado-->
                <div class="form-group">
                    <label for="cidade">Cidade</label>
                    <asp:DropDownList ID="DDLcidade" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Selecione Uma cidade" Value="0"/>
                    </asp:DropDownList>
                </div>
                <br/>
                 
                
                <!-- Lista da area de interesse -->
                <div class="form-group">
                    <label for="descricao">Descrição</label>
                </div>
                <br/>
                <textarea id="Txtdescricao" cols="20" name="S1" rows="2" runat="server" style="width:100%;"></textarea><div class="form-group">
                    <div class="text-right col-lg-6">
                        <asp:Button ID="BtCadastrar" CssClass="btn btn-primary" Text="Salvar" runat="server" width="100px" OnClick="Btcadastrar_Click" />
                    </div>
                </div>
                <br/>
                <asp:Label id="Label3" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""><h1>Unidade de ensino</h1></asp:Label>
                <div class="text-center col-lg-12" style="margin-bottom:30px;margin-top:30px">
                    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar uma unidade nova" CssClass="btn btn-primary"  OnClick="btnCadastrar_Click"  />
                </div>

                <asp:Label id="Labelerro" runat="server"></asp:Label>
                <div class="form-group">
                    <asp:TextBox ID="Txtpesquisa"  CssClass="form-control"  width="100%"  Height="40px" runat="server" AutoPostBack="True" OnTextChanged="Txtpesquisa_TextChanged" placeholder="Pesquisar por nome"></asp:TextBox>
                </div>
                <br/>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="false" OnRowCommand="grdDados_RowCommand"  width="100%">
                    <Columns>        
                        <asp:BoundField DataField="Nome_unidade" HeaderText="Nome" />
                        <asp:BoundField DataField="Site" HeaderText="Site" />
                        <asp:BoundField DataField="Endereco_unidade" HeaderText="Endereco" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEditar"  CssClass="btn btn-primary" width="100%" runat="server" CommandName="Editar" Text="Editar Dados"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_unidade")%>' />
                           
                                <asp:Button ID="btnAdicionar" CssClass="btn btn-primary" width="100%" runat="server" CommandName="Adicionar" Text="Adicionar Curso"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id_unidade")%>' />

                           </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br/>
                
            </asp:Panel>

            
        </div>
</asp:Content>



