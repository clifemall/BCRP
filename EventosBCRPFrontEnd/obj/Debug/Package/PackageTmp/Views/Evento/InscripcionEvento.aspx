<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Principal/MasterEvento.Master" AutoEventWireup="true" CodeBehind="InscripcionEvento.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Evento.InscripcionEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js"></script>
    <%--<script src="https://unpkg.com/leaflet@1.0.3/dist/leaflet.js"></script>--%>
    <script src="../../Scripts/OpenStreet/leaflet-src.js"></script>
    <script src="../../Scripts/OpenStreet/leaflet.js"></script>
    <link href="../../Content/jquery.toast.css" rel="stylesheet" />
    <script src="../../Scripts/jquery.toast.js"></script>
    <style>
        /*-----------------------------------
        -----------------------------------*/
        * {
            box-sizing: border-box;
        }

        body {
            font: 16px Arial;
        }

        .autocomplete {
            /*the container must be positioned relative:*/
            position: relative;
            display: inline-block;
        }

        input {
            border: 1px solid #ced4da;
            ;
            background-color: #f1f1f1;
            padding: 10px;
            font-size: 16px;
        }

            input[type=text] {
                width: 100%;
            }

            input[type=submit] {
                background-color: DodgerBlue;
                color: #fff;
                cursor: pointer;
            }

        .autocomplete-items {
            position: absolute;
            border: 1px solid #d4d4d4;
            border-bottom: none;
            border-top: none;
            z-index: 99;
            /*position the autocomplete items to be the same width as the container:*/
            top: 100%;
            left: 0;
            right: 0;
        }

            .autocomplete-items div {
                padding: 10px;
                cursor: pointer;
                background-color: #fff;
                border-bottom: 1px solid #d4d4d4;
            }

                .autocomplete-items div:hover {
                    /*when hovering an item:*/
                    background-color: #e9e9e9;
                }

        .autocomplete-active {
            /*when navigating through the items using the arrow keys:*/
            background-color: DodgerBlue !important;
            color: #ffffff;
        }

        /*----------------------------------
----------------------------------*/


        .big02 {
            color: #0B425F;
            font-weight: 700;
            font-size: 13px !important;
        }

        .big10 {
            color: #0B425F;
            font-weight: 700;
            font-size: 18px !important;
            line-height: 0.5;
        }

        nav .nav-link:focus, .navbar-light .navbar-nav .nav-link:hover {
            opacity: 1 !important;
        }


        .big03 {
            color: #0B425F;
            font-weight: 400;
            font-size: 13px !important;
            text-align: left;
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



        .label001 {
            font-weight: 700;
            font-size: 12px;
            line-height: 0.5;
        }

        .big_02 {
            color: #0B425F;
            font-weight: 700;
            font-size: 11.5px !important;
            text-align: left !important;
        }

        .label01 {
            font-size: 12px;
            line-height: 0.5;
        }
        /*-------------------*/
        .form-control-Error {
            background-color: #F9F2F4;
            border: 1px solid #DB7791;
        }

        .form-control, input {
            font-size: 13px;
            padding: 6px 8px;
        }


        .space3 {
            padding-right: 0.4em !important;
        }

        .space4 {
            padding-left: 0.4em !important;
        }

        .btn003 {
            width: 100%;
            font-size: 13px;
            padding: 6px 8px;
            color: #495057 !important;
            background: #fff !important;
            border: 1px solid #ced4da !important;
        }

        .btn0031 {
            width: 100%;
            font-size: 13px;
            padding: 6px 8px;
            color: #495057 !important;
            background: #fff !important;
            border: 1px solid #ced4da !important;
        }

        .CheckboxList input {
            float: left;
            clear: both;
        }

        .btn04 {
            background-color: #0A435E !important;
            margin-top: 2em !important;
            width: 22vh;
        }

        .btn05 {
            background-color: #0A435E !important;
            margin-top: 1em !important;
            width: 22vh;
            color: #fff;
        }

        .image_05 {
            width: 20vh;
            max-width: 100%;
            max-height: 100%;
        }

        .btn06 {
            background: #fff;
            color: #0A445B;
            border: 1px solid #0A445B;
            font-size: 13px;
            font-weight: 600;
        }

        .btn07 {
            font-size: 13px;
            font-weight: 700;
            color: #0A435E;
        }

        .onlypadding-25 {
            padding: 1em 0.5em 1.5em 0.5em !important;
        }


        @media (min-width: 768px) {
            .col-md-6, .col-md-9,
            .col-md-3, .col-md-12 {
                float: left;
                padding-right: 0px;
                padding-left: 0px;
            }
        }


        .container1 {
            margin-bottom: 12px;
            cursor: pointer;
            font-size: 13.5px;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
            color: #0B425F;
        }

            .container1 input {
                margin-left: 1em;
                cursor: pointer;
                margin-top: 0.2em;
            }


        .checkmark {
            position: absolute;
            top: 3px;
            margin-left: 1em;
            height: 13px;
            width: 13px;
            background-color: #eee;
            border: 1px solid #999;
        }


        .container1:hover input ~ .checkmark {
            background-color: #ccc;
        }


        .container1 input:checked ~ .checkmark {
            background-color: #000;
        }


        .checkmark:after {
            content: "";
            position: absolute;
            display: none;
        }


        .container1 input:checked ~ .checkmark:after {
            display: block;
        }


        .container1 .checkmark:after {
            left: 9px;
            top: 5px;
            width: 5px;
            height: 10px;
            border-width: 0 3px 3px 0;
            -webkit-transform: rotate(45deg);
            -ms-transform: rotate(45deg);
            transform: rotate(45deg);
        }
    </style>

    <%--<body>
    <form id="form2" runat="server" class="row">--%>

    <!--CONTENIDO DE FOTO | IZQUIERDO-->
    <div class="col-md-3 barimage contentindex" style="background: url('/Images/Ima01.png') no-repeat; background-size: cover;"></div>
    <!--CONTENIDO DERECHO FORMULARIOS-->
    <div class="col-md-9 contentindex" id="panel_evento2">
        <div class="container contenedoreventos" id="panel_evento3">
            <div class="panel-body scrollbar-black " runat="server" id="panel_evento4">
                <div class="container-fluid">
                    <div class="container">
                        <p id="titInscripcion" runat="server" class="titulocontenedor"><u>INSCRIPCIÓN</u></p>
                    </div>

                    <div class="container-fluid nopadding nomargin text-right">
                        <div class="col-md-3"></div>
                        <%--<img src="../../Images/Pdefault.jpeg" />--%>
                        <div class="col-md-8 nopadding nomargin" id="menuins" style="display: inline-block;">
                            <nav>
                                <div class="nav nav-pills nav-justified" id="nav-inscripcion" role="tablist">
                                    <a class="nav-item nav-link navprimary active" id="navinfogeneral" runat="server" data-toggle="tab" href="#nav-content-infogeneral" role="tab" aria-controls="nav-home" aria-selected="true">
                                        <img src="../../Images/Icons/Info-40.png" />
                                        Información general
                                    </a>
                                    <a class="nav-item nav-link" id="navagenda" runat="server" data-toggle="tab" href="#nav-content-agenda" role="tab" aria-controls="nav-profile" aria-selected="false">
                                        <img src="../../Images/Icons/Calendar-40.png" />
                                        Agenda/Actividad
                                    </a>
                                    <a class="nav-item nav-link" id="navadicional" runat="server" data-toggle="tab" href="#nav-content-adicional" role="tab" aria-controls="nav-contact" aria-selected="false">
                                        <img src="../../Images/Icons/Mail-40.png" />
                                        Información adicional
                                    </a>
                                </div>
                            </nav>
                        </div>

                        <div class="clearfix"></div>
                    </div>
                    <hr />
                    <div class="row nomargin" style="overflow-y: inherit !important;">
                        <!--LADO IZQUIDO PERFIL-->
                        <div class="col-md-3">

                            <div class="col-sm-12">
                                <asp:Image ID="imgParticipante" Width="200px" Style="padding-bottom: 10px;" runat="server" alt="Foto Participante" class="photoparticipante" onerror="this.onload = null; this.src='../../Images/Pdefault.jpeg';" />
                                <br />
                                <strong>
                                    <asp:Label ID="lblNombre" CssClass="big10" runat="server"></asp:Label>
                                </strong>
                                <br />
                                <asp:Label ID="lblOrganizacion" runat="server" CssClass="label01"></asp:Label>
                                <br />
                                <asp:Label ID="lblCorreo" runat="server" CssClass="label001"></asp:Label>
                                <br />
                                <div class="ocultar-mobil">
                                    <br />
                                    <%--<asp:Button ID="btnDelegar" runat="server" CssClass="btn btn-success" Text="Delegar Invitación" data-toggle="modal" data-target="#myModal" />--%>
                                    <%--<asp:LinkButton ID="btnDelegar" runat="server" CssClass="btn btn-success" data-toggle="button" aria-pressed="false" autocomplete="off" >
                                     
                                    </asp:LinkButton>--%>
                                    <p>&nbsp</p>
                                    <p>&nbsp</p>

                                </div>
                                <a id="btnDelegar" style="color: #fff; background-color: #007bff; border-color: #007bff;" class="btn btn-success" data-toggle="button" aria-pressed="false" autocomplete="off">Delegar Participación</a>

                                <asp:Image ID="informacion" runat="server" src="../../Images/i.png" data-toggle="tooltip" data-placement="top" title="Delegar invitacion a otro participante"></asp:Image>
                            </div>


                        </div>

                        <!--CONTENIDO1-->
                        <div id="contenido1" class="col-sm-9 nopadding">
                            <%--<div id="panel-inscripcion">

                                </div>--%>
                            <div class="tab-content" id="nav-tabContent">
                                <!--INFORMACION GENERAL-->
                                <div class="tab-pane fade show active" id="nav-content-infogeneral" role="tabpanel" aria-labelledby="nav-home-tab">
                                    <!--NAVEGADOR DE INFORMACION GENERAL-->
                                    <nav>
                                        <div class="nav nav-pills nav-justified" id="nav-infomaciogeneral" role="tablist">
                                            <a class="nav-item nav-link btn-lg navprimary nav-infog active" id="navdatospersonales" runat="server" data-toggle="tab" href="#nav-content-datospersonales" role="tab" aria-controls="nav-home" aria-selected="true">Datos Personales
                                            </a>
                                            <%--<a class="nav-item nav-link nav-infog" id="navdatoscontacto" runat="server" data-toggle="tab" href="#nav-content-datoscontacto" role="tab" aria-controls="nav-profile" aria-selected="false">Datos de Contacto
                                            </a>--%>
                                            <a class="nav-item nav-link nav-infog" id="navcondicionesespeciales" runat="server" data-toggle="tab" href="#nav-content-condicionesespeciales" role="tab" aria-controls="nav-contact" aria-selected="false">Condiciones Especiales
                                            </a>
                                            <a class="nav-item nav-link nav-infog" id="navacompanantes" runat="server" data-toggle="tab" href="#nav-content-acompanantes" role="tab" aria-controls="nav-contact" aria-selected="false">Acompañantes
                                            </a>
                                        </div>
                                    </nav>
                                    <!--CONTENEDOR DEL NAVEGADOR / INFORMACION GENERAL-->
                                    <div class="col-md-12 tab-content onlymargintop-5" id="nav-tabContent-infogeneral">
                                        <!--DATOS PERSONALES-->
                                        <div class="tab-pane fade show active" id="nav-content-datospersonales" role="tabpanel" aria-labelledby="nav-profile-tab">
                                            <asp:UpdatePanel ID="UpdatePanelDatosPersonales" runat="server">
                                                <ContentTemplate>
                                                    <%--<script type="text/javascript">

                                                        $(".alert-success").show(function () {
                                                            alert("aquitoy");
                                                            $(".alert-success").fadeTo(1000, 0).slideUp(500, function () {
                                                                $(this).hide();
                                                            });
                                                        });

                                                    </script>--%>



                                                    <div id="S01" runat="server" class="alert alert-success alerta" role="alert" visible="false">
                                                        <p>Cambios realizados</p>
                                                    </div>
                                                    <div id="D01" runat="server" class="alert alert-warning alerta" role="alert" visible="false">
                                                        <p>
                                                            No se pudieron hacer los cambios! 
                                                         
                                                        </p>
                                                    </div>
                                                    <div class="row scrollbar-black nomargin nopadding onlypadding-25" style="overflow-y: scroll; height: 24em;">
                                                        <div class="col-sm-6" style="text-align: left">
                                                            <p>Datos Personales</p>
                                                            <!--TITULO DEL PARTICIPANTE-->
                                                            <p id="TituloParticipante" runat="server" class="big02 nopadding onlymargintop-10">
                                                                Título (Ejm. &quot;Sr.&quot;, &quot;Ing.&quot;)
                                                            </p>
                                                            <div style="line-height: 5px;">
                                                                <asp:TextBox ID="txtTitulo" MaxLength="30" runat="server" class="form-control" />
                                                                <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtTitulo" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqTitulo" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>

                                                            <p id="p1" runat="server" class="big02 nopadding onlymargintop-10">
                                                                Nombre
                                                            </p>
                                                            <div style="line-height: 5px;">
                                                                <asp:TextBox ID="txtNombre" MaxLength="150" runat="server" class="form-control" Enabled="False" Width="100%" />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtNombre" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqNombre" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>
                                                                <%--<asp:RegularExpressionValidator ID="RegNombre" ForeColor="Red" Font-Size="X-Small" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingrese dato valido" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*" ValidationGroup="val" >
                                                                </asp:RegularExpressionValidator>--%>
                                                            </div>
                                                            <p id="docIdentidadPartic" runat="server" class="big02 nopadding onlymargintop-10">
                                                                Documento de identidad
                                                            </p>
                                                            <div class="col-md-6 space4">
                                                                <asp:DropDownList ID="dpTipoDocumento" runat="server" AutoPostBack="true" BackColor="#0A445B" class="btn0031" DataTextField="NombeTipoDocumento" DataValueField="id_TipoDocumento" />
                                                            </div>
                                                            <div class="col-md-6 space4" style="line-height: 5px;">
                                                                <asp:TextBox ID="txtDocumento" MaxLength="20" runat="server" class="form-control" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtDocumento" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqDoc" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>

                                                            <p id="Telefono" runat="server" class="big02 nopadding onlymargintop-10" style="line-height: 20px;">
                                                                Teléfono
                                                            </p>
                                                            <div style="line-height: 3px;">
                                                                <asp:TextBox ID="txtTelefono" MaxLength="40" runat="server" class="form-control" onkeypress="return isNumberKey(event)" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtTelefono" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="RecTlf" runat="server" ValidationGroup="val">*Campo requeridoo</asp:RequiredFieldValidator>

                                                            </div>

                                                            <p id="P2" runat="server" class="big02 nopadding onlymargintop-10">
                                                                Correo
                                                            </p>
                                                            <div style="line-height: 3px;">
                                                                <asp:TextBox ID="txtCorreo" MaxLength="200" runat="server" class="form-control" Enabled="False" Width="100%" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtCorreo" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqCorreo" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>


                                                            <p>&nbsp</p>
                                                            <p>Datos Adicionales</p>
                                                            <p id="CorreoEmergencia" runat="server" class="big02 onlymargintop-10">
                                                                Correo de emergencia<br />
                                                            </p>
                                                            <div style="line-height: 3px;">
                                                                <asp:TextBox ID="txtCorreoEmergencia" MaxLength="200" name="txtCorreoEmergencia" runat="server" class="form-control" Style="width: 100%" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtCorreoEmergencia" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqCorreoAd" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>

                                                            <p id="TelefonoEmergencia" runat="server" class="big02 onlymargintop-10">
                                                                Teléfono de emergencia<br />
                                                            </p>
                                                            <div style="line-height: 3px;">
                                                                <asp:TextBox ID="txtTelefonoEmergencia" MaxLength="40" onkeypress="return isNumberKey(event)" runat="server" class="form-control" Style="width: 100%" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtTelefonoEmergencia" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqTlfA" runat="server" ValidationGroup="val">*Campo requeridoo</asp:RequiredFieldValidator>

                                                            </div>

                                                            <p id="ContactoEmergencia" runat="server" class="big02 onlymargintop-10">
                                                                Contacto de emergencia<br />
                                                            </p>
                                                            <div style="line-height: 3px;">
                                                                <asp:TextBox ID="txtContactoEmergencia" MaxLength="200" runat="server" class="form-control" Style="width: 100%" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtContactoEmergencia" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqContactoA" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>


                                                        </div>
                                                        <div class="col-sm-6" style="text-align: left">
                                                            <p>Datos Laborales</p>
                                                            <p id="institucPartic" runat="server" class="big02 nopadding onlymargintop-10">
                                                                Institución
                                                            </p>
                                                            <div style="line-height: 5px;">
                                                                <asp:TextBox ID="txtOrganizacion" MaxLength="200" Width="100%" Enabled="False" runat="server" class="form-control" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtOrganizacion" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="RegOrganizacion" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>
                                                            <p id="puestoParticipante" runat="server" class="big02 nopadding onlymargintop-10">
                                                                Cargo
                                                            </p>
                                                            <div style="line-height: 3px;">
                                                                <asp:TextBox ID="txtPuesto" MaxLength="150" runat="server" class="form-control" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtPuesto" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqPuesto" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>

                                                            <p id="Direccion" runat="server" class="big02 onlymargintop-10">
                                                                Dirección<br />
                                                            </p>
                                                            <div style="line-height: 3px;">
                                                                <asp:TextBox ID="txtDireccion" MaxLength="200" runat="server" class="form-control" Style="width: 100%" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtDireccion" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqDireccion" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>

                                                            <p id="Ciudad" class="big02 onlymargintop-10" runat="server" iclass="big02">
                                                                Ciudad<br />
                                                            </p>
                                                            <div style="line-height: 3px;">
                                                                <asp:TextBox ID="txtCiudad" MaxLength="100" runat="server" class="form-control" Style="width: 100%" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtCiudad" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqCiudad" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>

                                                            <p id="paisParticip" runat="server" class="big02 nopadding onlymargintop-10">
                                                            </p>
                                                            <div style="line-height: 3px;">
                                                                <asp:TextBox ID="txtPais" runat="server" MaxLength="200" class="form-control" />
                                                                <br />
                                                                <asp:RequiredFieldValidator ControlToValidate="txtPais" ForeColor="Red" Font-Size="X-Small" ErrorMessage="*Campo requerido" ID="ReqPais" runat="server" ValidationGroup="val">*Campo requerido</asp:RequiredFieldValidator>

                                                            </div>


                                                            <%--<p id="abrevParticip" runat="server" class="big02 nopadding onlymargintop-10">
                                                                Abreviatura de Institución</p>
                                                            <asp:TextBox ID="txtAbreviatura" runat="server" class="form-control" />--%>
                                                        </div>
                                                        <div class="clearfix"></div>


                                                        <div class="col-lg-12" style="text-align: center">
                                                            <asp:Button ID="btnGuardarDatosPersonales" runat="server" Text="Guardar" OnClick="btnGuardarDatosPersonales_Click" ValidationGroup="val" class="btn btn04 btn-primary" />
                                                        </div>
                                                    </div>

                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                        <!--DATOS CONTACTOS-->
                                        <div class="tab-pane fade" id="nav-content-datoscontacto" role="tabpanel" aria-labelledby="nav-profile-tab">
                                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                <ContentTemplate>
                                                    <div class="container">
                                                        <div id="S02" runat="server" class="alert alert-success" visible="false">
                                                            <strong>Cambios realizados</strong>
                                                        </div>
                                                        <div id="D02" runat="server" class="alert alert-warning" visible="false">
                                                            <strong>No se pudieron ahcer los cambios!</strong>
                                                        </div>
                                                        <div class="row onlypadding-25 scrollbar-black" style="overflow-y: scroll; height: 24em;">

                                                            <div class="col-sm-6" style="text-align: left">
                                                                <p>Datos Personales</p>
                                                            </div>

                                                            <div class="col-sm-6" style="text-align: left">
                                                                <p>Datos Adicionales</p>


                                                            </div>
                                                            <br />
                                                            <div class="col-lg-12" style="text-align: center">
                                                                <asp:Button ID="btnGuardarContacto" runat="server" Text="Guardar" OnClick="btnGuardarDatosContacto_Click" class="btn btn04 btn-primary" BackColor="#0A445B" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                        <!--DATOS CONDICIONES ESPECIALES-->
                                        <div class="col-sm-12 tab-pane fade" id="nav-content-condicionesespeciales" role="tabpanel" aria-labelledby="nav-profile-tab">
                                            <asp:UpdatePanel ID="UpdatePanelCondicionesEspeciales" runat="server">
                                                <ContentTemplate>
                                                    <div class="row onlypadding-25 scrollbar-black " style="overflow-y: scroll; height: 24em;">
                                                        <div class="col-sm-12" style="text-align: left">
                                                            <div id="S03" runat="server" class="alert alert-success" visible="false">
                                                                <strong>Cambios realizados</strong>
                                                            </div>
                                                            <div id="D03" runat="server" class="alert alert-warning" visible="false">
                                                                <strong>No se pudieron hacer los cambios!</strong>
                                                            </div>
                                                            <%--<p id="SufresDisc" runat="server" class="big02" />--%>

                                                            <%--<asp:CheckBox ID="chFisica" runat="server" Text="fisíca" />
                                                            <asp:CheckBox ID="chSensorial" Style="margin-left: 1.5em" runat="server" Text="sensorial" />--%>

                                                            <%--<p id="Especifique1" runat="server" class="big02">Especifique</p>--%>
                                                            <%--<asp:TextBox ID="txtDiscapacidad" runat="server" TextMode="MultiLine" Width="100%" class="form-control" Style="resize: none" />--%>


                                                            <p id="TienesReq" runat="server" class="big02">Restricciones alimentarias adicionales </p>
                                                            <div style="padding: 5px"></div>
                                                            <%--<asp:CheckBox ID="chDiabetico" runat="server" Text="Diabético" />--%>
                                                            <%--<asp:CheckBox ID="chOtros" Style="margin-left: 1.5em" runat="server" Text="" />--%>

                                                            <%--<p id="Especifique2" runat="server" class="big02">Especifique</p>--%>
                                                            <asp:TextBox ID="txtRequerimiento" runat="server" TextMode="MultiLine" Width="100%" Height="250px" class="form-control" Style="resize: none" />
                                                            <p>&nbsp</p>
                                                            <h6>Si quiere una solicitud especial, comunicarse con: <a href="mailto:eventos@bcrp.gob.pe?Subject=Requerimientos%20especiales" target="_top">eventos@bcrp.gob.pe</a></h6>
                                                        </div>

                                                        <div class="col-sm-12" style="text-align: center">
                                                            <asp:Button ID="btnGuardarCondicionesEspeciales" runat="server" Text="Guardar" OnClick="btnGuardarCondicionesEspeciales_Click" class="btn btn05  btn-primary" BackColor="#0A445B" />
                                                        </div>
                                                    </div>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                        <!--DATOS ACOMPAÑANTES-->
                                        <div class="col-sm-12 tab-pane fade" id="nav-content-acompanantes" role="tabpanel" aria-labelledby="nav-profile-tab">
                                            <asp:UpdatePanel ID="UpdatePanelAcompanante" runat="server">
                                                <ContentTemplate>
                                                    <div class="col-sm-12 scrollbar-black" style="overflow-y: scroll; text-align: center; max-height: 490px;">
                                                        <div id="S04" runat="server" class="alert alert-success" visible="false">
                                                            <strong>Cambios realizados</strong>
                                                        </div>
                                                        <div id="D04" runat="server" class="alert alert-warning" visible="false">
                                                            <strong>No se pudieron ahcer los cambios!</strong>
                                                        </div>

                                                    </div>

                                                    <div class="row onlypadding-25 scrollbar-black" style="overflow-y: scroll; height: 24em;">
                                                        <div class="col-sm-12" style="text-align: left">


                                                            <p id="NombreAcomp" runat="server" class="big02">Nombre del acompañante</p>
                                                            <div style="text-align: left"></div>
                                                            <div class="input-group">
                                                                <asp:TextBox ID="txtNombreAcompanante" runat="server" class="form-control" MaxLength="150" />
                                                                <span class="input-group-addon">&nbsp&nbsp</span>
                                                                <asp:Button ID="btnGuardarAcompanantes" runat="server" Text="Agregar" OnClick="btnGuardarAcompanantes_Click" class="btn btn06 btn-primary" />
                                                            </div>
                                                            <br />
                                                            <p id="Acompa" runat="server" class="big02">Acompañantes</p>
                                                            <div style="text-align: left"></div>

                                                            <asp:Repeater ID="Repeater1" runat="server">
                                                                <ItemTemplate>
                                                                    <div style="text-align: left; border-bottom: 1px solid">
                                                                        <div class="input-group" style="margin-top: 0.4em;">
                                                                            <div class="col-sm-8">

                                                                                <p><%#Eval("NombreInvitado").ToString().Trim() %></p>
                                                                            </div>
                                                                            <div class="col-sm-2" style="visibility: hidden">
                                                                                <p><%#Eval("id_Invitado").ToString().Trim() %></p>
                                                                            </div>
                                                                            <div class="col-sm-2">
                                                                                <asp:LinkButton ID="btnEliminarAcompanante" CommandArgument='<%#Eval("id_Invitado")%>' runat="server" Text="Eliminar" CssClass="btn07" OnClick="btnEliminarAcompanante_Click" />
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                        </div>
                                                    </div>
                                                </ContentTemplate>
                                            </asp:UpdatePanel>
                                        </div>
                                    </div>
                                </div>
                                <!--AGENDA ACTIVIDAD-->
                                <div class="tab-pane fade" id="nav-content-agenda" role="tabpanel" aria-labelledby="nav-profile-tab">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                            <!--Nuevo-->
                                            <div class="container">
                                                <%--<p class="titulocontenedor"><u>Agenda</u></p>--%>
                                            </div>
                                            <div class="scrollbar-black" style="text-align: center; overflow-y: scroll; height: 22em;">
                                                <div class="col-sm-12">
                                                    <div id="S05" runat="server" class="alert alert-success " visible="false">
                                                        <strong>Cambios realizados</strong>
                                                    </div>
                                                    <div id="D05" runat="server" class="alert alert-warning" visible="false">
                                                        <strong>No se pudieron hacer los cambios!</strong>
                                                    </div>
                                                    <div class="col-md-12 content-fluid nopadding nomargin" style="display: inline-block; text-align: left;">
                                                        <div class="col-md-9">
                                                            <p id="Inforacion" runat="server" class="big_02" style="text-align: left;">A continuación seleccione las actividades a las que asistirá </p>
                                                            <br />
                                                        </div>
                                                        <div class="col-md-3 right" style="margin-top: -0.34em;">
                                                            <%-- <asp:CheckBox ID="chDesInscripEvento" ClientIDMode="Static" onclick="desactivarcheckbox()" class="big_02 container1" Text="Descargar Todo" TextAlign="Left" runat="server"/>--%>
                                                        </div>

                                                    </div>
                                                    <div class="panel-body scrollbar-black" runat="server" style="height: 100%; max-height: 430px;">
                                                        <asp:Repeater ID="ParentRepeater" runat="server" OnItemDataBound="ItemBound">
                                                            <ItemTemplate>
                                                                <div class="navbar" style="background-color: #0A435E; color: whitesmoke;">
                                                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("CabeceraFecha").ToString() %>'></asp:Label>

                                                                </div>


                                                                <asp:Repeater ID="ChildRepeater" runat="server">
                                                                    <HeaderTemplate>
                                                                        <table class="table table-responsive-sm ">
                                                                    </HeaderTemplate>
                                                                    <ItemTemplate>
                                                                        <tr class="colorline">
                                                                            <th style="width: 12%">
                                                                                <div style="display: inline-block;">
                                                                                    <p class="nomargin" style="font-size: 13px; font-weight: normal; color: #0B425F;"><%# EventosBCRPFrontEnd.Functions.clGetSplitIndex.Read(Eval("DuracionActividad").ToString(), "\\n\\r", 0) %></p>
                                                                                    <p class="nomargin" style="font-size: 13px; font-weight: normal; color: #0B425F;"><%# EventosBCRPFrontEnd.Functions.clGetSplitIndex.Read(Eval("DuracionActividad").ToString(), "\\n\\r", 2) %></p>
                                                                                </div>
                                                                            </th>
                                                                            <th>
                                                                                <div class="ellipsis big03">
                                                                                    <%#Eval("DetalleActividad").ToString() %>
                                                                                </div>
                                                                            </th>
                                                                            <th style="width: 12%">
                                                                                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%#Eval("ConfirmaActividad") %>' />
                                                                                <asp:HiddenField ID="IdActividad" runat="server" Value='<%#Eval("id_Actividad").ToString() %>' />
                                                                            </th>
                                                                        </tr>
                                                                    </ItemTemplate>
                                                                    <FooterTemplate>
                                                                        </table>
                                                                    </FooterTemplate>
                                                                </asp:Repeater>

                                                            </ItemTemplate>
                                                        </asp:Repeater>
                                                    </div>

                                                </div>
                                                <br />
                                                <br />

                                            </div>
                                            <!--Atiguo-->
                                            <div class="col-lg-12">
                                                <asp:Button ID="btnGuardarAgendaActividad" CssClass="btn btn05" runat="server" Text="Guardar" OnClick="btnGuardarAgendaActividad_Click" />
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                                <!--INFORMACION ADICIONAL-->
                                <div class="tab-pane fade" id="nav-content-adicional" role="tabpanel" aria-labelledby="nav-contact-tab">
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            <div class="row onlypadding-25 scrollbar-black" style="margin-right: 0; margin-left: 0; overflow-y: scroll; height: 27em; text-align: left; background-color: #F7F7F7">

                                                <div id="SeccionVerde" runat="server" class="alert alert-success" visible="false">
                                                    <strong>Cambios realizados</strong>
                                                </div>
                                                <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                                                    <strong>No se pudieron ahcer los cambios!</strong>
                                                </div>

                                                <%--<p class="col-sm-12 big_02">Esta información servirá para su ID</p>--%>
                                                <div class="col-sm-3 center" style="background-color: #F7F7F7">
                                                    <img id="Image4" class="image_05" runat="server" alt="imagen 05" onerror="this.onload = null; this.src='../../Images/Pdefault.jpeg';" />
                                                    <input type="text" id="_ImagenFotoName" runat="server" hidden />
                                                    <input type="text" id="_ImagenFoto64" runat="server" hidden />
                                                    <%--<asp:Image ID="Image4" CssClass="image_05" runat="server" alt="imagen 05" src="../../Images/Pdefault.jpeg" />--%>
                                                    <br />
                                                    <asp:LinkButton ID="btnEliminar" CssClass="big02 right" runat="server">Eliminar</asp:LinkButton>
                                                    <br />
                                                </div>

                                                <%-- <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                    <ContentTemplate>--%>
                                                <div class="col-sm-9" style="text-align: left; background-color: #F7F7F7">
                       
                                                    <input id="_UpFoto" type="file" runat="server" name="oFile" class="btn btn-primary" onchange="javascript:upFoto(this);" />

                                                    <p id="Apodo" class="big_02" style="margin-top: 1rem;" runat="server">Indicar nombre que desea que aparezca en su fotocheck</p>
                                                    <asp:TextBox ID="txtApodo" CssClass="form-control" runat="server" Width="60%"></asp:TextBox>
                                                </div>
                                                <%--     </ContentTemplate>
                                                </asp:UpdatePanel>--%>
                                                <div class="col-sm-6" style="text-align: left; background-color: #F7F7F7">
                                                    <strong id="InformacionVuelo" class="big02" style="text-decoration: underline;" runat="server"><u>Información de vuelo</u></strong>
                                                    <%--<div style="padding: 10px"></div>--%>
                                                    <p id="Llegada" runat="server" class="big_02 onlymargintop-10">Llegada</p>
                                                    <p id="AerolineaVuelo" class="big_02 onlymargintop-10" runat="server">
                                                        Airline / Fligth number<br />
                                                    </p>
                                                    <div class="row">
                                                        <div class="col-sm-6 " style="text-align: left; background-color: #F7F7F7;">

                                                            <asp:TextBox ID="txtVuelo" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                                                        </div>
                                                        <div class="col-sm-6 " style="text-align: left; background-color: #F7F7F7;">
                                                            <asp:TextBox ID="txtCodigoVuelo" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <br />
                                                    <div class="row">
                                                        <div class="col-sm-6">
                                                            <p id="Dia" runat="server" class="big_02 onlymargintop-10">Fecha</p>
                                                        </div>

                                                        <div class="col-sm-6">
                                                            <p id="Hora" runat="server" class="big_02 onlymargintop-10">Hora</p>
                                                        </div>

                                                    </div>

                                                    <div class="row">
                                                        <div class="col-sm-6">
                                                            <%--      <div class="form-group">
                                                                <label class="big2">Desde</label><br />
                                                                <div class="input-group date _Fecha" id="FechaHotelDesde" data-target-input="nearest">
                                                                    
                                                                    <input type="text" id="txtLlegadaFecha" runat="server" class="form-control datetimepicker-input" data-target="#Day" onkeypress="return false;" />
                                                                    <input type="text" id="txtFechaHotelHasta" class="form-control datetimepicker-input" data-target="#Day" onkeypress="return false;" />
                                                                    <div class="input-group-append" data-target="#FechaHotelDesde" data-toggle="datetimepicker">
                                                                        <div class="input-group-text"><i class="fa fa-calendar"></i></div>
                                                                    </div>
                                                                </div>
                                                            </div>--%>
                                                            <asp:TextBox ID="txtLlegadaFecha" CssClass="form-control" runat="server" Width="100%" />

                                                        </div>

                                                        <div class="col-sm-6">
                                                            <asp:TextBox ID="txtLlegadaHora" CssClass="form-control" runat="server" Width="100%" />

                                                        </div>
                                                    </div>


                                                    <p id="SalidaVuelo" runat="server" class="big_02 onlymargintop-10">Salida</p>
                                                    <p id="Salida" class="big_02 onlymargintop-10" runat="server">
                                                        Airline / Fligth number<br />

                                                    </p>
                                                    <div class="row">
                                                        <div class="col-sm-6 " style="text-align: left; background-color: #F7F7F7;">
                                                            <asp:TextBox ID="txtVuelo1" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                                                        </div>
                                                        <div class="col-sm-6 " style="text-align: left; background-color: #F7F7F7;">
                                                            <asp:TextBox ID="txtCodigoVuelo1" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <%--<asp:TextBox ID="txtVuelo1" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>--%>
                                                    <div class="row">
                                                        <div class="col-sm-6">
                                                            <p id="Dia2" runat="server" class="big_02 onlymargintop-10">Fecha</p>
                                                        </div>
                                                        <div class="col-sm-6">
                                                            <p id="Hora2" runat="server" class="big_02 onlymargintop-10">Hora</p>
                                                        </div>
                                                    </div>

                                                    <div class="row">
                                                        <div class="col-sm-6">
                                                            <asp:TextBox ID="txtSalidaFecha" CssClass="form-control" runat="server" Width="100%" />
                                                        </div>
                                                        <div class="col-sm-6">
                                                            <asp:TextBox ID="txtSalidaHora" CssClass="form-control" runat="server" Width="100%" />
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="col-sm-6" style="text-align: left; background-color: #F7F7F7">
                                                    <strong id="InformacionHospedaje" class="big02" style="text-decoration: underline" runat="server"><u>Información de hospedaje</u></strong>

                                                    <div style="padding: 10px"></div>
                                                    <p id="Hotel" runat="server" class="big_02 onlymargintop-10">Hotel</p>
                                                    <asp:TextBox  ID="txtHospedajeNombre" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>

<%--                                                    <form autocomplete="off" action="/action_page.php">
                                                        <div class="autocomplete" style="width: 300px;">
                                                            <input value="Hotel Sheraton" id="myInput" class="form-control" style="border: solid 1px #ced4da; border-radius: 0.25rem; color: #495057;" type="text" name="myCountry" placeholder="">
                                                        </div> 
                                                    </form>--%>

                                                    <p id="P3" runat="server" class="big_02 onlymargintop-10">Direccion</p>
                                                    <asp:TextBox ID="txtDireccionHotel" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>

                                                    <div class="row" style="margin-left: 1px;">
                                                        <div class="col-lg-6">
                                                            <p id="Desde" runat="server" class="big_02 onlymargintop-10">Desde</p>
                                                            <asp:TextBox ID="txtHospedajeLlegadaFecha" CssClass="form-control" runat="server" Width="100%" />
                                                        </div>
                                                        <div class="col-lg-6">
                                                            <p id="Hasta" runat="server" class="big_02 onlymargintop-10">Hasta</p>
                                                            <asp:TextBox ID="txtHosopedajeSalidaFecha" CssClass="form-control" runat="server" Width="100%" />
                                                        </div>
                                                    </div>
                                                    <%-- <div style="height: 10px; text-align: left"></div>--%>
                                                    <input id="txtLong" runat="server" width="100%" hidden />
                                                    <input id="txtAlti" runat="server" width="100%" hidden />
                                                    <!--MAPA FREE STREET VIEW -->
                                                    <%--<div id="mapdiv"></div>--%>

                                                    <div id="map" class="map map-home" style="margin: 12px 0 12px 0; height: 280px;"></div>
                                                    <asp:HiddenField ID ="_ListaHotel" runat="server" />
                                                    
                                                </div>
                                                <%--<div id="map" class="map map-home" style="margin: 12px 0 12px 0; height: 480px; height:280%"></div>--%>
                                                <div class="col-lg-12" style="text-align: center; padding: 2%; background-color: #F7F7F7">
                                                    <asp:Button ID="btnGuardarInformacionAdicional" runat="server" Text="Guardar" OnClick="btnGuardarInformacionAdicional_Click" class="btn btn05 btn-primary" />
                                                </div>

                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </div>
                            </div>
                        </div>
                        <!--CONTENIDO2-DELEGAR-->
                        <!--aqui miguel-->
                        <div id="contenido2" class="col-md-9 row scrollbar-black nomargin nopadding onlypadding-25" style="overflow-y: scroll; height: 27em; background-color: #f7f7f7;">

                            <asp:UpdatePanel ID="UpdatePanelDelegar" class="col-md-12" runat="server">
                                <ContentTemplate>

                                    <div class="container">
                                        <div id="Div1" runat="server" class="alert alert-success" visible="false">
                                            <strong>Cambios realizados</strong>
                                        </div>
                                        <div id="Div2" runat="server" class="alert alert-warning" visible="false">
                                            <strong>No se pudieron ahcer los cambios!</strong>
                                        </div>
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <h4 id="delegarPartDl" runat="server" class="modal-title">Delegar Participacion</h4>
                                            </div>

                                            <div class="col-sm-12 right" style="position: absolute; z-index: 9999;">
                                                <a id="btnsalir1" style="color: #fff; background-color: #007bff; border-color: #007bff;" class="btn btn-success" data-toggle="button" aria-pressed="false" autocomplete="off">X</a>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-sm-6 left">
                                                <p id="nombreDl" runat="server" class="big02 nomargin onlymargintop-10">Nombre</p>
                                                <asp:TextBox ID="txtNombreDl" class="form-control" runat="server" />
                                                <p id="apellidoPaternoDl" class="big02 nomargin onlymargintop-10" runat="server">Apellidos Paterno:</p>
                                                <asp:TextBox ID="txtApellidoPaternoDl" class="form-control" runat="server" />
                                                <p id="apellidoMaternoDl" class="big02 nomargin onlymargintop-10" runat="server">Apellidos Materno:</p>
                                                <asp:TextBox ID="txtApellidoMaternoDl" class="form-control" runat="server" />
                                                <p id="organizacionDl" class="big02 nomargin onlymargintop-10" runat="server">Organizacion:</p>
                                                <asp:TextBox ID="txtOrganizacionDl" class="form-control" runat="server" />
                                            </div>
                                            <div class="col-sm-6 left">
                                                <p id="puestoDl" class="big02 nomargin onlymargintop-10" runat="server">Puesto:</p>
                                                <asp:TextBox ID="txtPuestoDl" class="form-control" runat="server" />
                                                <p id="numeroDocumentoMdl" class="big02 nomargin onlymargintop-10" runat="server">Numero documento:</p>
                                                <asp:TextBox ID="txtNumeroDocumentoDl" class="form-control" runat="server" />
                                                <p id="tipoDocumentoDl" class="big02 nomargin onlymargintop-10" runat="server">Tipo Documento</p>
                                                <asp:DropDownList ID="dplTipoDocumentoDl" runat="server" DataTextField="NombeTipoDocumento" DataValueField="id_TipoDocumento" AutoPostBack="true" class="btn btn003 btn-secondary dropdown-toggle" BackColor="#0A445B" />
                                                <p id="correoMdl" class="big02 nomargin onlymargintop-10" runat="server">Correo</p>
                                                <asp:TextBox ID="txtCorreoDl" class="form-control" runat="server" />
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <br />
                                                <asp:LinkButton ID="btnEnviarDl" runat="server" type="button" class="btn btn05" OnClick="btnEnviarMdl_Click">Guardar</asp:LinkButton>
                                            </div>
                                        </div>

                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--    </form>
</body>
</html>--%>

    <script>
        //$(window).resize(function () {
        //    var mainwidth = $(window).width();
        //    var mainheight = $(window).height();
        //    var max = $('#panel_evento2').height();
        //    alert(max);
        //    //var width = $('#nav-content-adicional').width(mainwidth);
        //    var max1 = $('#panel_evento3').height(max);
        //    alert(max1);
        //    $('#ContentPlaceHolder1_panel_evento4').height(max);

        //});

        var CargarImageEvento = function (file) {
            var reader = new FileReader;
            var image = new Image;
            reader.readAsDataURL(file);
            reader.onload = function (_file) {
                image.src = _file.target.result;

                $('#ContentPlaceHolder1__ImagenFotoName').val(file.name);
                $('#ContentPlaceHolder1__ImagenFoto64').val(_file.target.result);
                $('#ContentPlaceHolder1_Image4').attr('src', _file.target.result);
                //$('#ContentPlaceHolder1_imgParticipante').attr('src', _file.target.result);
                $('#FotoEvento').val(file.name);
            }
        }
        function upFoto(con) {
            var File = con.files;
            if (File && File[0]) {
                CargarImageEvento(File[0]);
            }
        }
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
            //EVENTO SE DESENCADENA CUANDO SE CAMBIA EL VALOR EN EL CAMPO DE NOMBRE DE HOTEL
            $('#myInput').change(function () {
                MostrarUbicacion();
            });
        });

        function MapaFreeStreet(x, y, name) {
            var osmUrl = 'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
            osmAttrib = '',
            osm = L.tileLayer(osmUrl, { maxZoom: 18, attribution: osmAttrib });
            var map = L.map('map').setView([x, y], 13).addLayer(osm);
            //L.marker([-12.0572872, -77.0370224])
            L.marker([x, y])
            .addTo(map)
            .bindPopup(name)
                .openPopup();

            //var map = L.map('map', {
            //    center: [-12.0572872, -77.0370224],
            //    zoom: 6
            //});

            //L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            //    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
            //}).addTo(map);

            //L.marker([x, y]).addTo(map)
            //    .bindPopup(name)
            //    .openPopup();
             //L.marker([-12.0572872, -77.0370224]).addTo(map)
             //   .bindPopup(name)
             //   .openPopup();
        }

        function MostrarUbicacion() {
            //alert($('#ContentPlaceHolder1_txtAlti').val());
            var Long = $('#ContentPlaceHolder1_txtLong').val() == '' ? -12.0572872 : $('#ContentPlaceHolder1_txtLong').val();
            //alert(Long);
            var Alti = $('#ContentPlaceHolder1_txtAlti').val() == '' ? -77.0370224 : $('#ContentPlaceHolder1_txtAlti').val();
            var nameHotel = $('#ContentPlaceHolder1_txtHospedajeNombre').val();
            //alert(Long + '   ' + Alti);
            MapaFreeStreet(Long, Alti, nameHotel);
        }

    </script>



    <%------Mapa OSM------%>

    <script>


