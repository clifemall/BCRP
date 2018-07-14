<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login1.aspx.cs" Inherits="EventosBCRPFrontEnd.login1" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <title>Bootstrap Example</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="Content/css/Scrollbar.css" rel="stylesheet" />
    <link href="Content/css/bootstrap-glyphicons.css" rel="stylesheet" />
    <script src="/Scripts/jquery-3.3.1.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>

    <style>
        /*html body {
             height:100%;
        }*/

        .transparente {
            background-color: transparent;
            border-width: 0px;
            color: whitesmoke;
        }

        .inputline {
            background-color: transparent;
            border: 0px;
            border-bottom: solid;
            border-bottom-width: 1px;
            border-bottom-color: white;
            padding-left: 0px;
            max-width: none;
        }

        .form-control {
            box-shadow: none !important;
            border-radius: 0px !important;
            border-bottom: 1px solid #ffffff !important;
            border-top: 1px !important;
            border-left: none !important;
            border-right: none !important;
        }

        .btn-deep-purple {
            background: #2196f3;
            border-radius: 18px;
            padding: 5px 19px;
            color: #FFF;
            font-weight: 600;
            float: right;
            -webkit-box-shadow: 0px 0px 14px 0px rgba(0,0,0,0.24);
            -moz-box-shadow: 0px 0px 14px 0px rgba(0,0,0,0.24);
            box-shadow: 0px 0px 14px 0px rgba(0,0,0,0.24);
        }

        .inputline:focus {
            background-color: transparent;
            max-width: none;
        }

        body {
            padding: 25px;
            background: url(/../../Images/BackGround01.png);
            background-repeat: no-repeat;
            background-size: auto;
            background-position: top 150px;
            padding: 0;
            margin: 0;
            overflow-y: hidden;
        }

        .row {
            padding-right: 0px;
            padding-left: 0px;
        }

        .container-fluid {
            padding-right: 0px;
            padding-left: 0px;
        }

        #contenedor {
            width: 100%;
            height: 100%;
            overflow-y: hidden;
            position: fixed;
            overflow-x: hidden;
            /* top: 76px; */
            background: url(/../../Images/BackGround01.png);
            background-size: cover;
            z-index: 0;
        }

        #formulario {
            padding-top: 5%;
            padding-left: 15%
        }

        .titulo {
            font-family: 'Times New Roman';
            text-align: center;
            text-shadow: 2px 2px 2px black;
        }

        .cajatexto {
            max-width: none;
        }

        .col-centered {
            float: none;
            margin: 0 auto;
        }

        @media screen and (max-width: 767px) {
            #formulario {
                padding-top: 5%;
                padding-left: 0%;
            }
        }

        ::-webkit-input-placeholder { /* WebKit, Blink, Edge */
            color: white;
        }

        :-moz-placeholder { /* Mozilla Firefox 4 to 18 */
            color: white;
            opacity: 1;
        }

        ::-moz-placeholder { /* Mozilla Firefox 19+ */
            color: white;
            opacity: 1;
        }

        :-ms-input-placeholder { /* Internet Explorer 10-11 */
            color: white;
        }

        ::-ms-input-placeholder { /* Microsoft Edge */
            color: white;
        }

        ::placeholder { /* Most modern browsers support this now. */
            color: white;
        }

        .idioma01 {
            text-align: right;
            font-size: 14px;
            color: #f1f1f1;
            margin-top: 0.6em;
        }

        .imagen_i {
            margin-right: 0.7em;
            width: 6vh;
        }

        .imagen_e {
            margin-left: 0.7em;
            width: 6vh;
        }

        .btn03 {
            background-color: #0A435E;
            border: #0A435E;
        }

        .navbar-light .navbar-nav .nav-link:focus, .navbar-light .navbar-nav .nav-link:hover {
            opacity: 0.7;
        }

        .navbar-light .navbar-nav .nav-link {
            color: #f9f9f9;
            font-size: 14px;
        }

        .right {
            text-align: right !important;
        }

        .left {
            text-align: left;
        }

        .center {
            text-align: center !important;
        }

        .inputline {
            color: #fff !important;
            opacity: 0.8 !important;
        }

        .forget-link:hover {
            cursor: pointer;
            text-decoration: underline !important;
        }
    </style>

</head>
<body>

    <form class="form" runat="server" role="form" autocomplete="off" id="formLogin" novalidate="" method="POST">
        <asp:ScriptManager runat="server" ID="ScriptManagerAcompanante" EnablePartialRendering="true" />

        <div class="navbar navbar-expand-lg fixed-top text-center" style="height: 80px; background-color: #0A435E;">
            <div class="col-md-10 col-centered text-center">
                <img src="/Images/Logo01.png" />
            </div>
            <div class="col-md-2">
                <p class="idioma01">
                    <a href="Login.aspx?codIdioma=ENG">
                        <img class="imagen_i" alt="Ingles" src="Images/ingles.jpg" /></a> | <a href="Login.aspx?codIdioma=SPA">
                            <img alt="Español" class="imagen_e" src="Images/español.jpg" /></a>
                </p>
            </div>
            <button type="button" class="btn btn-info btn-lg" onclick="abrir()">XXXXXX</button>
        </div>

        <!-- Modal -->
        <div class="modal fade" id="myModal" role="dialog">
            <asp:UpdatePanel ID="UpdatePanelCapcha" runat="server">
                <ContentTemplate>
                    <div class="modal-dialog">
                        <!-- Modal contenido-->
                        <div class="modal-content">
                            <!-- Modal cabecera -->
                            <div class="modal-header">
                                <h4 id="H1" runat="server" class="modal-title">Confirmar</h4>
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                            </div>
                            <!-- Modal cuerpo -->
                            <div class="modal-body">
                                <p id="P1" runat="server" class="big02 nopadding onlymargintop-10">
                                    Ingrese el codigo capcha.
                                </p>
                                <asp:UpdatePanel ID="UpdatePanelImageCaptcha" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <!--IMAGEN DE CAPTCHA-->
                                        <img id="Image2" runat="server" style="height: 55px; width: 186px;" src="~/Views/Principal/Captcha.aspx" />
                                        <!--BOTON DE REFRESCAR CAPTCHA-->

                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <br />
                                <asp:TextBox runat="server" ID="txtVerificationCode"></asp:TextBox>
                                <asp:Label runat="server" ID="lblCaptchaMessage"></asp:Label>
                            </div>
                            <div id="AlertSesionError2" runat="server" class="alert alert-warning" visible="false">
                                <p><strong>revisar!</strong> formato de correo incorrecto!</p>
                            </div>

                            <!-- Modal footer -->
                            <div class="modal-footer">
                                <asp:Button ID="btnValid" runat="server" Text="Button" class="btn btn-default" />
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>

    <script>
        function abrir() {
            alert("Abrir");
            $("#myModal").modal();
        }
    </script>

</body>
</html>
