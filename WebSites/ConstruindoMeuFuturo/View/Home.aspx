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
                    <div class="overlay">
                        <img src="../Images/Banner1.jpg" class="overlay" alt="Livros" style="width:100%;"/>
                    </div>
                    <div class="carousel-caption banner-center-text">
                        <h2>A plataforma "Construindo meu Futuro" irá te auxiliar a ingressar no Ensino Superior rapidamente!</h2>
                    </div>
                </div>
                <div class="item">
                    <div class="overlay">
                        <img src="../Images/Banner2.jpg" class="overlay" alt="Livros2" style="width:100%;"/>
                    </div>
                    <div class="carousel-caption banner-center-text">
                        <h2>Nossa maior missão é traçar rotas para que VOCÊ encontre o seu curso ideal!</h2>
                    </div>
                </div>

                <div class="item">
                    <div class="overlay">
                        <img src="../Images/Banner3.jpg" class="overlay" alt="Livros3" style="width:100%;"/>
                    </div>
                    <div class="carousel-caption banner-center-text">
                        <h2>Junte-se agora e descubra as melhores possibilidades de cursos!</h2>
                    </div>
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

        <asp:Panel ID="pnPassos" runat="server">
            <div class="box">
                <div class ="container-fluid col-lg-4 col-sm-4 col-xs-12 box">
                    <div class="col-lg-12 table-bordered well t" style="min-height:172px;">
                        <img class="img-passo1" src="../Images/Passo1.png" />
                        <h3>1. Faça a sua inscrição.</h3>
                        <p>Cadastre-se com o seu e-mail e responda algumas perguntas relacionadas ao seu perfil para exibirmos opções de cursos para você.</p>
                    </div>
                </div>
                <div class ="container-fluid col-lg-4 col-sm-4 col-xs-12 box">
                    <div class="col-lg-12 table-bordered well t" style="min-height:172px;">
                        <img class="img-passo2" src="../Images/Passo2.png" />
                        <h3>2. Cursos ideais para você!</h3>
                        <p>Após efetuar o seu cadastro você receberá informações exclusivas de cursos superiores de acordo com o seu perfil.</p>
                    </div>
                </div>
                <div class ="container-fluid col-lg-4 col-sm-4 col-xs-12 box">
                    <div class="col-lg-12 table-bordered well t" style="min-height:172px;">
                        <img class="img-passo3" src="../Images/Passo3.png" />
                        <h3>3. Como chegar lá!</h3>
                        <p>Após cumprir as duas primeiras etapaso nosso sistema lhe dará todas as informações necessárias para você conseguir iniciar seu curso superior!</p>
                    </div>
                </div>
            </div>
            <div class="text-center">
                <asp:Button id="btnQCadastro" runat="server" Text="Quero Me Cadastrar" CssClass="btn btn-default button-cad" OnClick="btnQCadastro_Click"/>
            </div>
        </asp:Panel>
        <div class="box">
            <div class ="container-fluid col-lg-4 col-sm-4 col-xs-12 box">    
                <a href="#">
                    <img src="../Images/Noticia1.jpg" class="overlay noticia"/>
                    <p class="carousel-caption font-noticia">Saiba como se preparar para o vestibular</p>
                </a>
            </div>
            <div class ="container-fluid col-lg-4 col-sm-4 col-xs-12 box">
                <a href="#">
                    <img src="../Images/Noticia2.jpg" class="overlay noticia" />
                    <p class="carousel-caption font-noticia">Aberta as inscrições para o FUVEST 2017</p>
                </a>
            </div>
            <div class ="container-fluid col-lg-4 col-sm-4 col-xs-12 box">
                <a href="Noticia.aspx">
                    <img src="../Images/Noticia3.jpg" class="overlay noticia"/>
                    <p class="carousel-caption font-noticia">5 possíveis temas para a redação do ENEM 2017</p>
                </a>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