</script>
    <%------ FIN Mapa OSM------%>
    <%------------- Script autocomplete-------------%>
    <%--<script>
        function autocomplete(inp, arr) {
            /*the autocomplete function takes two arguments,
            the text field element and an array of possible autocompleted values:*/
            var currentFocus;
            /*execute a function when someone writes in the text field:*/
            inp.addEventListener("input", function (e) {
                var a, b, i, val = this.value;
                /*close any already open lists of autocompleted values*/
                closeAllLists();
                if (!val) { return false; }
                currentFocus = -1;
                /*create a DIV element that will contain the items (values):*/
                a = document.createElement("DIV");
                a.setAttribute("id", this.id + "autocomplete-list");
                a.setAttribute("class", "autocomplete-items");
                /*append the DIV element as a child of the autocomplete container:*/
                this.parentNode.appendChild(a);
                /*for each item in the array...*/
                for (i = 0; i < arr.length; i++) {
                    /*check if the item starts with the same letters as the text field value:*/
                    if (arr[i].substr(0, val.length).toUpperCase() == val.toUpperCase()) {
                        /*create a DIV element for each matching element:*/
                        b = document.createElement("DIV");
                        /*make the matching letters bold:*/
                        b.innerHTML = "<strong>" + arr[i].substr(0, val.length) + "</strong>";
                        b.innerHTML += arr[i].substr(val.length);
                        /*insert a input field that will hold the current array item's value:*/
                        b.innerHTML += "<input type='hidden' value='" + arr[i] + "'>";
                        /*execute a function when someone clicks on the item value (DIV element):*/
                        b.addEventListener("click", function (e) {
                            /*insert the value for the autocomplete text field:*/
                            inp.value = this.getElementsByTagName("input")[0].value;
                            /*close the list of autocompleted values,
                            (or any other open lists of autocompleted values:*/
                            closeAllLists();
                        });
                        a.appendChild(b);
                    }
                }
            });
            /*execute a function presses a key on the keyboard:*/
            inp.addEventListener("keydown", function (e) {
                var x = document.getElementById(this.id + "autocomplete-list");
                if (x) x = x.getElementsByTagName("div");
                if (e.keyCode == 40) {
                    /*If the arrow DOWN key is pressed,
                    increase the currentFocus variable:*/
                    currentFocus++;
                    /*and and make the current item more visible:*/
                    addActive(x);
                } else if (e.keyCode == 38) { //up
                    /*If the arrow UP key is pressed,
                    decrease the currentFocus variable:*/
                    currentFocus--;
                    /*and and make the current item more visible:*/
                    addActive(x);
                } else if (e.keyCode == 13) {
                    /*If the ENTER key is pressed, prevent the form from being submitted,*/
                    e.preventDefault();
                    if (currentFocus > -1) {
                        /*and simulate a click on the "active" item:*/
                        if (x) x[currentFocus].click();
                    }
                }
            });
            function addActive(x) {
                /*a function to classify an item as "active":*/
                if (!x) return false;
                /*start by removing the "active" class on all items:*/
                removeActive(x);
                if (currentFocus >= x.length) currentFocus = 0;
                if (currentFocus < 0) currentFocus = (x.length - 1);
                /*add class "autocomplete-active":*/
                x[currentFocus].classList.add("autocomplete-active");
            }
            function removeActive(x) {
                /*a function to remove the "active" class from all autocomplete items:*/
                for (var i = 0; i < x.length; i++) {
                    x[i].classList.remove("autocomplete-active");
                }
            }
            function closeAllLists(elmnt) {
                /*close all autocomplete lists in the document,
                except the one passed as an argument:*/
                var x = document.getElementsByClassName("autocomplete-items");
                for (var i = 0; i < x.length; i++) {
                    if (elmnt != x[i] && elmnt != inp) {
                        x[i].parentNode.removeChild(x[i]);
                    }
                }
            }
            /*execute a function when someone clicks in the document:*/
            document.addEventListener("click", function (e) {
                closeAllLists(e.target);
            });
        }

        /*An array containing all the country names in the world:*/
        var countries = ["Hotel Sheraton", "Hotel Westin", "Hotel Urubamba"];

        /*initiate the autocomplete function on the "myInput" element, and pass along the countries array as possible autocomplete values:*/
        autocomplete(document.getElementById("myInput"), countries);
    </script>--%>

    <%----------------------------------------------
    ------------ Validation!!-------------------
    ----------------------------------------------%>

    <%--<script type="text/javascript">
        function WebForm_OnSubmit() {
            if (typeof (ValidatorOnSubmit) == "function" && ValidatorOnSubmit() == false) {
                for (var i in Page_Validators) {
                    try {
                        var control = document.getElementById(Page_Validators[i].controltovalidate);
                        if (!Page_Validators[i].isvalid) {
                            control.className = "form-control-Error";

                        } else {

                            control.className = "form-control";
                        }

                    } catch (e) { }

                }
                return false;
            }
            return true;
        }
    </script>--%>

    <%----------------------------------------------
    ------------ Validation!!-------------------
    ----------------------------------------------%>
    <script>

        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode < 35 || charCode > 57))
                return false;
            return true;
        }

        function ValidateEmail(txtCorreoEmergencia) {
            var expr = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
            return expr.test(txtCorreoEmergencia);
        }
        ;

        $("#btnsalir1").click(function () {
            $("#txtNombreDl").hide();
            $("#contenido1").show();
            $("#ContentPlaceHolder1_navinfogeneral").show();
            $("#ContentPlaceHolder1_navagenda").show();
            $("#ContentPlaceHolder1_navadicional").show();
        });


    </script>


    <link rel="stylesheet" href="https://unpkg.com/leaflet@1.0.3/dist/leaflet.css">
</asp:Content>


