<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListaEventos.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.ListaEventos" %>

<asp:Content ID="BodyPage" ContentPlaceHolderID="MainContent" runat="server">


    <style>
        .right {
            text-align: right !important;
        }

        .left, .text-sm-left {
            text-align: left !important;
        }

        .center {
            text-align: center !important;
        }

        .titulocontenedor > u {
            color: #0A435E;
        }

        .big2 {
            color: #0B425F;
            font-weight: 700;
            font-size: 13px !important;
        }


        .navbar-light .navbar-nav .nav-link:focus, .navbar-light .navbar-nav .nav-link:hover {
            opacity: 0.7;
            color: #f9f9f9 !important;
        }

        .navbar-light .navbar-nav .nav-link {
            color: #f9f9f9;
            font-size: 14px;
        }

        .flecha_01 {
            float: right;
            margin-top: -1.2em;
        }

          .scrollbar-black {
        height: calc(100vh - 180px) !important;
        max-height: 100% !important
    }

        @media (max-width: 1199px) {

            .space1 {
                margin-top: 1em;
            }

            .center_image {
                text-align: center;
            }

            .float1 {
                width: 100%;
            }
        }


        @media (min-width: 1200px) {

            .float1 {
                float: left;
                width: 50%;
            }
        }

@media (max-width: 320px) {
    .scrollbar-black {
        height: calc(100vh - 230px) !important;
        max-height: 100% !important
    }
}
    </style>

    <div class="container contenedoreventos">

        <div class="container">
            <p id="tituloEvento" runat="server" class="titulocontenedor"><u>Eventos invitado</u></p>
            <p id="textoevento" runat="server" class="text-sm-left">Porfavor selescione el evento de su interes</p>
        </div>

        <div class="panel-body scrollbar-black" runat="server" style="overflow-y: scroll; height: 100%; max-height: 450px;">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="col-sm-6 float-left">
                        <div class="table table-responsive-sm col-sm-6 float-left space_02" id="sidebar" style="background-color: #F7F7F7; border-radius: 10px; margin-bottom: 10px; margin-right: 0px; padding-right: 13px; width: 100%; max-height: fit-content;">
                            <table class="table" style="/* border-radius: 10px; */padding-left: 0px; padding-right: 0px; /* padding-top: 30px; */margin-top: 10px; background-color: transparent;">
                                <tbody>
                                    <tr>
                                        <td style="text-align: left;">
                                            <%--<img src="<%# EventosBCRPFrontEnd.Functions.clGetFileFTP.ReadImage(Eval("FotoEvento").ToString()) %>" />--%>

                                            <div class="float1 center_image">

                                                <img src="<%# EventosBCRPFrontEnd.Functions.clGetRepositorio.Read(Eval("FotoEvento").ToString()) %>" style="max-width: 170px; height: 220px; border-radius: 10px;" />

                                            </div>

                                            <div class="float1 space1">
                                                <div class="big2 space_01">
                                                    <p><%#Eval("NombreEvento").ToString().Trim() %></p>
                                                </div>
                                                <div class="ellipsis" style="font-size: 13px">
                                                    <p><%#Eval("DescripcionEvento").ToString().Trim() %></p>
                                                </div>
                                                <p style="margin-bottom: 0.5rem;"><%#Eval("LugarEvento").ToString().Trim() %></p>

                                                <div class="container-fluid nopadding">
                                                    <div>
                                                        <div class="container-fluid nopadding" style="float: left">
                                                            <%--<div class="col-sm-3">--%>
                                                            <span class="glyphicon glyphicon-calendar" style="display: inline-block; font-size: 30px;"></span>
                                                            <%--</div>--%>
                                                            <div style="display: inline-block;">
                                                                <p class="nomargin" style="font-weight: 700; font-size: 12px;"><%#DateTime.Parse(Eval("FechaInicioEvento").ToString()).ToString("dd/MM/yyyy H:mm")%></p>
                                                                <p class="nomargin" style="font-size: 12px;"><%#DateTime.Parse(Eval("FechaFinEvento").ToString()).ToString("dd/MM/yyyy H:mm")%></p>
                                                            </div>
                                                            <div class="flecha_01">
                                                                <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("id_Participante").ToString()%>' />
                                                                <asp:HiddenField ID="HiddenField2" runat="server" Value='<%#Eval("LinkHomeEvento").ToString()%>' />
                                                              <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Button_Click"><span class="glyphicon glyphicon-menu-right" aria-hidden="true" style="color: #f54d0a; display: inline-block; font-size: 15px; border: 1px solid #f54d0a; border-radius: 2em; padding: 5px 4px 5px 6px;"></span></asp:LinkButton>
                                                                <br />
                                                                <%--<p><a href="<%#Eval("LinkHomeEvento").ToString().Trim()%>"><span class="glyphicon glyphicon-menu-right" aria-hidden="true" style="color: #f54d0a; display: inline-block; font-size: 15px; border: 1px solid #f54d0a; border-radius: 2em; padding: 5px 4px 5px 6px;"></span></a></p>--%>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </td>

                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
