﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LayoutEvento.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Evento.LayoutEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="../../Content/css/Scrollbar.css" rel="stylesheet" />
    <link href="../../Content/css/bootstrap-glyphicons.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <style>

        /*ACORTAR TEXTO*/
        .ellipsis {
            overflow: hidden;
            height: 40px;
            line-height: 19px;
            margin: 0px;
            /*border: 5px solid #AAA;*/
        }

        .ellipsis:before {
            content: "";
            float: left;
            width: 5px;
            height: 80px;
        }

        .ellipsis > *:first-child {
            float: right;
            width: 100%;
            margin-left: -5px;
        }

        .ellipsis:after {
            content: "\02026";
            box-sizing: content-box;
            -webkit-box-sizing: content-box;
            -moz-box-sizing: content-box;
            float: right;
            position: relative;
            top: -25px;
            left: 100%;
            width: 3em;
            margin-left: -3em;
            padding-right: 5px;
            text-align: right;
            background-size: 100% 100%; /* 512x1 image,gradient for IE9. Transparent at 0% -> white at 50% -> white at 100%.*/
            /*background-image:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAgAAAAABCAMAAACfZeZEAAAABGdBTUEAALGPC/xhBQAAAwBQTFRF////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AAAA////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wDWRdwAAAP90Uk5TgsRjMZXhS30YrvDUP3Emow1YibnM9+ggOZxrBtpRRo94gxItwLOoX/vsHdA2yGgL8+TdKUK8VFufmHSGgAQWJNc9tk+rb5KMCA8aM0iwpWV6dwP9+fXuFerm3yMs0jDOysY8wr5FTldeoWKabgEJ8RATG+IeIdsn2NUqLjQ3OgBDumC3SbRMsVKsValZplydZpZpbJOQco2KdYeEe36BDAL8/vgHBfr2CvTyDu8R7esU6RcZ5ecc4+Af3iLcJSjZ1ivT0S/PMs3LNck4x8U7wz7Bv0G9RLtHuEq1TbJQr1OtVqqnWqRdoqBhnmSbZ5mXapRtcJGOc4t2eYiFfH9AS7qYlgAAARlJREFUKM9jqK9fEGS7VNrDI2+F/nyB1Z4Fa5UKN4TbbeLY7FW0Tatkp3jp7mj7vXzl+4yrDsYoVx+JYz7mXXNSp/a0RN25JMcLPP8umzRcTZW77tNyk63tdprzXdmO+2ZdD9MFe56Y9z3LUG96mcX02n/CW71JH6Qmf8px/cw77ZvVzB+BCj8D5vxhn/vXZh6D4uzf1rN+Cc347j79q/zUL25TPrJMfG/5LvuNZP8rixeZz/mf+vU+Vut+5NL5gPOeb/sd1dZbTs03hBuvmV5JuaRyMfk849nEM7qnEk6IHI8/qn049hB35QGHiv0yZXuMdkXtYC3ebrglcqvYxoj1muvC1nDlrzJYGbpcdHHIMo2FwYv+j3QAAOBSfkZYITwUAAAAAElFTkSuQmCC);*/
        }

        /*CONTENERDOR HIJO*/
        .contenedoreventos {
            margin: auto;
            width: 100%;
            text-align: center;
            padding: 0px;
            /*position: fixed;*/
        }

        /*#wrapper {
            position: relative;
            overflow: hidden;
        }

        #wrapper:before {
            content: '';
            position: absolute;
            background: #000;
            background: rgb(26,26,26);
            background: rgba(26,26,26, .85);
            border-right: 670px #313030 solid;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 100%;
            height: 100%;
            z-index: -1;
            top: 0;
            left: 0;
        }*/

        #contenedor {
            width: 100%;
            height: 100%;
            overflow-y: auto;
            position: fixed;
            overflow-x: hidden;
            /* top: 76px; */
            background: url(/../../Images/BackGround01.png);
            background-size: cover;
            z-index: 0;
        }

        #panel_evento {
            width: 100%;
            height: 100%;
            overflow-y: hidden;
            overflow-x: hidden;
        }

        #panel_evento2 {
            width: 100%;
            height: 100%;
            overflow-y: hidden;
            overflow-x: hidden;
        }
        .nopadding {
            padding: 0px;
        }

        .nomargin {
            margin: 0px;
        }

        .barimage {
            width: 100%;
            height: 100%;
            overflow-y: hidden;
            overflow-x: hidden;
            background: url('/Images/Ima01.png') no-repeat;
            background-size: cover;
        }

        .titulocontenedor {
            font-family: segoe UI Light;
            font-size: 30px;
            text-align: left;
            padding-top: 10px;
        }

        .titulocontenedor > u {
            text-decoration: none;
            border-bottom: 1px solid black;
        }

        ​
        .navbar-light .navbar-nav .nav-link {
            color: rgba(255, 255, 255, 0.5);
        }

        .bg-bcrp {
            background-color: #0A435E !important;
        }

        .navbar-light .navbar-nav .nav-link {
            color: rgba(255, 255, 255, 0.5);
        }

        .iconpngleft {
            margin-right:3px;
        }

        /*.table > tbody > tr > td,
        .table > tbody > tr > th,
        .table > tfoot > tr > td,
        .table > tfoot > tr > th,
        .table > thead > tr > td,
        .table > thead > tr > th {
            padding: 8px;
            line-height: 1.42857143;
            vertical-align: top;
            border-top: 0px solid #ddd;
        }

        .table {
	        table-layout:fixed;
        }*/
        .table td {
            width: 2%;
            height: 2%;
            text-align: justify;
            overflow: auto;
        }

        @media screen and (max-width: 767px) {
            #formulario {
                padding-top: 5%;
                padding-left: 0%;
            }

            .barimage {
                height: 0%;
            }
        }
    </style>
