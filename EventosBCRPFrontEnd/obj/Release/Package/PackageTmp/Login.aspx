<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EventosBCRPFrontEnd.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>BCRP-EVENTOS</title>
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="Content/css/Scrollbar.css" rel="stylesheet" />
    <link href="Content/css/bootstrap-glyphicons.css" rel="stylesheet" />
    <script src="/Scripts/jquery-3.3.1.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>
    <link href="Content/css/main.css" rel="stylesheet" />

    <%--<asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />--%>
    <style>
        /*html body {
             height:100%;
        }*/
       @font-face {
    font-family: 'TrajanPro-Regular'; 
    src: url('Content/fonts/TrajanPro-Regular.eot');
    src: url('Content/fonts/TrajanPro-Regular.eot?#iefix') format('embedded-opentype'),
        url('Content/fonts/TrajanPro-Regular.woff') format('woff'), 
        url('Content/fonts/TrajanPro-Regular.ttf') format('truetype'), 
        url('Content/fonts/TrajanPro-Regular.svg#TrajanPro_Regular') format('svg');
}

 .titulo {
            font-family: TrajanPro-Regular;
            text-align: center;
            text-shadow: 2px 2px 2px black;
        }

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

        


        .center{
            text-align: center !important;
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
            width: 3vh;
        }

        .imagen_e {
            margin-left: 0.7em;
            width: 3vh;
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

        .modal-header{
                background: #0A435E;
                color: #fff;
        }

        @media (min-width: 576px) {
            .modal-dialog {
                max-width: 15em;
                margin: 12rem auto;
            }
        }

        .btnmodal{
            background:#000;
            color:#fff;
            width: 15vh;
            border: 1px solid #000
        }

        .btnmodal:hover{
            background:#fff;
            color:#000;
            width: 15vh;
            border: 1px solid #000
        }

    </style>
</head>
<script type="text/javascript"> 

    function callAlert() {
        $(".alert").fadeTo(2600, 0).slideUp(500, function () {
            $(this).hide();
        });
    };
    function CloseAlert() {
        $("#myModal").CTools.Modal.dismiss();
    };

    function CallCapcha() {

        //$("#myModal").modal("hide");
        //$("#myModal").CTools.modal.dismiss();
        $("#myModal2").CTools.Modal.dismiss();
    };
</script>
<body>
    <%--<form id="form1" runat="server">--%>
    <form class="form" runat="server" role="form" autocomplete="off" id="formLogin" novalidate="" method="POST">
        <div class="navbar navbar-expand-lg fixed-top text-center" style="height: 80px; background-color: #0A435E;">
            <div class="col-md-10 col-centered text-center">
                <img src="/Images/Logo01.png" />
            </div>
            <div class="col-md-2">
                <p class="idioma01">
                    <a href="Login.aspx?codIdioma=ENG">
                        <img class="imagen_i" alt="Ingles" src="Images/ingles-off.png" id="idiomaEng" onmouseout="Interruptor()"/>
                    </a> | <a href="Login.aspx?codIdioma=SPA">
                            <img alt="Español" class="imagen_e" src="Images/español.png" id="idiomaSpa" onmouseout="Interruptor()" /></a>
                </p>
            </div>

        </div>
        <div id="contenedor" class="container-fluid  py-5">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12">
                        <div class="row">
                            <div id="formulario" class="col-md-6 ">
                                <div class="card rounded-0 transparente">
                                    <div class="card-header transparente">
                                        <h3 id="titulo0" runat="server" class="titulo mb-0">EVENTOS</h3>
                                        <h3 id="titulo1" runat="server" class="titulo mb-0">BCRP</h3>
                                        <hr />

                                    </div>
                                    <div class="card-body">
                                        <p id="lblBienvenida" runat="server">Bienvenidos, por favor ingrese sus datos:</p>
                                        <%--<form class="form" runat="server" role="form" autocomplete="off" id="formLogin" novalidate="" method="POST">--%>
                                        <br />
                                        <div class="form-group">
                                            <%--<label for="uname1">Username</label>--%>
                                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control form-control-lg rounded-0 inputline" onfocus="this.placeholder = ''" onblur="this.placeholder = 'CORREO ELECTRÓNICO'" placeholder="CORREO ELECTRÓNICO" required="" value="invitado@bcrp.com" AutoPostBack ="false"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Not a Valid Email Address" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="CreateUserForm">
                                            </asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ControlToValidate="txtUsuario" ErrorMessage="E-mail is required." ID="EmailRequired" runat="server" ToolTip="E-mail is required." ValidationGroup="CreateUserForm" >*</asp:RequiredFieldValidator>
                                            <%--<input type="text" class="form-control form-control-lg rounded-0 inputline" name="uname1" id="uname1" onfocus="this.placeholder = ''" onblur="this.placeholder = 'CORREO ELECTRÓNICO'" placeholder="CORREO ELECTRÓNICO" required=""/>--%>
                                            <div class="invalid-feedback">Oops, you missed this one.</div>
                                        </div>
                                        <%--<hr />--%>
                                        <div class="form-group">
                                            <%--<label>Password</label>--%>
                                            <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control form-control-lg rounded-0 inputline" onfocus="this.placeholder = ''" onblur="this.placeholder = 'CONTRASEÑA'" placeholder="CONTRASEÑA" required="" TextMode="Password" value="P@ssw0rd" AutoPostBack ="false"></asp:TextBox>
                                            <%--<input type="password" class="form-control form-control-lg rounded-0 inputline" id="pwd1" onfocus="this.placeholder = ''" onblur="this.placeholder = 'CONTRASEÑA'" placeholder="CONTRASEÑA" required="" autocomplete="new-password"/>--%>
                                            <div class="invalid-feedback">Enter your password too!</div>
                                        </div>
                                        <hr />
                                        <div class="col-md-8 col-centered text-center">
                                            <!--BOTON DE INGRESAR USUARIO-->
                                            <asp:LinkButton ID="btnIngresar" runat="server" Text="¿Olvidó su contraseña?" CssClass="btn btn03 btn-primary btn-md btn-block" OnClick="btnIngresar_Click" data-dismiss="modal" data-toggle="modal" data-target="#ModalCaptcha" />
                                            <%--<asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn03 btn-primary btn-md btn-block" OnClick="btnIngresar_Click" />--%>
                                            <%--<button type="submit" class="btn btn-primary btn-md btn-block " id="btnLogin">INGRESAR</button>--%>
                                        </div>
                                        <hr />

                                        <div class="col-md-8 col-centered text-center">
                                            <%-- <asp:Button ID="Button1" runat="server" Text="Button" />--%>
                                            <%--<asp:LinkButton ID="btnOlvidar" runat="server" Text="¿Olvidó su contraseña?" OnClick="Olvidar_Click">LinkButton</asp:LinkButton>--%>
                                            <a id="btnOlvidar" runat="server" class="btn-link forget-link" data-dismiss="modal" data-toggle="modal" data-target="#myModal">¿Olvidó su contraseña?
                                            </a>

                                            <%--<asp:LinkButton ID="btnOlvidar" runat="server" Text="¿Olvidó su contraseña?" OnClick="Olvidar_Click" type="button"  data-dismiss="modal">LinkButton</asp:LinkButton>--%>
                                            <%--<asp:LinkButton ID="btnOlvidar" runat="server" Text="¿Olvidó su contraseña?" CssClass="btn-link" href="#" onclick="Olvidar_Click"></asp:LinkButton>--%>
                                        </div>

                                        <div id="msgContrasena" runat="server" class="alert alert-success" role="alert" visible="false">
                                            <strong>Hecho!</strong> Se envio Contraseña a su correo.
                                        </div>



                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <%--<div id="divcapcha" style="visibility: hidden"></div>--%>
        <!--MODAL DELEGAR PARTICIPANTE-->
        <!-- Modal -->
        <asp:ScriptManager runat="server" ID="ScriptManagerAcompanante" EnablePartialRendering="true" />

        <div class="modal fade" id="myModal" role="dialog">
            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>
                    <div class="modal-dialog">

                        <!-- Modal content-->
                        <div class="modal-content center">
                            <!-- Modal Header -->
                            <div class="modal-header center">
                                <h4 id="delegarPartMdl" runat="server" class="modal-title">Confirmar</h4>
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                            </div>

                            <!-- Modal body -->
                            <div class="modal-body">
                                <p id="tituloMdl" runat="server" class="big02 nopadding onlymargintop-10">
                                    Se enviara a su correo una nueva contraseña ¿Esta seguro(a)?
                                </p>
                                <br />
                                <div id="S02" runat="server" class="alert alert-success" visible="false">
                                    <strong>Se envio la contraseña a su correo electronico registrado</strong>
                                </div>
                                <div id="D01" runat="server" class="alert alert-warning" visible="false">
                                    <strong>No se pudieron ahcer los cambios!</strong>
                                </div>
                                <div id="D02" runat="server" class="alert alert-warning" visible="false">
                                    <p><strong>revisar!</strong> formato de incorrecto!</p>
                                </div>
                            </div>

                            <!-- Modal footer -->
                            <div class="modal-footer">
                                <asp:LinkButton ID="btnSi" runat="server" OnClick="btnSi_Click" class="btn btnmodal1 btn-primary">Si</asp:LinkButton>
                                <button type="button" class="btn btnmodal1" id="modal-btn-no">No</button>
                                <%--<asp:LinkButton ID="btnEnviarMdl" runat="server" OnClick="btnEnviarMdl_Click" type="button" class="btn btn-danger" data-dismiss="modal">LinkButton</asp:LinkButton>--%>
                                <%--<asp:LinkButton id="btnEnviarMdl" runat="server" OnClick="btnEnviarMdl_Click" type="button" class="btn btn-danger" data-dismiss="modal"/>--%>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <!--MODAL DE CAPTCHA-->
        <div class="modal fade" id="ModalCaptcha" role="dialog">
            <asp:UpdatePanel ID="UpdatePanelCapcha" runat="server">
                <ContentTemplate>
                    <div class="modal-dialog">
                        <!-- Modal contenido-->
                        <div class="modal-content center">
                            <!-- Modal cabecera -->
                            <div class="modal-header center">
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
                                    <img id="Image2" runat="server" style="height:55px; width:186px;" src="~/Views/Principal/Captcha.aspx"  />
                                    <br />
                                    <!--BOTON DE REFRESCAR CAPTCHA-->
                                    <asp:Button ID="btnRefreshCaptcha" runat="server" Text="Actualizar" OnClick="btnRefreshCaptcha_Click" class="btn btnmodal" style="margin-top:0.8em;" />
                                    
                                 </ContentTemplate>
                                </asp:UpdatePanel>
                                <br />
                                <asp:TextBox runat="server" ID="txtVerificationCode"></asp:TextBox>
                                <asp:Label runat="server" ID="lblCaptchaMessage"  class="alert alert-warning"></asp:Label>
                            </div>
                            <div id="AlertSesionError2" runat="server" class="alert alert-warning" visible="false">
                                    <p id="lblCaptchaAlter" runat="server"><strong>revisar!</strong> Usuario y/o contraseña invalido</p>
                            </div>
                            
                            <!-- Modal footer -->
                            <div class="modal-footer">
                                <asp:Button ID="btnValid" runat="server" Text="Ingresar" OnClick="btnValid_Click" class="btn btnmodal"/>

                                <%--<asp:LinkButton ID="LinkButton1" runat="server" OnClick="ValidarCapcha_Click" type="button" class="btn btn-default">Validar</asp:LinkButton>--%>
                                <%--<button type="button" class="btn btn-primary" id="modal-btn-no">No</button>--%>
                                <%--<asp:LinkButton ID="btnEnviarMdl" runat="server" OnClick="btnEnviarMdl_Click" type="button" class="btn btn-danger" data-dismiss="modal">LinkButton</asp:LinkButton>--%>
                                <%--<asp:LinkButton id="btnEnviarMdl" runat="server" OnClick="btnEnviarMdl_Click" type="button" class="btn btn-danger" data-dismiss="modal"/>--%>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

    </form>
        <script >
spaON=new Image
spaON.src = "Images/español.png"
spaOFF=new Image
spaOFF.src = "Images/español-off.png"
engON = new Image
engON.src = "Images/ingles.png"
engOFF = new Image
engOFF.src = "Images/ingles-off.png"
var i = 1;
function Interruptor() {                      
   if (i == 1)
      {
       document.images['idiomaSpa'].src = spaOFF.src;
       document.images['idiomaEng'].src = engON.src;
      i=2;
      }
   else
      {
       document.images['idiomaSpa'].src = spaON.src
       document.images['idiomaEng'].src = engOFF.src
      i=1;
      }
   }
</script>
</body>

</html>
