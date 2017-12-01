<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Alterar_Perfil.aspx.cs" Inherits="View_Alterar_Perfil" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <br/>
    <link href="../General/Design.css" rel="stylesheet" />    
    <div class="well container" style="margin-top:2%; max-width:60%; background-color:white;">
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""><h1>Seu Perfil</h1></asp:Label>
                <h4>Para conseguirmos te ajudar a escolher a melhor maneira de se aprimorar preencha os dados abaixo</h4>
                <br/>
                <div class="form-group">

                    <label for="datanascimento">Data de Nascimento:</label>
                    <asp:TextBox ID="Txtdatanascimento" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <br/>
                <div class="form-group">
                    <label for="escolaridade">Escolaridade</label>
                    <asp:DropDownList ID="DDLescolaridade" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Ensino Fundamental Incompleto" Value="Ensino Fundamental Incompleto"/>
                        <asp:ListItem Text="Ensino Fundamental Completo" Value="Ensino Fundamental Completo"/>
                        <asp:ListItem Text="Ensino Médio Incompleto" Value="Ensino Médio Incompleto"/>
                        <asp:ListItem Text="Ensino Médio Completo" Value="Ensino Médio Completo"/>
                        <asp:ListItem Text="Ensino Superior Incompleto" Value="Ensino Superior Incompleto"/>
                        <asp:ListItem Text="Ensino Superior Completo" Value="Ensino Superior Completo"/>
                    </asp:DropDownList>
                </div>
                <br/>
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
                <div class="form-group">
                 <label for="Area">Selecione as matérias que você mais gostava</label>
                    <asp:CheckBoxList ID="CheckListArea" runat="server">
                    </asp:CheckBoxList>
                </div>
                <br/>
                <div class="form-group">
                    <div class="text-left col-lg-6">
                        <asp:LinkButton ID="lbtMTarde" runat="server" CssClass="text-left" OnClick="lbtMTarde_Click">Mais Tarde</asp:LinkButton>
                    </div>
                    <div class="text-right col-lg-6">
                        <asp:Button ID="Btalterar" CssClass="btn btn-primary" Text="Salvar" runat="server" width="100px" OnClick="Btalterar_Click" />
                    </div>
                    </div>
                     <!-- <div class="text-right col-lg-6">
                       <button ID="BtQuestionario" CssClass="btn btn-primary" runat="server" width="100px" onclick="BtQuestionario_Click()"> Responder Questionario</button>
                        <script>
                            function BtQuestionario_Click() {
                                window.open("Responder_Questionario.aspx", "_blank", "toolbar=yes,scrollbars=yes,resizable=yes,top=200,left=500,width=400,height=400");
                            }
                        </script>
                    </div>
                </div> -->
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
</asp:Content>



