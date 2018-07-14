<%@ Page Title="" Language="C#" MasterPageFile="~/Inscripcion.Master" AutoEventWireup="true" CodeBehind="informacionAdicional.aspx.cs" Inherits="CapaPresentacion.informacionAdicional" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">

<%--    <style>
        p{
            color:#08455C;
            margin-bottom:0;
            font-weight:600;
        }
        strong{
            color:#08455C;
        }
    </style>--%>
<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
<div style="background-color: #F7F7F7; text-align:left">
    <p style="margin-bottom:0px !important">Esta informacion servirá para su ID</p>
    <br />
</div>
    
        <div class="row scrollbar-black" style="overflow-y: scroll; height: 360px; text-align: left; background-color: #F7F7F7">
           
            <div id="SeccionVerde" runat="server" class="alert alert-success" visible="false">
                <strong>Cambios realizados!</strong>
            </div>
            <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                <strong>No se pudieron ahcer los cambios!</strong>
            </div>
            <div class="col-sm-4" style="background-color: #F7F7F7">
                <asp:Image ID="imgParticipante" runat="server" alt="Cinque Terre" />
                <br />
                <asp:LinkButton ID="btnEliminar" runat="server">Elimnar</asp:LinkButton>
                <br />
                <br />
            </div>

            <div class="col-sm-8" style="text-align: left; background-color: #F7F7F7">
                <asp:Button ID="subirFoto" runat="server" Text="Subir Foto" BackColor="#0A445B" class="btn btn-primary"/><br /><br />
                <p>Apodo</p><br />
                <asp:TextBox ID="txtApodo" runat="server" Width="80%"></asp:TextBox>
            </div>


            <div class="col-sm-6" style="text-align: left; background-color: #F7F7F7"">
                <div style="padding:20px"></div>
                 <strong><u>Información de vuelo</u></strong>
                <div style="padding:10px"></div>
                
                <p>Airline / Fligth number</p>
                <asp:TextBox ID="txtVuelo" runat="server" Width="100%"></asp:TextBox>
                <br />
                <br />
                <p>Llegada</p>
                <div class="row">
                    <div class="col-sm-6"><p>Fecha</p></div>
                    <div style="height: 10px; text-align: left"></div>
                    <div class="col-sm-6"><p>Hora</p></div>
                    <div style="height: 10px; text-align: left"></div>
                </div>
                <div style="height: 10px; text-align: left"></div>
                <div class="row">
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtLlegadaFecha" runat="server" Width="100%"/>
                        &nbsp&nbsp&nbsp&nbsp
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtLlegadaHora" runat="server" Width="100%"/>
                        &nbsp&nbsp&nbsp&nbsp
                    </div>
                </div>

                <br />
                <p>Salida</p>
                <div class="row">
                    <div class="col-sm-6"><p>Fecha</p></div>
                    <div class="col-sm-6"><p>Hora</p></div>
                </div>
                <div style="height: 10px; text-align: left"></div>
                <div class="row">
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtSalidaFecha" runat="server" Width="100%" />
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtSalidaHora" runat="server" Width="100%" />
                    </div>
                </div>
            </div>

            <div class="col-sm-6" style="text-align: left; background-color: #F7F7F7"" >
                <div style="padding:20px"></div>
                <strong><u>Información de hospedaje</u></strong>
                <br />
                <div style="padding:10px"></div>
                <p>Hotel</p>
                <asp:TextBox ID="txtHospedajeNombre" runat="server" Width="100%"></asp:TextBox>

                <br />
                <br />

                <div class="row">
                    <div class="col-sm-6"><p>Desde</p></div>
                    <div style="height: 10px; text-align: left"></div>
                    <div class="col-sm-6"><p>Check-In</p></div>
                    <div style="height: 10px; text-align: left"></div>
                </div>
                <div class="row">
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtHospedajeLlegadaFecha" runat="server" Width="100%" />
                    </div>
                    <div style="height: 10px; text-align: left"></div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtHosspedajeLlegadaChek" runat="server" Width="100%" />
                    </div>
                    <div style="height: 10px; text-align: left"></div>
                </div>

                <br />

                <div class="row">
                    <div class="col-sm-6"><p>Hasta</p></div>                    
                    <div class="col-sm-6"><p>Check-Out</p></div>
                </div>
                <div class="row">
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtHosopedajeSalidaFecha" runat="server" Width="100%" />
                    </div>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtHospedajeSalidaCkec" runat="server"  Width="100%"/>
                    </div>
                </div>
            </div>
            
            <div class="col-lg-12" style="text-align: center; padding: 2%; background-color: #F7F7F7">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" BackColor="#0A445B" class="btn btn-primary"  />
            </div>

        </div>
<%--         </form>
    </body>
</html>--%>
</asp:Content>
