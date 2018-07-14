<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEvento.Master" AutoEventWireup="true" CodeBehind="agenda.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.agenda" %>

<asp:Content ID="BodyPage" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <p class="titulocontenedor"><u>Agenda</u></p>
    </div>
    <div class="row" style="text-align: center">
        <div class="col-sm-12">
            <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
                <strong>Cambios realizados!</strong>
            </div>
            <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                <strong>No se pudieron ahcer los cambios!</strong>
            </div>
            <p>A continuación seleccione las actividades a las que asistirá</p>
            <br />
            <div class="panel-body scrollbar-black" runat="server" style="overflow-y: scroll; height: 100%; max-height: 430px;">
            <asp:Repeater ID="ParentRepeater" runat="server" OnItemDataBound="ItemBound">
                <ItemTemplate>
                    <div class="navbar" style="background-color:#0A435E; color:whitesmoke;">
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("CabeceraFecha").ToString() %>'></asp:Label>
                    </div>

                    <asp:Repeater ID="ChildRepeater" runat="server">
                        <HeaderTemplate>
                            <table class="table table-responsive-sm ">



<%--                                <tr>
                                    <th>
                                        <%#Eval("CabeceraFecha").ToString() %>
                                    </th>
                                </tr>--%>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <th>
                                    <div style="display: inline-block;">
                                    <p class="nomargin" style="font-size: 13px; font-weight:normal"><%# EventosBCRPFrontEnd.Functions.clGetSplitIndex.Read(Eval("DuracionActividad").ToString(), "\\n\\r", 0) %></p>
                                    <p class="nomargin" style="font-size: 13px; font-weight:normal"><%# EventosBCRPFrontEnd.Functions.clGetSplitIndex.Read(Eval("DuracionActividad").ToString(), "\\n\\r", 2) %></p>
                                    </div>
                                </th>
                                <th>
                                    <div class="ellipsis" style="font-size: 13px; font-weight:normal">
                                        <%#Eval("DetalleActividad").ToString() %>
                                    </div>
                                </th>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>

                        <%--<asp:Table ID="myTable" runat="server" Width="100%"> 
                        <asp:TableRow>
                            <asp:TableCell>Name</asp:TableCell>
                            <asp:TableCell>Task</asp:TableCell>
                            <asp:TableCell>Hours</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table> --%>
                        <%--<asp:GridView ID="GridViewAgendaActividad" runat="server" AutoGenerateColumns="False"
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
                    </asp:GridView>--%>
                    </asp:Repeater>

                </ItemTemplate>
            </asp:Repeater>
                </div>
        </div>
        <br />
        <br />
        <div class="col-lg-10">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
        </div>
    </div>
</asp:Content>
