<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Alterar_Unidade_de_Ensino.aspx.cs" Inherits="View_Alterar_Unidade_de_Ensino" %>


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
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cadastro Unidade de Ensino</h1></asp:Label>
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
                <textarea id="Txtdescricao" cols="20" name="S1" rows="6" runat="server"></textarea><div class="form-group">
                    <div class="text-right col-lg-6">
                        <asp:Button ID="Btalterar" CssClass="btn btn-primary" Text="Salvar" runat="server" width="100px" OnClick="Btcadastrar_Click" />
                    </div>
                </div>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </body>
    </html>
</asp:Content>



