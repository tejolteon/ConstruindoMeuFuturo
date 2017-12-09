<%@ Page  Title="Home Administrador" Language="C#" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Home_adm.aspx.cs" Inherits="View_adm_Home_adm" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
     <link href="../../bootstrap/css/bootstrap.css" rel="stylesheet" />
        <link href="../../General/Design.css" rel="stylesheet" />
        <link rel="icon" href="../../Images/Logo.png" />
        <script src="../../bootstrap/js/jquery.min.js"></script>

    <div class="container-fluid">
      
            <nav class="container well-sm col-lg-2 col-sm-5 col-xs-12">
              <ul class="nav nav-pills flex-column">
                <li class="nav-item ">
                  <a class="nav-link" href="Lista_Unidade_de_Ensino.aspx"><h4>Gerenciar as unidades de Ensino</h4></a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="Lista_Questao.aspx"><h4>Gerenciar o questioanrio</h4></a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="Lista_Curso.aspx"><h4>Gerenciar cursos</h4></a>
                </li>
              </ul>
            </nav>
             <div class="container well-lg col-lg-10 col-xs-12" align="center">
                <main class="col-sm-9 offset-sm-3 col-md-10 offset-md-2 pt-3" >
                  <h1>Dashboard
                 </h1>
                </main>
                 <div class="col-lg-12">
                 Ano:<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged" maxlength="4"></asp:TextBox>
                 </div>
                <div class="col-lg-6">
                    <asp:Chart ID="ChartUsuarios" runat="server" Width="472px" Height="359px" AntiAliasing="None" BackColor="Transparent">
                        <Series>
                            <asp:Series Name="Series1"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartUsuarios"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </div>
                <div class="col-lg-6">
                    <asp:Chart ID="Chart1" runat="server" Width="467px" Height="359px" AntiAliasing="None" BackColor="Transparent">
                        <Series>
                            <asp:Series Name="Series1" ChartType="Spline"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartUsuarios"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </div>
            
          </div>
    </div>
       
</asp:Content>
