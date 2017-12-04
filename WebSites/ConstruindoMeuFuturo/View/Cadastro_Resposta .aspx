<%@ Page Language="C#" Title ="Cadastro de resposta" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Cadastro_Resposta .aspx.cs" Inherits="View_Cadastro_Resposta"%>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <!DOCTYPE html>

        <link href="../General/Design.css" rel="stylesheet" />
        <div class="well container" style="margin-top:2%; max-width:80%;">
            <asp:Panel ID="pnCadstro" runat="server">
                <asp:Label ID="Label1" runat="server" Text=""><h1>Cadastro de questões</h1></asp:Label>
                <br/>
                <div class="form-group">
                    <label for="textoresposta">Texto:</label>
                    <br/>
                    <textarea id="txtTextoresposta" name="S1" rows="3" runat="server" ></textarea>
                </div>
                <div class="form-group text-right">
                    <asp:Button ID="Btcadastrar" CssClass="btn btn-primary" Text="Cadastrar" runat="server" Width="100px" OnClick="Btcadastras_Click"/>
                </div>
                <br/>
                <asp:Label id="Labelerro" runat="server"></asp:Label>
            </asp:Panel>
        </div>      

</asp:Content>
