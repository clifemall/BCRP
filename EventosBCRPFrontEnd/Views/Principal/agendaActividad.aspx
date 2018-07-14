<%@ Page Title="" Language="C#" MasterPageFile="~/Inscripcion.master" AutoEventWireup="true" CodeBehind="agendaActividad.aspx.cs" Inherits="CapaPresentacion.agendaActividad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
                    <strong>Cambios realizados!</strong>
                </div>
                <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                    <strong>No se pudieron ahcer los cambios!</strong>
                </div>
                <p>A continuación seleccione las actividades a las que asistirá</p>
                <br />
                <asp:GridView ID="GridViewAgendaActividad" runat="server" AutoGenerateColumns="False"
                    overflow="scroll" Width="95%" OnSelectedIndexChanged="GridViewAgendaActividad_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre de Actividad"
                            DataField="NombreActividad"
                            SortExpression="NombreActividad">
                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                        </asp:BoundField>

                        <asp:BoundField HeaderText="Detalle Actividad"
                            DataField="DetalleActividad"
                            SortExpression="DetalleActividad">
                            <ItemStyle HorizontalAlign="Center" Width="68%" />
                        </asp:BoundField>

                        <asp:BoundField HeaderText="CabeceraFecha"
                            DataField="CabeceraFecha"
                            SortExpression="CabeceraFecha">
                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                        </asp:BoundField>

                        <asp:BoundField HeaderText="Duración Actividad"
                            DataField="DuracionActividad"
                            SortExpression="DuracionActividad">
                            <ItemStyle HorizontalAlign="Center" Width="10%" />
                        </asp:BoundField>
                        <asp:CommandField ButtonType="Image" SelectImageUrl="img/edit3.png" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <br />
        <br />
        <div class="row" style="text-align: center">
            <div class="col-lg-10">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
            </div>
        </div>
    </div>


</asp:Content>
