<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Principal/MasterEvento.Master" AutoEventWireup="true" CodeBehind="HomeEvento.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Evento.HomeEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        @media (min-width: 1279px) {
            .imagen_05 {
                background-position-y: 50% !important;
            }
        }

     .container-fluid{
        position: fixed !important;
    }

        .imagen_05 {
            background-repeat: no-repeat;
            background-size: cover;
            width: 100% !important;
            height: 100% !important;
        }

        .space05 {
            margin-top: 11.5em;
            color: #fff;
        }


        @media (max-width: 768px) {
            .space05 {
                margin-top: 7.5em;
            }
        }
    </style>
    <div id="backgroundprincipal" runat="server" class="panel-body scrollbar-black nomargin imagen_05">
      <div class="space05">
            <h2 id="txtTitulo" style="font-weight: 600; margin-left: 20%; margin-right: 20%; text-shadow: black 0.1em 0.1em 0.2em;" runat="server"></h2>
            <h3 id="txtDireccion" style="font-weight: 600; text-shadow: black 0.1em 0.1em 0.2em" runat="server"></h3>
            <p id="txtFecha" style="font-weight: 500; text-shadow: black 0.1em 0.1em 0.2em" runat="server"></p>
        </div>
    </div>
</asp:Content>

