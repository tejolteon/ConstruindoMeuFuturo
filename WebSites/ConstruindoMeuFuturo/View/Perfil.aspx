<%@ Page Title="Meu Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Perfil.aspx.cs" Inherits="View_Perfil" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <br/>
    <div class="col-lg-12">
        <div class="container-fluid well-sm col-lg-2 col-sm-5 col-xs-12" style="margin-top:2%; background-color: white;"> 
            <asp:Panel ID="pnInfo" runat="server">
                <h1>Meu Perfil</h1>
                <div class="col-lg-12">
                    <asp:Image ID="imgPerfil" runat="server" Height="200" Width="150"/>
                </div>
                <div class="col-lg-12">
                    <br />
                    <asp:Label ID="lbNome" runat="server" Text="Nome"></asp:Label>
                    <br />
                    <asp:Label ID="lbCidade" runat="server" Text="São Paulo"></asp:Label>
                    <br />
                    <asp:LinkButton ID="lbtAlterarPerfil" runat="server" OnClick="lbtAlterarPerfil_Click">Alterar Informações</asp:LinkButton>
                    <br />
                    <asp:LinkButton ID="lbtAlterarSenha" runat="server" OnClick="lbtAlterarSenha_Click" >Alterar Senha</asp:LinkButton>
                    <br />
                </div>
            </asp:Panel>
        </div>
            <div class="col-lg-1 col-sm-1"></div>
        <div class="container well-lg col-lg-9 col-sm-6 col-xs-12" style="">
            <asp:Panel ID="pnPerfil" runat="server" class="row">
                <asp:Label ID="LabelTop" runat="server" Text="<h1>Sugestões de Cursos</h1>"></asp:Label>
                 <br/>
                <div class="col-lg-10"\>
                 <button ID="BtQuestionario" Class="btn btn-primary" Text="Responder Questionario Para melhorar a precisão" runat="server" style="height:40px;width:100%;" onclick="BtQuestionario_Click()" visible="false">
                 Responder Questionario Para melhorar a precisão</button>
                        <script>
                            function BtQuestionario_Click() {
                                window.open("Responder_Questionario.aspx", "_blank", "toolbar=yes,scrollbars=yes,resizable=yes,top=200,left=500,width=400,height=400");
                            }
                        </script>
                   <!-- Literal que recebe cursos ou tela administrativa -->
                 <br/>
                 </div>
               
                <br/>
                <asp:Literal ID="ltPainel" runat="server"></asp:Literal>      
             </asp:Panel>
        </div>
        </div>
        
</asp:Content>
