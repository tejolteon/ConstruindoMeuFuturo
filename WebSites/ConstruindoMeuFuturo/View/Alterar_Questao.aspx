<%@ Page Language="C#" Title ="Cadastro" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Alterar_Questao.aspx.cs" Inherits="View_Cadastro_Questao"%>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <!DOCTYPE html>

        <link href="../General/Design.css" rel="stylesheet" />
        <div class="well container" style="margin-top:2%; max-width:80%; background-color:white;">
            <asp:Panel ID="pnCadstro" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cadastro de questões</h1></asp:Label>
                <br/>
                <div class="form-group">
                    <label for="textoquestao">Texto:</label>
                    <br/>
                    <textarea id="txtTextoquestao" CssClass="form-control"  style="width:100%;" name="S1" rows="3" runat="server" ></textarea>
                </div>
                <div class="form-group text-right">
                    <asp:Button ID="Btalterar" CssClass="btn btn-primary" Text="Cadastrar" runat="server" Width="100px" OnClick="Btalterar_Click"/>
                </div>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>      
     <%-- Rodapé --%>
        <div> </div>
        <div class ="navbar-inverse" style="position:absolute; width:100%; min-height:50px; color:floralwhite; bottom:0; font-size:16px;">
            <div style="font-size:10px;"> </div>
	        <div style="margin-left:2%;">Copyright 2017 Construindo meu Futuro</div>
        </div>

</asp:Content>
