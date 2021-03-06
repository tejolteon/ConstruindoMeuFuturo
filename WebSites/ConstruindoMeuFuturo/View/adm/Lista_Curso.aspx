﻿<%@ Page Title="Gerenciador de Cursos" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Lista_Curso.aspx.cs" Inherits="View_Lista_Curso" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
   
        <link href="../../bootstrap/css/bootstrap.css" rel="stylesheet" />
        <link href="../../General/Design.css" rel="stylesheet" />
        <link rel="icon" href="../../Images/Logo.png" />
        <script src="../../bootstrap/js/jquery.min.js"></script>

        <div class="well container" style="margin-top:2%; max-width:60%; background-color:white; min-height:100%;">
               <asp:Label ID="Label2" runat="server" Text="" style="text-align:center"><h1>Gerenciador de Cursos</h1></asp:Label>
            <asp:Panel ID="PanelCadastro" runat="server" Visible="False">
               
                <br/>
                <div class="form-group">

                    <label for="nomeo">Nome</label>
                    <asp:TextBox ID="Txtnomecurso" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
              
                <div class="form-group">
                    <label for="tipo">Tipo de Curso</label>
                    <asp:DropDownList ID="DDLcidade" runat="server" CssClass="form-control">
                       
                        <asp:ListItem Text="Graduação" Value="graduação"/>
                    </asp:DropDownList>
                </div>
                 <!--<asp:ListItem Text="Profissionalizante" Value="profissionalizante"/>
                        <asp:ListItem Text="Técnico" Value="téncino"/>
                        <asp:ListItem Text="Pós-Graduação" Value="Pós-graduação"/>-->
                <br/>
                 
                <!-- Lista da area de interesse -->
                <div class="form-group">
                    <label for="descricao">Descrição</label>
                </div>
                <br/>
                <textarea id="Txtdescricao" cols="20" name="S1" rows="2" runat="server" style="width:100%;"></textarea><div class="form-group">
                    <div class="text-right col-lg-12">
                        <asp:Button ID="BtCadastrar" CssClass="btn btn-primary" Text="Salvar" runat="server" width="100px" OnClick="Btcadastrar_Click" />
                    </div>
                </div>
                <br/>
                <asp:Label id="Label3" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel1" runat="server">
                <div class="text-center col-lg-12" style="margin-bottom:30px;margin-top:30px">
                    <asp:Button ID="btnPainelCadastrar" runat="server" Text="Cadastrar um novo curso" CssClass="btn btn-primary"  OnClick="btnCadastrar_Click"  />
                </div>
                 <div class="text-right col-lg-12">
                    <asp:Button ID="BtCadastrar0" runat="server" CssClass="btn btn-primary" Text="Voltar" width="100px" OnClick="BtCadastrar0_Click" />
                 </div>
                <div class="form-group">
                    <asp:TextBox ID="Txtpesquisa"  CssClass="form-control"  width="100%"  Height="40px" runat="server" AutoPostBack="True" OnTextChanged="Txtpesquisa_TextChanged" placeholder="Pesquisar por nome"></asp:TextBox>
                </div>
                <asp:GridView ID="grdDados" runat="server" AutoGenerateColumns="False" OnRowCommand="grdDados_RowCommand"  width="100%" BorderWidth="0px">
                    <Columns>        
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEditar" CssClass="btn btn-primary" width="100%" runat="server" CommandName="Editar" Text="Editar Dados"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
                
            </asp:Panel>

           
        </div>
</asp:Content>



