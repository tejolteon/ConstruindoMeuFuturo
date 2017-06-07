<%@ Page Language="C#" Title ="Home" MasterPageFile="~/General/Site.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="View_Home"%>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <!DOCTYPE html>

    <html>
    <head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <link href="../General/Design.css" rel="stylesheet" />
        <div id="myCarousel" class="carousel slide box-nav" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item active img-banner">
                    <img src="../Images/livros.jpg" alt="Livros"/>
                </div>

                <div class="item">
                    <img src="../Images/livros2.jpg" alt="Livros2"/>
                </div>

                <div class="item">
                    <img src="../Images/livros3.jpg" alt="Livros3"/>
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>

        <div class="box">
            <div class ="container-fluid col-lg-4 col-sm-4 col-xs-12 box">
                <div class="col-lg-12 table-bordered text-center">Aqui vai o texto</div>
            </div>
            <div class ="container-fluid col-lg-4 col-sm-4 col-xs-12 box">
                <div class="col-lg-12 table-bordered text-center">Aqui vai o texto</div>
            </div>
            <div class ="container-fluid col-lg-4 col-sm-4 col-xs-12 box">
                <div class="col-lg-12 table-bordered text-center">Aqui vai o texto</div>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
