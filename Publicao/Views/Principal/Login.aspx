<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.Login" %>

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
    <%--<asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />--%>
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
            overflow-y: auto;
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

        #titulo {
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
    </style>
</head>
<body>
    <%--<form id="form1" runat="server">--%>
    <div class="navbar navbar-expand-lg fixed-top text-center" style="height: 80px; background-color: #0A435E;">
        <div class="col-md-8 col-centered text-center">
            <img src="/Images/Logo01.png" />
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
                                    <h3 id="titulo" class="mb-0">EVENTOS</h3>
                                    <h3 id="titulo" class="mb-0">BCRP</h3>
                                    <hr />

                                </div>
                                <div class="card-body">
                                    <p>Bienvenidos por favor ingrese sus datos:</p>
                                    <form class="form" runat="server" role="form" autocomplete="off" id="formLogin" novalidate="" method="POST">
                                        <div class="form-group">
                                            <%--<label for="uname1">Username</label>--%>
                                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control form-control-lg rounded-0 inputline" onfocus="this.placeholder = ''" onblur="this.placeholder = 'CORREO ELECTRÓNICO'" placeholder="CORREO ELECTRÓNICO" required="" value="jaranar@tgestiona.com.pe"></asp:TextBox>
                                            <%--<input type="text" class="form-control form-control-lg rounded-0 inputline" name="uname1" id="uname1" onfocus="this.placeholder = ''" onblur="this.placeholder = 'CORREO ELECTRÓNICO'" placeholder="CORREO ELECTRÓNICO" required=""/>--%>
                                            <div class="invalid-feedback">Oops, you missed this one.</div>
                                        </div>
                                        <hr />
                                        <div class="form-group">
                                            <%--<label>Password</label>--%>
                                            <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control form-control-lg rounded-0 inputline" onfocus="this.placeholder = ''" onblur="this.placeholder = 'CONTRASEÑA'" placeholder="CONTRASEÑA" required="" TextMode="Password" value="1234"></asp:TextBox>
                                            <%--<input type="password" class="form-control form-control-lg rounded-0 inputline" id="pwd1" onfocus="this.placeholder = ''" onblur="this.placeholder = 'CONTRASEÑA'" placeholder="CONTRASEÑA" required="" autocomplete="new-password"/>--%>
                                            <div class="invalid-feedback">Enter your password too!</div>
                                        </div>
                                        <hr />
                                        <div class="col-md-8 col-centered text-center">
                                            <asp:Button ID="btnIngresar" runat="server" Text="Inicar Sesión" CssClass="btn btn-primary btn-md btn-block" OnClick="btnIngresar_Click" />
                                            <%--<button type="submit" class="btn btn-primary btn-md btn-block " id="btnLogin">INGRESAR</button>--%>
                                        </div>
                                        <hr />
                                        <div class="col-md-8 col-centered text-center">
                                            <a>¿Olvidó su contraseña?
                                            </a>

                                        </div>
                                        

                                        

                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


    </div>


    <%--</form>--%>
</body>
<script src="/../../Scripts/bootstrap.min.js"></script>
<script src="/../../Scripts/jquery-3.3.1.js"></script>
</html>