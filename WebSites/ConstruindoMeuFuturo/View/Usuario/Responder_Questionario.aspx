﻿<%@ Page Language="C#" Title ="Questionário" AutoEventWireup="true" CodeFile="Responder_Questionario.aspx.cs" Inherits="View_Cadastro_Resposta"%>


<!DOCTYPE html>

<html>
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>

        <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script src="../bootstrap/js/bootstrap.min.js"></script> --%>

        <link href="../../bootstrap/css/bootstrap.css" rel="stylesheet" />
        <link href="../../General/Design.css" rel="stylesheet" />
        <link rel="icon" href="../../Images/Logo.png" />
        <script src="../../bootstrap/js/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

</head>

<body>
    
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
         </asp:ScriptManager>
         <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                     <ProgressTemplate>
                         <div style="width:100%;height:100%;position:absolute;text-align:center;background-color:white">   
                             
                        <img src="../../Images/LOADING.gif" width="150px" height="150px" alt="Carregando" id="imgpos" style="position:relative; top:45%;" title="Carregando..."/>
                        </div>
                    </ProgressTemplate>
         </asp:UpdateProgress>
        <div class="well container" style="margin-top:2%; max-width:80%; background-color:white;">
            <asp:Panel ID="pnQuestionario" runat="server" name="pnQuestionario">
               

                <asp:Label id="Labelerro" runat="server"></asp:Label>

                 <asp:Label id="questaotexto" runat="server" ></asp:Label>
                <asp:RadioButtonList ID="radiolist" runat="server">
                </asp:RadioButtonList>
           </asp:Panel>
             <asp:UpdatePanel runat="server" id="Panel">
                <ContentTemplate>
                    <asp:Button ID="btProximo" CssClass="btn btn-primary" width="100%" runat="server" Text="Próximo" OnClick="btProximo_Click"/>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>      

 </form>
</body>
</html>

