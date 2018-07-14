<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PantallaApp.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.PantallaApp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .barimage {
            display: none !important;
        }

        .col-sm-9 {
            flex: 0 0 100%;
            max-width: 100%;
            padding-right: 0px !important;
            padding-left: 0px !important;
        }

        .contenido01 {
            margin-left: 5em;
            margin-right: 5em;
            margin-top: 2.5em;
            font-size: 13px;
        }

        .center {
            text-align: center;
        }

        .head1 {
            margin-top: 1.2em;
            text-align: center;
            font-size: 5em;
            opacity: 0.2;
        }

        .center {
            text-align: center !important;
        }

        .row {
            margin-right: 0px;
            margin-left: 0px;
        }

        @media (min-width: 576px) {
            .col-ms-9 {
                padding-right: 0px !important;
                padding-left: 0px !important;
            }
        }
    </style>
    <div class="container-fluid nopadding nomargin" style="height: 100%; width: 100%;">
        <div class="row nomargin nopadding" style="height: 55%; text-align: center; background: #ddd">
            <div class="col-md-12 center">
                <p class="head1">APP</p>
            </div>
        </div>
        <div class="row nomargin nopadding" style="height: 45%;">
            <div class="contenido01 center">
                <p>
                    <b>Lorem Ipsum es simplemente el texto de relleno de las inprentas y archivos de texto</b>

                </p>
                <p class="center">
                    Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                 Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                 when an unknown printer took a galley of type and scrambled it to make a type specimen book. 
                It has survived not only five centuries, but also the leap into electronic typesetting,
                 remaining essentially unchanged. It was popularised in the 1960s with the release of
                 Letraset sheets containing Lorem Ipsum passages,
                 and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum
                </p>

            </div>
        </div>
    </div>
</asp:Content>