</head>
    <script type="text/javascript">
       
        $(document).ready(function() {

           //alert("evento load detectado!");
            $('#panel_evento').load('HomeEvento.aspx');
        

            $('ul.nav li a').click(function () {
                var page = $(this).attr('id');
               
                //alert(page);
                
                    //$('#panel_evento').load(page + '.aspx');
                

                $.get(page + '.aspx', function (data) {
                    alert(data);
                    $("#panel_evento").html(data);
                    
                    if (page == 'InscripcionEvento')
                    {
                         $('#panel-inscripcion').load('InformacionGeneralEvento.aspx');
                    }
            });
               
               
            });

           

             

        });

  
    </script>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-light bg-bcrp  ">
            <a class="navbar-brand" href="ListaEventos.aspx">
                <img src="/Images/Logo02.png" />
                <asp:Label ID="labDate" runat="server"></asp:Label>
            </a>

            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse justify-content-end" id="navbarSupportedContent">
                <ul class="nav navbar-nav">
                    <li class="nav-item">
                        <a href="#" id="opCambiarContrasen" runat="server" visible="false" class="nav-link">CAMBIAR CONTRASEÑA</a>
                    </li>
                    <li class="nav-item">
                        <a id="HomeEvento" runat="server" class="nav-link" href="#">INICIO</a>
                    </li>
                    <li class="nav-item">
                        <a id="InscripcionEvento" runat="server" class="nav-link" href="#">INSCRIPCIÓN</a>
                    </li>
                    <li class="nav-item">
                        <a id="opAgend" runat="server" class="nav-link" href="~/Views/Principal/agenda.aspx">AGENDA</a>
                    </li>
                </ul>
                <ul class="nav navbar-nav">
                    <li class="nav-item"><a id="opPresentacione" runat="server" href="~/Views/Principal/Presentaciones.aspx" class="nav-link">PRESENTACIONES</a></li>
                    <li class="nav-item"><a id="opExpositoresPart" runat="server" href="~/Views/Principal/ExpositoresParticipantes.aspx" class="nav-link">EXPOSITORES Y PARTICIPANTES</a></li>
                    <%--<li class="nav-item"><a id="opAp" runat="server" href="~/Views/Principal/app.aspx" class="nav-link">APP</a></li>
                    <li class="nav-item"><a id="opEvento" runat="server" href="~/Views/Principal/eventosParticipante.aspx" class="nav-link">EVENTOS</a></li>   --%>
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li class="nav-item"><a id="opCerrarSesio" runat="server" href="Login.aspx" class="nav-link"><span class="glyphicon glyphicon-user"></span>CERRAR SESIÓN</a></li>
                </ul>
            </div>
        </nav>
        <div class="container-fluid text-center nopadding" style="position: fixed; height: 100%;">
            <div id="panel_evento" class="row nopadding nomargin contentindex">
                <%--AQUI VA EL CONTENIDO--%>
                <%--<div class="col-sm-3 barimage contentindex" style="background: url('/Images/Ima01.png') no-repeat; background-size: cover;"></div>
                <div class="col-sm-9 contentindex" id="panel_evento2">
                    <div class="container contenedoreventos">
                        <div id="panelsecudario" class="panel-body scrollbar-black " runat="server">
                            <asp:ContentPlaceHolder ID="MainContent" runat="server" class="contentdisplay">
                            </asp:ContentPlaceHolder>
                        </div>
                    </div>
                </div>--%>
            </div>
        </div>
    </form>
</body>
</html>
