<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Principal/MasterEvento.Master" AutoEventWireup="true" CodeBehind="ExpositoresParticipanteEvento.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Evento.ExpositoresParticipanteEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--CONTENIDO DE FOTO | IZQUIERDO-->
    <div class="col-sm-3 barimage contentindex" style="background: url('/Images/Ima01.png') no-repeat; background-size: cover;"></div>
    <!--CONTENIDO DERECHO FORMULARIOS-->
    <div class="col-sm-9 contentindex" id="panel_evento2">
        <style>
            .img_participante {
                width: 100px;
                height: 100px;
                border-radius: 10px;
            }

            .img_expositor {
                width: 100px;
                height: 100px;
                border-radius: 5px;
            }

            .aspNetDisabled {
                display: inline-block;
                font-weight: 400;
                text-align: center;
                white-space: nowrap;
                vertical-align: middle;
                -webkit-user-select: none;
                -moz-user-select: none;
                -ms-user-select: none;
                user-select: none;
                border: 1px solid transparent;
                padding: 0.375rem 0.75rem;
                font-size: 1rem;
                line-height: 1.25;
                border-radius: 0.25rem;
                transition: color 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
                color: #0a435e !important;
                background-color: #ffffff !important;
                border-color: #0a435e !important;
            }

            .texto2 {
                FONT-SIZE: 12PX;
                color: #F3401A;
                /*font-weight: bold;*/
                line-height: 1.1;
            }

            .texto1 {
                FONT-SIZE: 13PX;
                color: #316e8d;
                font-weight: 400;
                line-height: 1.1;
            }

            .texto1a {
                FONT-SIZE: 13PX;
                color: #316e8d;
                font-weight: 650;
                line-height: 1.1;
                /*font-weight: bold;*/
            }


            .tabla_participante {
                width: 12em;
                height: 9.2em;
                margin: 1em 0;
            }

            td {
                width: 13em;
                height: 13em;
                line-height: 1.1;
            }
        </style>
        <div class="container">
            <p id="tituloExpoPart" runat="server" class="titulocontenedor"><u>Expositores y Participantes</u></p>
        </div>
        <div class="row" style="text-align: center; padding: 20px">
            
            <asp:Button ID="btnExpositores" runat="server" Text="Expositores" class="btn btn-primary1" OnClick="btnExpositores_Click" Width="250px" />
             &nbsp; &nbsp;
            <asp:Button ID="btnParticipantes" runat="server" Text="Participantes" class="btn btn-primary1" OnClick="btnParticipantes_Click" Width="250px" />       
        </div>
        <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
            <strong>Cambios realizados!</strong>
        </div>
        <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
            <strong>No se pudieron ahcer los cambios!</strong>
        </div>
        <div class="row scrollbar-black" style="-webkit-padding-after: 20px; overflow-y: scroll; text-align: center; height: 27em;">

            <div class="col-sm-3" style="color: #004085;">
                <asp:Label ID="txtParticiante1" runat="server"></asp:Label>
            </div>
            <div class="col-sm-3" style="color: #004085;">
                <asp:Label ID="txtParticiante2" runat="server"></asp:Label>
            </div>
            <div class="col-sm-3" style="color: #004085;">
                <asp:Label ID="txtParticiante3" runat="server"></asp:Label>
            </div>
            <div class="col-sm-3" style="color: #004085;">
                <asp:Label ID="txtParticiante4" runat="server"></asp:Label>
            </div>

        </div>
        <div class="row scrollbar-black" style="padding: 50px; text-align: center">
            <br />
        </div>
    </div>

</asp:Content>
